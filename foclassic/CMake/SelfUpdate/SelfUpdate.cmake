##
## Automagically update CMake to version required by build
##
## NOTES:
##  - DOWNLOAD_DIR/cmake/bin/ must be added to PATH before running this script
##  - [bash] running "hash -r" after this script (but before starting build) might be required
##           when downloading CMake for a first time
##  - [win]  updating running executable might be "tricky" on windows, it's better to delete DOWNLOAD_DIR/cmake/
##           when required version might change (eg. using AppVeyor' cache invalidation)
##

cmake_minimum_required( VERSION 3.0.0 )

##
## configuration
##

# minimum version
set( VERSION_MINIMUM_MAJOR "3" )
set( VERSION_MINIMUM_MINOR "0" )
set( VERSION_MINIMUM_PATCH "0" )

# -DO=file1
# -DO=file1;fileN
# names of files which should be checked separated by semicolon (relative to ROOT_DIR)
set( CHECK_FILES "CMakeLists.txt" )
if( O )
	set( CHECK_FILES "${CHECK_FILES};${O}" )
endif()

# -DIR=path
# path to root directory of current repository
set( ROOT_DIR "." )
if( IR )
	file( TO_CMAKE_PATH "${IR}" ROOT_DIR )
endif()

# -DISABLE_SUBMODULES=1
# disable checking versions of git submodules
set( CHECK_SUBMODULES TRUE )
if( ISABLE_SUBMODULES )
	set( CHECK_SUBMODULES FALSE )
endif()

# -DOWNLOAD_DIR=path
# required CMake will be stored in DOWNLOAD_DIR/cmake/
set( DOWNLOAD_DIR "${CMAKE_CURRENT_LIST_DIR}/Cache" )
if( OWNLOAD_DIR )
	file( TO_CMAKE_PATH "${OWNLOAD_DIR}" DOWNLOAD_DIR )
endif()

# -DOWNLOAD=1
# force downloading CMake even if installed/downloaded version meets requirements
set( DOWNLOAD_FORCED FALSE )
if( OWNLOAD )
	set( DOWNLOAD_FORCED TRUE )
endif()

# -DEBUG=1
if( EBUG )
	set( DEBUG TRUE )
	get_cmake_property( vars VARIABLES )
	list( SORT vars )
	foreach( var IN LISTS vars )
		message(STATUS "${var} = ${${var}}" )
	endforeach()
endif()

##
## helper functions
##

# extract version from cmake_minimum_required() in given file
# if not found, VERSION_MINIMUM* values are used
function( GetRequiredVersion file var )

	if( NOT EXISTS "${file}" )
		set( ${var} "NOT-FOUND" PARENT_SCOPE )
		return()
	endif()

	file( STRINGS "${file}" ver REGEX "^[\ \t]*cmake_minimum_required" )
	if( ver )
		string( REGEX REPLACE ".*VERSION[ \t]+([0-9]+).*" "\\1"                   ver1 "${ver}" )
		string( REGEX REPLACE ".*VERSION[ \t]+([0-9]+\\.[0-9]+).*" "\\1"          ver2 "${ver}" )
		string( REGEX REPLACE ".*VERSION[ \t]+([0-9]+\\.[0-9]+\\.[0-9]+).*" "\\1" ver3 "${ver}" )
	endif()

	if( NOT ver1 OR ver1 MATCHES "cmake" )
		set( ver1 "${VERSION_MINIMUM_MAJOR}" )
	endif()

	if( NOT ver2 OR ver2 MATCHES "cmake" )
		set( ver2 "${ver1}.${VERSION_MINIMUM_MINOR}" )
	endif()

	if( NOT ver3 OR ver3 MATCHES "cmake" )
		set( ver3 "${ver2}.${VERSION_MINIMUM_PATCH}" )
	endif()

	set( ${var} "${ver3}" PARENT_SCOPE )

endfunction()

file( TO_NATIVE_PATH "${CMAKE_COMMAND}" CURRENT_CMAKE )
message( STATUS "CMake:          v${CMAKE_VERSION} (${CURRENT_CMAKE})" )

##
## processing
##

set( VERSION_REQUIRED "${VERSION_MINIMUM_MAJOR}.${VERSION_MINIMUM_MINOR}.${VERSION_MINIMUM_PATCH}" )

