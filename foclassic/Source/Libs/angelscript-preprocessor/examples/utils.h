// Utility functions

#if defined(_WIN32) || defined(_WIN64)
    #define PP_WINDOWS
#elif defined (__linux__)
    #define PP_LINUX
#else
    #error "Unknown operating system"
#endif

#ifdef UTILS_FORMATPATH
#include <cstring>

#ifdef PP_WINDOWS
    #define DIR_SLASH_C   '\\'
    #define DIR_SLASH_SD  ".\\"
    #define DIR_SLASH_SDD "..\\"
#else
    #define DIR_SLASH_C   '/'
    #define DIR_SLASH_SD  "./"
    #define DIR_SLASH_SDD "../"
#endif

void FormatPath( char* path ) // as in FOnline
{
    for( char* str = path; *str; str++ )
    {
        #ifdef PP_WINDOWS
        if( *str == '/' )
            *str = '\\';
        #else
        if( *str == '\\' )
            *str = '/';
        #endif
    }

    while( path[0] == '.' && path[1] == DIR_SLASH_C )
    {
        char* str = path;
        char* str_ = str + 2;
        for( ; *str_; str++, str_++ )
            *str = *str_;
        *str = 0;
    }

    while( path[0] == '.' && path[1] == '.' && path[2] == DIR_SLASH_C )
        path += 3;

    char* str = strstr( path, DIR_SLASH_SDD );
    if( str )
    {
        char* str_ = str + 3;
        str -= 2;
        for( ; str >= path; str-- )
            if( *str == DIR_SLASH_C )
                break;
        if( str < path )
            str = path;
        else
            str++;
        for( ; *str_; str++, str_++ )
            *str = *str_;
        *str = 0;

        FormatPath( path );
        return;
    }

    str = strstr( path, DIR_SLASH_SD );
    if( str )
    {
        char* str_ = str + 2;
        for( ; *str_; str++, str_++ )
            *str = *str_;
        *str = 0;

        FormatPath( path );
        return;
    }
}
#endif // UTILS_FORMATPATH
