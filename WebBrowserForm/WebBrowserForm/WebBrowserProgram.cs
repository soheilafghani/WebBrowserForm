using RegistryManager;
using System;
using System.Windows.Forms;

namespace WebBrowserForm
{
  static class WebBrowserProgram
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      RegistryEditor.RegisterWebBrowserVersion(IEVersion.LATEST);

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new WebBrowserForm());
    }
  }
}
