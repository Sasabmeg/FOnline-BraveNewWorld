#include <cstdlib>
#include <string>
#include <vector>


#include "../preprocessor.h"

int main( int argc, char** argv )
{
    if( argc != 2 )
    {
        fprintf( stderr, "Usage: minipreprocessor [script_file]\n\n" );
        exit( EXIT_FAILURE );
    }

    Preprocessor preprocessor;
    Preprocessor::StringOutStream result, errors;

    int errors_count = preprocessor.Preprocess( argv[1], result, &errors );
    if( errors.String != "" )
    {
        while( errors.String[errors.String.length()-1] == '\n' )
            errors.String.pop_back();

        fprintf( stderr, "%s\n", errors.String.c_str() );
    }

    if( errors_count )
    {
        fprintf( stderr, "Unable to preprocess file <%s>\n",  argv[1] );

        return( EXIT_FAILURE );
    }

    fprintf( stdout, "%s\n", result.String.c_str() );

    return( EXIT_SUCCESS );
}