# check files
foreach( CHECK_FILE IN LISTS CHECK_FILES )
	GetRequiredVersion( "${ROOT_DIR}/${CHECK_FILE}" VERSION_FILE )
	if( "${VERSION_FILE}" STREQUAL "NOT-FOUND" )
		continue()
	endif()
	file( TO_NATIVE_PATH "${CHECK_FILE}" CHECK_FILE_NATIVE )
	message( STATUS "CMake required: v${VERSION_FILE} (${CHECK_FILE_NATIVE})" )
	if( "${VERSION_FILE}" VERSION_GREATER "${VERSION_REQUIRED}" )
		set( VERSION_REQUIRED "${VERSION_FILE}" )
	endif()
endforeach()

# check git submodules (submodule.dir/CMakeLists.txt only)
if( CHECK_SUBMODULES AND EXISTS "${ROOT_DIR}/.gitmodules" )
	find_package( Git QUIET )
	if( Git_FOUND )
		execute_process(
			COMMAND ${GIT_EXECUTABLE} submodule foreach --quiet "echo $name:::$path"
			OUTPUT_VARIABLE SUBMODULES
		)
		string( REPLACE "\n" ";" SUBMODULES "${SUBMODULES}" )
		foreach( SUBMODULE_INFO IN LISTS SUBMODULES )
			if( "${SUBMODULE_INFO}" MATCHES "^(.+):::(.+)$" )
				set( SUBMODULE_NAME "${CMAKE_MATCH_1}" )
				set( SUBMODULE_PATH "${CMAKE_MATCH_2}" )

				if( EXISTS "${SUBMODULE_PATH}/CMakeLists.txt" )
					GetRequiredVersion( "${SUBMODULE_PATH}/CMakeLists.txt" SUBMODULE_VERSION )
					message( STATUS "CMake required: v${SUBMODULE_VERSION} (git submodule: ${SUBMODULE_NAME})" )

					if( "${SUBMODULE_VERSION}" VERSION_GREATER "${VERSION_REQUIRED}" )
						set( VERSION_REQUIRED "${SUBMODULE_VERSION}" )
					endif()
				endif()
			endif()
		endforeach()
	endif()
endif()

# validate and extract MAJOR.MINOR version
if( "${VERSION_REQUIRED}" MATCHES "^([0-9]+)\\.([0-9]+)\\.([0-9]+)$" )
	set( VERSION_REQ "${CMAKE_MATCH_1}.${CMAKE_MATCH_2}" )
else()
	message( FATAL_ERROR "Invalid version '${VERSION_REQUIRED}" )
endif()

# version check
# if(VERSION_GREATER_EQUAL) ... don't! not a part of cmake v3.0.0
if( NOT DOWNLOAD_FORCED AND NOT "${CMAKE_VERSION}" VERSION_LESS "${VERSION_REQUIRED}" )
	return()
endif()

##
## downloading
##

# cleanup
if( EXISTS "${DOWNLOAD_DIR}/cmake/" )
	file( TO_NATIVE_PATH "${DOWNLOAD_DIR}/cmake/" dir_native )
	message( STATUS "Cleaning ${dir_native}")
	file( REMOVE_RECURSE "${DOWNLOAD_DIR}/cmake/" )
endif()

message( STATUS "Checking system information..." )

# get 32/64 bit
execute_process(
	COMMAND ${CMAKE_COMMAND} --system-information
	OUTPUT_VARIABLE SYSTEM_INFO_DUMP
	WORKING_DIRECTORY ${CMAKE_CURRENT_LIST_DIR}
)

if( "${SYSTEM_INFO_DUMP}" MATCHES "CMAKE_HOST_SYSTEM_PROCESSOR \"([A-Za-z0-9_]+)\"" )
	set( HOST_CPU "${CMAKE_MATCH_1}" )
else()
	message( STATUS "${SYSTEM_INFO_DUMP}" )
	message( STATUS )
	message( FATAL_ERROR "Invalid CPU type" )
endif()

if( "${HOST_CPU}" STREQUAL "AMD64" OR "${HOST_CPU}" STREQUAL "x86_64" )
	set( HOST_32 FALSE )
	set( HOST_64 TRUE )
else()
	set( HOST_32 TRUE )
	set( HOST_64 FALSE )
endif()

# get OS
if( UNIX )
	set( HOST_OS "LINUX")
elseif( WIN32 )
	set( HOST_OS "WINDOWS")
else()
	message( FATAL_ERROR "Invalid OS type" )
endif()

message( STATUS "Checking system information... CPU:${HOST_CPU} OS:${HOST_OS} X32:${HOST_32} X64:${HOST_64}" )

