#define FOCLASSIC_EXTENSION

#include "common.h"
#include "structs.h"
#include <ctype.h>
#include <stdio.h>

extern S_Global* Global;

extern "C" __declspec( dllexport ) extern void (*Log)(const char* frmt, ...);

bool ApplyParams(string& name, vector<string>& params)
{
	bool found = false;
	for(auto it = params.begin(); it != params.end(); ++it)
		if(it->size())
		{
			found = true;
			break;
		}
	if(!found) return false;

	int idx = params.size() - 1;
	int rpos = name.rfind(")");
	if(params[idx].size()) name.insert(rpos, " " + params[idx]);
	idx--;
	while(idx >= 0)
	{
		rpos=name.rfind(",", rpos);
		if(params[idx].size()) name.insert(rpos, " " + params[idx]);
		idx--;
	}
	return true;
}

void ToBaseDecl(string& decl, vector<string>& params) // assert: looks like a declaration
{
	// is more than zero parameters?
	if(decl.find("()") != string::npos) return;

	// get rid of const, inout, in and out
	ProcessName(decl);

	// get rid of +
	int pos=  0;
	do
	{
		pos = decl.find("+");
		if(pos != string::npos) decl.erase(pos, 1);
	}while(pos != string::npos);

	// now we have the base form, need only to cut the parameters and save them
	// enforce a space before each argument
	pos=decl.find("(");
	while(pos < int(decl.size()))
	{
		if((decl[pos] == '&' || decl[pos] == '@' || decl[pos] == ']' || decl[pos] == '>') && isalnum(decl[pos + 1]))
			decl.insert(pos + 1, " ");
		pos++;
	}

	int llim=decl.find("(");
	int rlim=decl.find(")");

	string inside = decl.substr(llim + 1, rlim - llim - 1);
	decl.erase(llim + 1, rlim - llim - 1);

	vector<string> splitted;
	int ll = 0;
	int rl = 0;
	do
	{
		rl = inside.find(",", ll + 1);
		if(rl != string::npos)
		{
			string split = inside.substr(ll, rl - ll);
			splitted.push_back(split);
			ll = rl + 1;
		}
	}while(rl != string::npos);
	string split = inside.substr(ll, inside.size() - ll);
	splitted.push_back(split);
	for(int i = 0, j = splitted.size(); i < j; i++)
	{
		int middle = splitted[i].find(" ");
		if(middle == string::npos)
		{
			params.push_back("");
			continue;
		}
		params.push_back(splitted[i].substr(middle + 1, splitted[i].size() - 1 - middle));
		splitted[i] = splitted[i].substr(0, middle);
	}

	string to_insert = "";
	for(int i=0, j = splitted.size(); i < j; i++)
	{
		if(i) to_insert += ", ";
		to_insert += splitted[i];
	}
	llim = decl.find("(");
	decl.insert(llim + 1, to_insert);
	RemoveSpaces(decl);
}

bool IsDeclaration(string& str) // assert proper
{
	int pos = str.find('(');
	if(pos == string::npos) return false;
	if(str.find('(', pos + 1) != string::npos) return false;
	int pos2 = str.find(')', pos);
	if(pos2 == string::npos) return false;
	if(str.find(')', pos2 + 1) != string::npos) return false;
	return true;
}

bool IsProperString(string& str)
{
	if(!str.size()) return false;
	for(int i=0, j = str.size(); i < j; i++)
	{
		if(isalnum(str[i])) continue;
		switch(str[i])
		{
		case '\t':
		case ' ':
		case '_':
		case '@':
		case '(':
		case ')':
		case '<':
		case '>':
		case '+':
		case ',':
		case '[':
		case ']':
		case '&': continue;
		default: return false;
		}
	}
	return true;
}

void ProcessParameters(const char* filename, const char* message)
{
	Log(message);
	FILE* f;
	fopen_s(&f, filename, "rb");
	vector<string> propers;
	int c = 0;
	char ch[2];
	ch[1] = 0;
	string str = "";
	while((c = fgetc(f)) != EOF)
	{
		if(!c)
		{
			if(::IsProperString(str))
				propers.push_back(str);
			str = "";
		}
		else
		{
			ch[0] = c;
			str.append(ch);
		}
	}
	if(::IsProperString(str))
		propers.push_back(str);

	for(int i = 0, j = propers.size(); i < j; i++)
	{
		if(IsDeclaration(propers[i]))
		{
			Class* cl = NULL;
			if(i + 1 < j) cl = Global->FindClass(propers[i + 1]);

			string base_decl(propers[i]);
			vector<string> vec;

			ToBaseDecl(base_decl, vec);
			if(!vec.size()) continue;

			if(cl)
			{
				// possibly a member
				bool found = false;
				for(auto it = cl->Members.begin(); it != cl->Members.end(); ++it)
				{
					Member* member = *it;
					if(member->ProcessedDeclaration == base_decl)
					{
						member->ApplyParams(vec);
						found = true;
						break;
					}
				}
				if(!found) cl = NULL;
			}
			
			if(!cl)
			{
				// global function or member function not found, try anyway
				bool found = false;
				for(auto it = Global->Functions.begin(); it != Global->Functions.end(); ++it)
				{
					Function* func = *it;
					if(func->ProcessedDeclaration == base_decl)
					{
						func->ApplyParams(vec);
						found = true;
						break;
					}
				}

				for(auto it = Global->Classes.begin(); it != Global->Classes.end() && !found; ++it)
				{
					Class* cl = *it;
					for(auto it2 = cl->Members.begin(); it2 != cl->Members.end(); ++it2)
					{
						Member* member = *it2;
						if(member->ProcessedDeclaration == base_decl)
						{
							member->ApplyParams(vec,true);
							found = true;
							break;
						}
					}
				}
			}
		}
	}
	fclose(f);
}
