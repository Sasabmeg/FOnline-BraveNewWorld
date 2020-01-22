#include <string>
#include <vector>
#include <map>

using namespace std;
typedef multimap<string,string> StrStrMMap;

struct Enum
{
	string Name;
	vector<string> ValueName;
	vector<int> ValueVal;
	bool ValueAsFlag;

	size_t ValueNameMax;
	int ValueValMax;
};

struct Property
{
	string Type;
	string Name;
	string Namespace;
};

struct Function
{
	string Declaration;
	string ProcessedDeclaration;
	string Name;
	bool Applied;
	string Comment;

	void ProcessDeclaration();
	void ApplyParams(vector<string>& params, bool guessed = false);
};

struct Member : Function
{
	int ParamCount;
};

struct Class
{
	~Class();
	string BaseName;
	string Name;
	vector<string> Properties;
	vector<Member*> Members;
};

struct S_Global
{
	S_Global();
	~S_Global();
	vector<Enum*> Enums;
	vector<Class*> Classes;
	vector<Property*> Properties;
	vector<Function*> Functions;

	StrStrMMap OperUnaryPrefOrIndex;
	StrStrMMap OperUnaryPost;
	StrStrMMap OperAssignOrBinary;

	Class* FindClass(const string& str);
};
