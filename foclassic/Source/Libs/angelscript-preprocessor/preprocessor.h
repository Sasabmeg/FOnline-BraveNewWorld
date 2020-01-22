/*
   Preprocessor 0.7
   Copyright (c) 2005 Anthony Casteel
   Copyright (c) 2015 Anton "Cvet" Tsvetinsky, Grzegorz "Atom" Jagiella

   This software is provided 'as-is', without any express or implied
   warranty. In no event will the authors be held liable for any
   damages arising from the use of this software.

   Permission is granted to anyone to use this software for any
   purpose, including commercial applications, and to alter it and
   redistribute it freely, subject to the following restrictions:

   1. The origin of this software must not be misrepresented; you
      must not claim that you wrote the original software. If you use
      this software in a product, an acknowledgment in the product
      documentation would be appreciated but is not required.

   2. Altered source versions must be plainly marked as such, and
      must not be misrepresented as being the original software.

   3. This notice may not be removed or altered from any source
      distribution.

   The original version of this library can be located at:
   http://www.angelcode.com/angelscript/
   under addons & utilities or at
   http://www.omnisu.com

   Anthony Casteel
   jm@omnisu.com
 */

/*
 * This version has been modified and improved by Anton "Cvet" Tsvetinsky and Rotators team.
 * http://github.com/rotators/angelscript-preprocessor/
 */

#ifndef PREPROCESSOR_H
#define PREPROCESSOR_H

#include <stdio.h>
#include <list>
#include <map>
#include <string>
#include <sstream>
#include <vector>

#define PREPROCESSOR_VERSION_STRING    "0.7"

#ifndef UNUSED_VAR
 #define UNUSED_VAR(x) (void)(x)
#endif

struct Preprocessor
{
    /************************************************************************/
    /* Streams                                                              */
    /************************************************************************/

    struct OutStream
    {
        virtual ~OutStream() {}
        virtual void Write( const char* str, size_t len ) { UNUSED_VAR(str); UNUSED_VAR(len); }

        OutStream& operator<<( const std::string& in )
        {
            Write( in.c_str(), in.length() );
            return *this;
        }
        OutStream& operator<<( const char* in )
        {
            return operator<<( std::string( in ) );
        }
        template<typename T>
        OutStream& operator<<( const T& in )
        {
            std::stringstream strstr;
            strstr << in;
            std::string       str;
            strstr >> str;
            Write( str.c_str(), str.length() );
            return *this;
        }
    };

    struct StringOutStream: public OutStream
    {
        std::string String;

        virtual ~StringOutStream() {}
        virtual void Write( const char* str, size_t len )
        {
            String.append( str, len );
        }
    };

    /************************************************************************/
    /* Include file translator                                               */
    /************************************************************************/

    struct IncludeFileTranslator
    {
        virtual ~IncludeFileTranslator() {};
        virtual void Call( std::string& file ) = 0;
    };
    IncludeFileTranslator* IncludeTranslator;

    /************************************************************************/
    /* Line number translator                                               */
    /************************************************************************/

    struct LineNumberTranslator
    {
        struct Entry
        {
            std::string  File;
            unsigned int StartLine;
            unsigned int Offset;
        };

        std::vector<Entry> lines;

        Entry& Search( unsigned int linenumber );
        void   AddLineRange( const std::string& file, unsigned int start_line, unsigned int offset );
    };

    /************************************************************************/
    /* Lexems                                                               */
    /************************************************************************/

    struct Lexem
    {
        enum LexemType
        {
            IDENTIFIER,             // Names which can be expanded.
            COMMA,                  // ,
            SEMICOLON,
            OPEN,                   // {[(
            CLOSE,                  // }])
            PREPROCESSOR,           // Begins with #
            NEWLINE,
            WHITESPACE,
            IGNORED,
            COMMENT,
            STRING,
            NUMBER,
            BACKSLASH,
        };

        std::string Value;
        LexemType   Type;
    };

    typedef std::list<Lexem>    LexemList;
    typedef LexemList::iterator LLITR;

    static const std::string Numbers;
    static const std::string IdentifierStart;
    static const std::string IdentifierBody;
    static const std::string HexNumbers;

    static const std::string Trivials;
    static const Lexem::LexemType TrivialTypes[12];

    /************************************************************************/
    /* Loader                                                               */
    /************************************************************************/

    struct FileLoader
    {
        virtual ~FileLoader() {}
        virtual bool LoadFile( const std::string& dir, const std::string& file_name, std::vector<char>& data );
    };

    /************************************************************************/
    /* Define table                                                         */
    /************************************************************************/

    typedef std::map<std::string,int> ArgSet;

    struct DefineEntry
    {
        LexemList Lexems;
        ArgSet    Arguments;
    };

    typedef std::map<std::string,DefineEntry> DefineTable;

    DefineTable CustomDefines;

    /************************************************************************/
    /* Pragmas                                                              */
    /************************************************************************/

    struct Pragma
    {
        struct Instance
        {
            std::string  Text;
            std::string  CurrentFile;
            unsigned int CurrentFileLine;
            std::string  RootFile;
            unsigned int GlobalLine;
        };

