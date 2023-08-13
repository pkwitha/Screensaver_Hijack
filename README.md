# Screensaver_Hijack
https://attack.mitre.org/techniques/T1546/002/
malware persistence technique and trick.
- The problem with this persistence trick is that the session is terminated when the user comes back and the system is not idle.

### HKEY_CURRENT_USER\Control Panel\Desktop\ScreenSaveActive
- set to 1 to enable screensaver.
### HKEY_CURRENT_USER\Control Panel\Desktop\ScreenSaveTimeOut 
- sets user inactivity timeout before screensaver is executed.
### HKEY_CURRENT_USER\Control Panel\Desktop\SCRNSAVE.EXE 
- set the app path to run.

