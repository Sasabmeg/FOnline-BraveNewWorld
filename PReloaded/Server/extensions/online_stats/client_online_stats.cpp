// Author:  Wipe/WHINE Team

#ifndef __CLIENT_ONLINE_STATS_CPP__
#define __CLIENT_ONLINE_STATS_CPP__

#define FOCLASSIC_EXTENSION

#include "../reloaded.h"
//#include "online_stats.h"

#ifdef FO_WINDOWS
#include <windows.h>
#include <shellapi.h>
#pragma comment(lib, "shell32.lib")
#endif

EXPORT void OnlineStats_URL( ScriptString& url )
{
#ifdef FO_WINDOWS
	ShellExecute( NULL, "open", url.c_str(), NULL, NULL, SW_SHOWNORMAL );
#endif
};

#endif /* __CLIENT_ONLINE_STATS_CPP__ */
