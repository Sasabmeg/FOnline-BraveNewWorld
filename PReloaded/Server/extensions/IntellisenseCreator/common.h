#include <string>
#include <vector>

using namespace std;

void RemoveSpaces(string& str);
void ProcessName(string& name);
void FormatArrays(string& st);
void FormatUnknown(string& st);
void Process(string& st);

bool ApplyParams(string& name, vector<string>& params);
void ToBaseDecl(string& decl, vector<string>& params);
bool IsDeclaration(string& str);
bool IsProperString(string& str);
void ProcessParameters(const char* filename, const char* message);
