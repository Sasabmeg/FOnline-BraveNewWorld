#define FOCLASSIC_EXTENSION

#include "../reloaded.h"

extern void RegisterAngelScriptExtensions();

FOCLASSIC_EXTENSION_ENTRY(compiler)
{
	// bool compiler - true if script compiled using ASCompiler, false if script compiled in server
	// In this function all global variables is initialized, if compiled not by compiler

	RegisterAngelScriptExtensions();

	if(compiler) return;

}
