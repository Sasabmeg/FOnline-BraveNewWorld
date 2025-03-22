@echo Compiling: %1
@ascompiler.exe --Client %1 -d __CLIENT
@if not exist donotpause @pause