# version check
if( HOST_64 )
	if( UNIX AND "${VERSION_REQUIRED}" VERSION_LESS "3.1.0")
		set( VERSION_64 "3.1.0" )
	elseif( WIN32 AND "${VERSION_REQUIRED}" VERSION_LESS "3.6.0" )
		set( VERSION_64 "3.6.0" )
	endif()
	if( VERSION_64 )
		message( STATUS "Downloading 32-bit package (64-bit is available since CMake v${VERSION_64})" )
		set( HOST_32 TRUE )
		set( HOST_64 FALSE )
	endif()
endif()

# set name of cmake file/directory
# string(APPEND) ... don't! not a part of CMake v3.0.0
set( DOWNLOAD_NAME "cmake-${VERSION_REQUIRED}-" )
if( UNIX )
	set( DOWNLOAD_NAME "${DOWNLOAD_NAME}Linux-")
	if( HOST_32 )
		set( DOWNLOAD_NAME "${DOWNLOAD_NAME}i386" )
	elseif( HOST_64 )
		set( DOWNLOAD_NAME "${DOWNLOAD_NAME}x86_64" )
	endif()
	set( DOWNLOAD_EXT "tar.gz" )
elseif( WIN32 )
	set( DOWNLOAD_NAME "${DOWNLOAD_NAME}win")
	if( HOST_32 )
		set( DOWNLOAD_NAME "${DOWNLOAD_NAME}32-x86")
	elseif( HOST_64 )
		set( DOWNLOAD_NAME "${DOWNLOAD_NAME}64-x64")
	endif()
	set( DOWNLOAD_EXT "zip" )
endif()

set( DOWNLOAD_FILE "${DOWNLOAD_NAME}.${DOWNLOAD_EXT}" )
set( DOWNLOAD_URL "https://cmake.org/files/v${VERSION_REQ}/${DOWNLOAD_FILE}" )

# download
message( STATUS "Downloading ${DOWNLOAD_URL}" )
file( MAKE_DIRECTORY "${DOWNLOAD_DIR}" )
file( DOWNLOAD "${DOWNLOAD_URL}" "${DOWNLOAD_DIR}/${DOWNLOAD_FILE}" STATUS res )
if( DEBUG )
	message( STATUS "DOWNLOAD result:${res}" )
endif()

# extract
file( TO_NATIVE_PATH "${DOWNLOAD_DIR}/${DOWNLOAD_FILE}" EXTRACT_FILE_NATIVE )
message( STATUS "Extracting ${EXTRACT_FILE_NATIVE}" )
execute_process(
	COMMAND ${CMAKE_COMMAND} -E tar xzf ${DOWNLOAD_FILE}
	WORKING_DIRECTORY ${DOWNLOAD_DIR}
	OUTPUT_VARIABLE out
	ERROR_VARIABLE err
	RESULT_VARIABLE res
)
if( DEBUG )
	message( STATUS "EXTRACT result:${rest} output:${out} error:${err}" )
endif()

# cleanup
set( CLEAN_FILE "${DOWNLOAD_DIR}/${DOWNLOAD_FILE}" )
file( TO_NATIVE_PATH "${CLEAN_FILE}" CLEAN_FILE_NATIVE )
message( STATUS "Removing ${CLEAN_FILE_NATIVE}" )
file( REMOVE "${CLEAN_FILE}" )

# simplify directory name
set( RENAME_FROM "${DOWNLOAD_DIR}/${DOWNLOAD_NAME}" )
set( RENAME_TO   "${DOWNLOAD_DIR}/cmake" )
file( TO_NATIVE_PATH "${RENAME_FROM}" RENAME_FROM_NATIVE )
file( TO_NATIVE_PATH "${RENAME_TO}"   RENAME_TO_NATIVE )
message( STATUS "Renaming ${RENAME_FROM_NATIVE} -> ${RENAME_TO_NATIVE}")
file( RENAME "${RENAME_FROM}" "${RENAME_TO}" )

# cleanup harder on CI
if( DEFINED ENV{CI} )
	foreach( CLEAN_DIR IN ITEMS doc man )
		set( CLEAN_SUBDIR "${RENAME_TO}/${CLEAN_DIR}/" )
		if( EXISTS "${CLEAN_SUBDIR}" )
			file( TO_NATIVE_PATH "${CLEAN_SUBDIR}" CLEAN_SUBDIR_NATIVE )
			message( STATUS "Removing ${CLEAN_SUBDIR_NATIVE}" )
			file( REMOVE_RECURSE "${CLEAN_SUBDIR}" )
		endif()
	endforeach()
endif() 