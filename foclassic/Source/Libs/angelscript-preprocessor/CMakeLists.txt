cmake_minimum_required( VERSION 2.8 )

add_library( angelscript-preprocessor STATIC preprocessor.cpp preprocessor.h )

if( MSVC )
	# TODO
else()
	# extra warnings + MSVC = bad idea
	include( CheckCXXCompilerFlag )
	check_cxx_compiler_flag( -Wall   AS_PREPROCESSOR_WALL )
	check_cxx_compiler_flag( -Werror AS_PREPROCESSOR_WERROR )
	check_cxx_compiler_flag( -Wextra AS_PREPROCESSOR_WEXTRA )
endif()

if( AS_PREPROCESSOR_WALL )
	target_compile_options( angelscript-preprocessor PRIVATE -Wall )
endif()

if( AS_PREPROCESSOR_WERROR )
	target_compile_options( angelscript-preprocessor PRIVATE -Werror )
endif()

if( AS_PREPROCESSOR_WEXTRA )
	target_compile_options( angelscript-preprocessor PRIVATE -Wextra )
endif()

target_include_directories( angelscript-preprocessor PUBLIC "${CMAKE_CURRENT_LIST_DIR}" )
