#define FOCLASSIC_EXTENSION

#pragma warning (disable:4996)
#include <stdio.h>
#include <windows.h>
#include <tchar.h>
#include <string>
#include <vector>
#include "./../AngelScript/angelscript.h"
#include "structs.h"
#include "common.h"
#include <assert.h>

#define __INTELLISENSE_CREATOR__
#include "IntellisenseCreatorData.h"
#undef __INTELLISENSE_CREATOR__

#if defined(__GNUC__) // FO_GCC
 //
#elif defined(_MSC_VER) && !defined(__MWERKS__) // FO_MSVC
 #define snprintf sprintf_s
#else
 #error "Unknown compiler."
#endif

using namespace std;

S_Global* Global;

template<class T>
struct ScopeInitializer
{
	ScopeInitializer(T** ptr)
	{
		mptr = new T();
		*ptr = mptr;
	}
	~ScopeInitializer()
	{
		delete mptr;
	}
	T* mptr;
};

enum SubSystem { SysUnknown, SysServer, SysClient, SysMapper };
char* FileNames[] = { "scripts/_solution/intellisense_unknown.h", "scripts/_solution/intellisense.h", "scripts/_solution/intellisense_client.h", "scripts/_solution/intellisense_mapper.h" };
char* SubsystemNames[] = { "unknown", "server", "client", "mapper" };

extern "C" __declspec( dllexport ) void SERVER() { }
extern "C" __declspec( dllexport ) void CLIENT() { }
extern "C" __declspec( dllexport ) void MAPPER() { }
extern "C" __declspec( dllexport ) void (*Log)(const char* frmt, ...) = NULL;
extern "C" __declspec( dllexport ) void Dummy() { }
extern "C" __declspec( dllexport ) asIScriptEngine* ASEngine;
asIScriptEngine* ASEngine;

int __stdcall DllMain(void* module, unsigned long reason, void* reserved)
{
	return 1;
}

template<class InputIterator, class T>
  InputIterator find (InputIterator first, InputIterator last, const T& val)
{
  while (first!=last) {
    if (*first==val) return first;
    ++first;
  }
  return last;
} 

