using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RegistryManager
{
  public static class RegistryEditor
  {
    private const string BrowserKeyAddress = @"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION";

    public static void RegisterWebBrowserVersion(IEVersion IEVersion = IEVersion.LATEST, string fileName = null)
    {
      fileName = fileName == null ? Path.GetFileName(Application.ExecutablePath) : fileName;
      if (IEVersion == IEVersion.NONE)
        UnRegisterIEVersion(fileName);
      else
        RegisterIEVersion(fileName, IEVersion);
    }

    private static void UnRegisterIEVersion(string fileName)
    {
      RegistryKey key = OpenRegistryKey(BrowserKeyAddress, true);
      if (key.GetValueNames().Any(x => x == fileName))
        key.DeleteValue(fileName);
      key.Close();
    }

    private static void RegisterIEVersion(string fileName, IEVersion IEVersion)
    {
      RegistryKey key = OpenRegistryKey(BrowserKeyAddress, true);
      if (!key.GetValueNames().Any(x => x == fileName) ||
          (int)key.GetValue(fileName) != (int)IEVersion)
        key.SetValue(fileName, (int)IEVersion, RegistryValueKind.DWord);
      key.Close();
    }

    private static RegistryKey OpenRegistryKey(string keyAddress, bool writeable = false)
    {
      return Registry.CurrentUser.OpenSubKey(keyAddress, true);
    }

    public static IEVersion? GetIEVersion(string IEVersion)
    {
      if (Enum.IsDefined(typeof(IEVersion), IEVersion))
        return (IEVersion)Enum.Parse(typeof(IEVersion), IEVersion);
      return null;
    }
  }

  public enum IEVersion : int
  {
    NONE = -1,
    LATEST = 0,
    IE11 = 11001,
    IE11DOC = 11000,
    IE10 = 10001,
    IE10DOC = 10000,
    IE9 = 9999,
    IE9DOC = 9000,
    IE8 = 8888,
    IE8DOC = 8000,
    IE7 = 7000
  }
}