        struct Callback
        {
            virtual ~Callback() {}
            virtual void CallPragma( const std::string& name, const Pragma::Instance& pi ) = 0;
        };
    };

    Preprocessor();

    /************************************************************************/
    /* Pre preprocess settings                                              */
    /************************************************************************/

    bool IsDefined( const std::string& str );
    void Define( const std::string& str );
    void Define( const std::string& str, const std::string& val );
    void Undef( const std::string& str );
    void UndefAll();

    /************************************************************************/
    /* Preprocess                                                           */
    /************************************************************************/

    int Preprocess( std::string file_path, OutStream& result, OutStream* errors = NULL, FileLoader* loader = NULL, bool skip_pragmas = false );

    void        PrintMessage( const std::string& msg );
    void        PrintWarningMessage( const std::string& warnmsg );
    void        PrintErrorMessage( const std::string& errmsg );

    std::string PrependRootPath( const std::string& filename );

    static std::string RemoveQuotes( const std::string& in );
    static std::string IntToString( int i );
    static bool        SearchString( std::string str, char in );
    static bool        IsHex( char in );
    static bool        IsIdentifierStart( char in );
    static bool        IsIdentifierBody( char in );
    static bool        IsNumber( char in );
    static bool        IsTrivial( char in );

    static char*       ParseBlockComment( char* start, char* end, Lexem& out );
    static char*       ParseCharacterLiteral( char* start, char* end, Lexem& out );
           void        ParseDefine( DefineTable& define_table, LexemList& def_lexems );
           LLITR       ParseDefineArguments( LLITR itr, LLITR end, LexemList& lexems, std::vector<LexemList>& args );
    static char*       ParseFloatingPoint( char* start, char* end, Lexem& out );
           void        ParseIf( LexemList& directive, std::string& name_out );
           LLITR       ParseIfDef( LLITR itr, LLITR end );
            void       ParseUndef( LexemList& directive, DefineTable& define_table );
    static char*       ParseHexConstant( char* start, char* end, Lexem& out );
    static char*       ParseIdentifier( char* start, char* end, Lexem& out );
    static char*       ParseLexem( char* start, char* end, Lexem& out );
    static char*       ParseLineComment( char* start, char* end, Lexem& out );
    static char*       ParseNumber( char* start, char* end, Lexem& out );
    static LLITR       ParsePreprocessor( LexemList& lexems, LLITR itr, LLITR end );
    static char*       ParseStringLiteral( char* start, char* end, char quote, Lexem& out );
           LLITR       ParseStatement( LLITR itr, LLITR end, LexemList& dest );

    static int         Lex( char* begin, char* end, std::list<Lexem>& results );
           LLITR       ExpandDefine( LLITR itr, LLITR ent, LexemList& lexems, DefineTable& define_table );
           bool        ConvertExpression( LexemList& expression, LexemList& output );
           int         EvaluateConvertedExpression( DefineTable& define_table, LexemList& expr );
           bool        EvaluateExpression( DefineTable& define_table, LexemList& directive );
    static std::string AddPaths( const std::string& first, const std::string& second );
           void        ParsePragma( LexemList& args );
    static void        ParseTextLine( LexemList& directive, std::string& message );
    static void        SetLineMacro( DefineTable& define_table, unsigned int line );
    static void        SetFileMacro( DefineTable& define_table, const std::string& file );
           void        RecursivePreprocess( std::string filename, FileLoader& file_source, LexemList& lexems, DefineTable& define_table );
    static void        PrintLexemList( LexemList& out, OutStream& destination );

    /************************************************************************/
    /* Expressions                                                          */
    /************************************************************************/

    static void PreprocessLexem( LLITR it, LexemList& lexems );
    static bool IsOperator( const Lexem& lexem );
    static bool IsIdentifier( const Lexem& lexem );
    static bool IsLeft( const Lexem& lexem );
    static bool IsRight( const Lexem& lexem );
    static int  OperPrecedence( const Lexem& lexem );
    static bool OperLeftAssoc( const Lexem& lexem );

    LineNumberTranslator*     GetLineNumberTranslator();
    std::string               ResolveOriginalFile( unsigned int line_number, LineNumberTranslator* lnt = NULL );
    unsigned int              ResolveOriginalLine( unsigned int line_number, LineNumberTranslator* lnt = NULL );
    std::vector<std::string>& GetFileDependencies();
    std::vector<std::string>& GetFilesPreprocessed();
    std::vector<std::string>& GetParsedPragmas();


    Pragma::Callback* CurPragmaCallback;

    void SetPragmaCallback( Pragma::Callback* callback );
    void CallPragma( const std::string& name, std::string pragma );

    /************************************************************************/
    /*                                                                      */
    /************************************************************************/

    OutStream*               Errors;
    unsigned int             ErrorsCount;
    LineNumberTranslator*    LNT;
    std::string              RootFile;
    std::string              RootPath;
    std::string              CurrentFile;
    unsigned int             CurrentLine;
    unsigned int             LinesThisFile;
    bool                     SkipPragmas;
    std::vector<std::string> FileDependencies;
    std::vector<std::string> FilesPreprocessed;
    std::vector<std::string> Pragmas;
};

#endif // PREPROCESSOR_H
