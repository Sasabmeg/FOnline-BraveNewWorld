#define FOCLASSIC_EXTENSION

#include "structs.h"
#include "common.h"

void Function::ProcessDeclaration()
{
	ProcessedDeclaration = Declaration;
	::ProcessName(ProcessedDeclaration);
}

void Function::ApplyParams(vector<string>& params, bool guessed /* = false */)
{
	if(!Applied)
	{
		Applied = true;
		if(::ApplyParams(Declaration, params) && guessed) Comment = " // Arguments for this function have been guessed";
	}
}

Class::~Class()
{
	for(auto it = Members.begin(); it != Members.end(); ++it)
		delete *it;
}

const char* OperUnaryPrefOrIndexData[] =
{
	"operator -",	"opNeg",
	"operator ~",	"opCom",
	"operator ++",	"opPreInc",
	"operator --",	"opPreDec",
	"operator []",	"opIndex"
	"\0",	"\0"
};

const char* OperUnaryPostData[] =
{
	"operator ++",	"opPostInc",
	"operator --",	"opPostDec",
	"\0",	"\0"
};

const char* OperAssignOrBinaryData[] =
{
	"operator =",	"opAssign",
	"operator +=",	"opAddAssign",
	"operator -=",	"opSubAssign",
	"operator *=",	"opMulAssign",
	"operator /=",	"opDivAssign",
	"operator %=",	"opModAssign",
	"operator &=",	"opAndAssign",
	"operator |=",	"opOrAssign",
	"operator ^=",	"opXorAssign",
	"operator <<=",	"opShlAssign",
	"operator >>=", 	"opShrAssign",
	"operator >>>=", 	"opUShrAssign",
	"operator ==",	"opEquals",
	"operator !=",	"opEquals",
	"operator <",	"opCmp",
	"operator <=",	"opCmp",
	"operator >",	"opCmp",
	"operator >=",	"opCmp",
	"operator +",	"opAdd",
	"operator -",	"opSub",
	"operator *",	"opMul",
	"operator /",	"opDiv",
	"operator %",	"opMod",
	"operator &",	"opAnd",
	"operator |",	"opOr",
	"operator ^",	"opXor",
	"operator <<",	"opShl",
	"operator >>",	"opShr",
	"operator >>>",	"opUShr",
	"\0",	"\0"
};

// helper
void FillMap(StrStrMMap& map, const char* data[])
{
	int i = 0;
	while(data[i][0])
	{
		string key = data[i + 1];
		string value = data[i];
		map.insert(pair<string,string>(key, value));
		i += 2;
	}
}

S_Global::S_Global()
{
	FillMap(OperUnaryPrefOrIndex, OperUnaryPrefOrIndexData);
	FillMap(OperUnaryPost, OperUnaryPostData);
	FillMap(OperAssignOrBinary, OperAssignOrBinaryData);
}

S_Global::~S_Global()
{
	for(auto it = Classes.begin(); it != Classes.end(); ++it)
		delete *it;
	for(auto it = Properties.begin(); it != Properties.end(); ++it)
		delete *it;
	for(auto it = Functions.begin(); it != Functions.end(); ++it)
		delete *it;
}

Class* S_Global::FindClass(const string& str)
{
	for(int i = 0, j = Classes.size(); i < j; i++)
		if(Classes[i]->BaseName == str) return Classes[i];
	return NULL;
}