extern "C" __declspec( dllexport ) void DllMainEx(bool compiler)
{
	char executable[1025];
	DWORD size = GetModuleFileName(NULL, executable, 1024);
	executable[size] = 0; // xp patch

	size_t last = size;
	if(last)
		while(last > 0 && executable[last - 1] != '\\' && executable[last - 1] != '/') last--;
	char* executable_name = (char*)((size_t)executable + last);

	if(!Log) Log=(void (__cdecl *)(const char* frmt, ...))printf;
	ScopeInitializer<S_Global> init(&Global);

	IntellisenseCreatorData* data = GetIntellisenseCreatorData( ASEngine );

	/*	order of listing:
		- forward declarations of global types
		- enums
		- global properties
		- class declarations
		- global functions
	*/

	// forward declarations of global types
	for(unsigned int i = 0, j = ASEngine->GetObjectTypeCount(); i < j; i++)
	{
		asIObjectType* obj = ASEngine->GetObjectTypeByIndex(i);
		bool is_template = obj->GetSubTypeId()>=0;
		Class* cl=  new Class();
		cl->BaseName = string(obj->GetName());
		if(is_template)
		{
			cl->Name = string("template <typename T> class ") + cl->BaseName;
			cl->BaseName += "<T>";
		}
		else
			cl->Name = string("class ") + cl->BaseName;
		Global->Classes.push_back(cl);
	}

	// enums
	for( unsigned int i = 0, j = ASEngine->GetEnumCount(); i < j; i++ )
	{
		int typeId;
		const char* nameSpace;
		const char* name = ASEngine->GetEnumByIndex( i, &typeId, &nameSpace );
		int eLen = ASEngine->GetEnumValueCount( typeId );
		if( !eLen )
			continue;

		Enum* enum_ = new Enum();
		enum_->Name = name;
		enum_->ValueNameMax = 0;
		enum_->ValueValMax = 0;
		enum_->ValueAsFlag = false;

		if( find( data->enumAsFlags.begin(), data->enumAsFlags.end(), typeId) != data->enumAsFlags.end() )
			enum_->ValueAsFlag = true;

		for( int e=0; e < eLen; e++ )
		{
			int value = 0;
			const char* name = ASEngine->GetEnumValueByIndex( typeId, e, &value );
			enum_->ValueName.push_back( name );
			enum_->ValueVal.push_back( value );

			size_t len = strlen(name);
			if( enum_->ValueNameMax < len )
				enum_->ValueNameMax = len;
			if( enum_->ValueValMax < value )
				enum_->ValueValMax = value;
		}

		Global->Enums.push_back(enum_);
	}

	// global properties
	for(unsigned int i = 0, j = ASEngine->GetGlobalPropertyCount(); i<  j; i++)
	{
		const char* name;
		const char* namespace_;
		int type_id;
		bool is_const;
		const char* type_name;
		ASEngine->GetGlobalPropertyByIndex(i, &name, &namespace_, &type_id, &is_const);
		type_name = ASEngine->GetTypeDeclaration(type_id);
		string namespace_s(namespace_);
		string name_s(name);
		string type_name_s(type_name);
		Property* prop = new Property();
		prop->Name = name_s;
		prop->Namespace = namespace_s;
		prop->Type = type_name_s;
		Global->Properties.push_back(prop);
	}

	// class declarations
	for(int i =0 , j = ASEngine->GetObjectTypeCount(); i < j; i++)
	{
		// properties
		asIObjectType* obj = ASEngine->GetObjectTypeByIndex(i);
		bool is_template = obj->GetSubTypeId() >= 0;
		string class_name(obj->GetName());
		Class* cl = Global->Classes[i];
		for(unsigned int n = 0, m=obj->GetPropertyCount(); n < m; n++)
			cl->Properties.push_back(string(obj->GetPropertyDeclaration(n)));
		
		// methods
		for(unsigned int n = 0, m = obj->GetMethodCount(); n < m; n++)
		{
			asIScriptFunction* func = obj->GetMethodByIndex(n);
			string decl = func->GetDeclaration(false);
			Member* member = new Member();
			member->Declaration = decl;
			member->ProcessDeclaration();
			member->Name = func->GetName();
			member->Applied = false;
			cl->Members.push_back(member);

			// is the method an operator?
			if(Global->OperUnaryPost.count(member->Name))
				member->ParamCount = func->GetParamCount();
		}
	}

	// global functions
	for(int i = 0, j = ASEngine->GetGlobalFunctionCount(); i < j; i++)
	{
		asIScriptFunction* func = ASEngine->GetGlobalFunctionByIndex(i);
		Function* fn = new Function();
		fn->Declaration = func->GetDeclaration(false);
		fn->Name = func->GetName();
		fn->Applied = false;
		fn->ProcessDeclaration();
		Global->Functions.push_back(fn);
	}

	SubSystem sys = SysUnknown;
	if(Global->FindClass("Critter")) sys = SysServer;
	else if(Global->FindClass("CritterCl")) sys = SysClient;
	else if(Global->FindClass("MapperObject")) sys = SysMapper;

	string message = string("Processing parameters from ") + executable_name + " (" + SubsystemNames[sys] + " subsystem)...\n";

	// here we try to fetch parameters from dlls
	ProcessParameters(executable, message.c_str());

	FILE* f = fopen(FileNames[sys], "w");

	if(!f)
	{
		Log("Couldn't open %s for writing.\n", FileNames[sys]);
		return;
	}

	fprintf(f,"// Generated by FOnline Intellisense Creator for MSVC.\n// Manual changes in this file will be lost if the program is run again.\n\n");

	fprintf(f,"// Used file:\n");
	fprintf(f,"// %s\n", executable_name);

	fprintf(f,"\n#define in\n#define inout\n#define out\n");

	// type definitions
	fprintf(f, "\n// Type definitions\n");
	fprintf(f, "typedef unsigned long long uint64;\n");
	fprintf(f, "typedef unsigned int uint;\n");
	fprintf(f, "typedef unsigned short uint16;\n");
	fprintf(f, "typedef unsigned char uint8;\n");
	fprintf(f, "typedef long long int64;\n");
	fprintf(f, "typedef short int int16;\n");
	fprintf(f, "typedef signed char int8;\n");
	fprintf(f, "typedef void* unknown; // for anonymous types\n");

	
	fprintf(f,"\n// Forward declarations of global types\n");
	for(auto it = Global->Classes.begin(); it != Global->Classes.end(); ++it)
		fprintf(f, "%s;\n", (*it)->Name.c_str());

	fprintf(f,"\n// Enums\n" );
	for(auto it = Global->Enums.begin(); it != Global->Enums.end(); ++it)
	{
		Enum* enum_ = *it;
		fprintf(f, "enum %s\n", enum_->Name.c_str());
		fprintf(f, "{\n");

		char maxval[10];
		snprintf(maxval, sizeof(maxval), "%X", enum_->ValueValMax );

		for( int e=0, eLen = enum_->ValueName.size(); e<eLen; e++ )
		{
			if( e > 0 )
				fprintf(f, ",\n");

			if( (e == 0 && enum_->ValueVal[e] == 0) ||
				(!enum_->ValueAsFlag && e > 0 && enum_->ValueVal[e] == enum_->ValueVal[e-1]+1) )
				fprintf(f, "\t%s", enum_->ValueName[e].c_str() );
			else
			{
				string name = enum_->ValueName[e];
				while( name.length() < enum_->ValueNameMax )
					name += " ";
				fprintf(f, "\t%s = ", name.c_str() );
				if( enum_->ValueAsFlag )
				{
					char fmt[1024];
					snprintf(fmt, sizeof(fmt), "0x%%0%dX", strlen(maxval) );
					fprintf(f, fmt, enum_->ValueVal[e] );
				}
				else
					fprintf(f,"%d", enum_->ValueVal[e] );
			}
		}
		fprintf(f, "\n};\n\n" );
	}

	fprintf(f,"\n// Global properties\n");
	for(auto it = Global->Properties.begin(); it != Global->Properties.end(); ++it)
	{
		Property* prop = *it;
		Process(prop->Type);
		if(prop->Namespace.empty())
			fprintf(f, "%s %s;\n", prop->Type.c_str(), prop->Name.c_str());
		else
			fprintf(f, "%s %s::%s;\n", prop->Type.c_str(), prop->Namespace.c_str(), prop->Name.c_str());
	}

	fprintf(f,"\n// Registered types declarations\n");
	for(auto it = Global->Classes.begin(); it != Global->Classes.end(); ++it)
	{
		Class* cls = *it;
		fprintf(f,"%s\n{\n", cls->Name.c_str());
		for(auto it2 = cls->Properties.begin(); it2 != cls->Properties.end(); ++it2)
		{
			Process(*it2);
			fprintf(f,"\t%s;\n", it2->c_str());
		}
		for(auto it2 = cls->Members.begin(); it2 != cls->Members.end(); ++it2)
		{
			Member* member = *it2;
			Process(member->Declaration);
			fprintf(f, "\t%s;", member->Declaration.c_str());
			if(member->Comment.size()) fprintf(f,"%s", member->Comment.c_str());
			fprintf(f,"\n");

			string name = member->Name;

			auto opDisplay =
				[&](const StrStrMMap& map, bool params)
				{
					auto it = map.lower_bound(name);
					if(it == map.end()) return; // not an operator
					int pos = member->Declaration.find(name);
					for(auto end = map.upper_bound(name); it != end; ++it)
					{
						string decl = member->Declaration;
						decl.replace(pos, it->first.length(), it->second);
						if(params)
						{
							pos = decl.find("(");
							decl.replace(pos, 1, member->ParamCount ? "(int," : "(int");
						}
						fprintf(f, "\t%s; // created from the previous\n", decl.c_str());
					}
				};

			opDisplay(Global->OperUnaryPrefOrIndex, false);
			opDisplay(Global->OperUnaryPost, true);
			opDisplay(Global->OperAssignOrBinary, false);
		}
		fprintf(f,"};\n\n");
	}

	fprintf(f,"\n// Global functions\n");
	for(auto it = Global->Functions.begin(); it != Global->Functions.end(); ++it)
	{
		Function* func = *it;
		Process(func->Declaration);
		fprintf(f, "%s;", func->Declaration.c_str());
		if(func->Comment.size()) fprintf(f, "%s", func->Comment.c_str());
		fprintf(f,"\n");
	}

	Log("File %s successfully generated.\n", FileNames[sys]);
	fclose(f);
}
