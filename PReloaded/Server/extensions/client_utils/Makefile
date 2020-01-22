DIR_TOP = ..
DIR_FOEX = $(DIR_TOP)/fonline_ex
TARGET = client_utils
DEFINES = __CLIENT
SRC = \
    dllmain.cpp \
    \
    AngelScript_client.cpp \
    $(DIR_TOP)/buffer_lazy/buffer_lazy.cpp \
    $(DIR_TOP)/online_stats/client_online_stats.cpp \
    \
    $(DIR_FOEX)/fonline_ex.cpp \
    $(DIR_FOEX)/addons/Alpha.cpp \
    $(DIR_FOEX)/addons/Misc.cpp

DIRS_INCLUDE = $(DIR_TOP) $(DIR_TOP)/3rdParty/angelscript/include $(DIR_TOP)/3rdParty/angelscript/source $(DIR_FOEX)

CXXFLAGS = -Wno-invalid-offsetof

include $(DIR_TOP)/Makefile.reloaded

all: $(SO)
