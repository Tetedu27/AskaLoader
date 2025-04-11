using AskaBuilder.AskaForms;
using System;
using System.Windows.Forms;

namespace AskaBuilder
{
    internal static class AskaRuntime
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var loaderWindow = new AskaForms.LoaderWindow();
            loaderWindow.ShowDialog(); 

            Application.Run(new MainWindow());
        }
    }
}
