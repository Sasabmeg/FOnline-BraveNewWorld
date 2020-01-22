set( usage "USAGE: cmake -P _compile.cmake [client/mapper/server]" )

if( "${CMAKE_ARGV3}" STREQUAL "" )
	message( FATAL_ERROR ${usage} )
endif()

set( target "${CMAKE_ARGV3}" )

if( NOT "${target}" MATCHES "^(client|mapper|server)$" )
	message( FATAL_ERROR ${usage} )
endif()

file( STRINGS scripts.cfg modules REGEX "^[\t\ ]*\@[\t\ ]+${target}[\t\ ]+module[\t\ ]+" )
foreach( module IN LISTS  modules )
	if( "${module}" MATCHES "^[\t\ ]*\@[\t\ ]+${target}[\t\ ]+module[\t\ ]+([A-Za-z0-9\\_\\-\\/]+)" )
		set( script "${CMAKE_MATCH_1}.fos" )
		message( STATUS "${script}" )
		execute_process(
			COMMAND ASCompiler.exe ${script} -${target}
			OUTPUT_VARIABLE out
			RESULT_VARIABLE res
		)
		if( NOT res EQUAL 0 OR "${out}" MATCHES "WARNING" )
			message( ${out} )
			execute_process( COMMAND cmd /c pause )
		endif()
	endif()
endforeach()
