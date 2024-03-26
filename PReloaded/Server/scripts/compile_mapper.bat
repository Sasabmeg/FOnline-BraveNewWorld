@echo Compiling: %1
@ascompiler.exe %1 -mapper
@if not exist donotpause @pause