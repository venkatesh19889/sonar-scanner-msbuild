@PowerShell -NonInteractive -NoProfile -ExecutionPolicy Unrestricted -Command "& {.\scripts\build\build.ps1; exit $LastExitCode }"
@echo From Cmd.exe: build.ps1 exited with exit code %errorlevel%
exit %errorlevel%