using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cefsharp_v2
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
            //Debugging port capabilities are to be enabled to be able to test with Selenium
            var settings = new CefSettings();
            settings.RemoteDebuggingPort = 8081;
            Cef.Initialize(settings);

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new FrmMainForm());
    }
  }
}
