@ECHO OFF
::=======================
:: SETUP
::=======================
::Jitsi access
set ROOMID=default_room
set DOMAIN=domain:port
::next variables, either True or False
set REQNAME=True
set NOAUDIO=True
set NOVIDEO=True
::specify the display language (en/fr/ru)
set LANG=en
::======================
:: Plugin URL and paths
::======================
set origin=setup.msi
set target=%ProgramFiles%\Jitsi Meet Outlook
:: if x86 version, use target=%ProgramFiles(x86)%\Jitsi Meet Outlook
:: if x64 version, use target=%ProgramFiles%\Jitsi Meet Outlook


::===============

ECHO Deleting previous version...
IF EXIST %target% (
    ECHO uninstalling %target%
    msiexec /uninstall "%origin%" /passive
) ELSE ( 
    ECHO No previous installation found.
)
ECHO Plugin installation...
msiexec /i "%origin%" TARGETDIR="%target%" DOMAIN="%DOMAIN%" ROOMID="%roomid%" REQNAME="%reqname%" NOAUDIO="%noaudio%" NOVIDEO="%novideo%" LANG="%lang%" /passive
ECHO Done.
PAUSE
