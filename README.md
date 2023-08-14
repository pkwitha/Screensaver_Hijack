# Screensaver_Hijack
https://attack.mitre.org/techniques/T1546/002/
malware persistence technique and trick.

## Screensavers are programs that execute after a configurable time of user inactivity. They are often used to prevent screen burn-in on older CRT displays or to personalize the PC with additional password protection. In Windows, screensavers are PE-files with a .scr extension by default, and their settings are stored in the registry


## In this method, two programs are written for you in C# language, which include:
 1. Our infected program, which displays a MessageBox for testing purposes.
 2. The program in which persistence is done, which will be explained further.
 


## The registry and values ​​to be set are as follows: (persist.cs)


### HKEY_CURRENT_USER\Control Panel\Desktop\ScreenSaveActive
- set to 1 to enable screensaver.
### HKEY_CURRENT_USER\Control Panel\Desktop\ScreenSaveTimeOut 
- sets user inactivity timeout before screensaver is executed.
### HKEY_CURRENT_USER\Control Panel\Desktop\SCRNSAVE.EXE 
- set the app path to run.

## conclusion:

  - The persistence trick mentioned in the text involves using screensavers to execute a program after a configurable time of user inactivity. However, this method has a limitation in that the session is terminated when the user comes back and the system is not idle.
