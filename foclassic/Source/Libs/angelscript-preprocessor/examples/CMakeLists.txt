cmake_minimum_required( VERSION 3.0.2 )

set( CMAKE_BUILD_TYPE Release )

add_subdirectory( .. angelscript-preprocessor )

macro( add_example_executable target source )
	add_executable( ${target} ${source} )
	if( CMAKE_COMPILER_IS_GNUCXX )
		target_compile_options( ${target} PRIVATE "-std=c++0x" )
	endif()
	target_link_libraries( ${target} angelscript-preprocessor )
endmacro()

add_example_executable( dependencies dependencies.cpp )
add_example_executable( minipreprocessor minipreprocessor.cpp )
add_example_executable( pragma pragma.cpp )
