#define FOCLASSIC_EXTENSION

#include "common.h"
#include <ctype.h>

void RemoveSpaces(string& str) // assert: no trailing or leading spaces
{
	int pos = 1;
	while(pos + 1 < int(str.size()))
	{
		if(isspace(str[pos]) && !(isalnum(str[pos - 1]) && isalnum(str[pos + 1]))) str.erase(pos, 1);
		else pos++;
	}
}

void ProcessName(string& name)
{
	// to compare with dll-found string
	// we have to cut out all const, inout, in and out
	if(name.substr(0, 6) == "const ")
		name.erase(0, 6);

	if(name.size() > 5 && name.substr(name.size() - 6, 6) == " const")
		name.erase(name.size() - 6, 6);

	bool found = false;
	int pos = 0;
	do
	{
		found = false;
		int pos = name.find("const ");
		while(pos != string::npos && pos < int(name.size()))
		{
			
			if(pos == 0 || !isalnum(name[pos - 1]))
			{
				name.erase(pos, 6);
				found = true;
				pos = name.find("const ");
			}
			else
				pos = name.find("const ", pos + 1);
		}
	}while(found);

	do
	{
		pos = name.find("&inout");
		if(pos != string::npos)
			name.erase(pos + 1, 5);
	}while(pos != string::npos);
	do
	{
		pos = name.find("&in");
		if(pos != string::npos)
			name.erase(pos + 1, 2);
	}while(pos != string::npos);
	do
	{
		pos = name.find("&out");
		if(pos != string::npos)
			name.erase(pos + 1, 3);
	}while(pos != string::npos);

	RemoveSpaces(name);
}

int IndexOf(const char* name, const char* arr[])
{
	int i = 1;
	while(arr[i][0])
	{
		if(!strcmp(arr[i], name))
			return i;
		i += 2;
	}
	return 0;
}

void FormatArrays(string& st)
{
	// remove spaces
	int pos = st.rfind("[]");
	while(pos != string::npos)
	{
		int end = pos;
		pos--;

		// go back until identifier is found
		while(pos && !isalnum(st[pos])) pos--;

		// go back until argument limiter or string start is found
		while(pos && !isspace(st[pos]) && st[pos] != ',' && st[pos] != '(') pos--;
		if(pos) pos++;

		// remake the definition
		string arrtype = "array<" + st.substr(pos, end - pos) + "> ";
		st.replace(pos, end - pos + 2, arrtype);
		pos = st.rfind("[]");
	}

	// make room for "> >"
	while((pos = st.find(">>")) != string::npos) st.replace(pos, 2, "> >"); // n^2, so what

	// remove double spaces
	while((pos = st.find("  ")) != string::npos) st.replace(pos, 2, " ");
}

void FormatUnknown(string& st)
{
	int pos = 0;
	while((pos = st.find("?")) != string::npos)
		st.replace(pos, 1, "unknown");
}

void Process(string& st)
{
	FormatArrays(st);
	FormatUnknown(st);
}
