#pragma once

// TODO: reference additional headers your program requires here
#include "../reloaded.h"
#include <stdlib.h>
#include <string>
#include <fstream>
#if defined(FO_WINDOWS)
#include <windows.h>
#elif defined(FO_LINUX)
#include <netinet/in.h>
#define __cdecl __attribute((__cdecl__)) // gcc
#endif
