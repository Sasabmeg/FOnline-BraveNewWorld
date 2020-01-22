#ifndef __FONLINE_RELOADED__
#define __FONLINE_RELOADED__

#define FOCLASSIC_EXTENSION_STRIP_CONST

// Script constants
#define SKIP_PRAGMAS
// Disable macro redefinition warning
#pragma warning (push)
#pragma warning (disable : 4005)
#define __EXTENSIONS_SOLUTION__
#include "../scripts/FOCLassic.fos"
#include "../scripts/_defines.fos"
#include "FOClassic.h"
#pragma warning (pop)

#ifdef __CLIENT
#pragma message ("compiled as client")
#endif
#ifdef __SERVER
#pragma message ("compiled as server")
#endif
#ifdef __MAPPER
#pragma message ("compiled as mapper")
#endif

// Script global variables
#ifdef INCLUDE_GLOBAL_VARIABLES
struct _GlobalVars
{
	int*  CurX;
	int*  CurY;
	uint* HitAimEyes;
	uint* HitAimHead;
	uint* HitAimGroin;
	uint* HitAimTorso;
	uint* HitAimArms;
	uint* HitAimLegs;
} GlobalVars;
#endif

#endif // __FONLINE_RELOADED__