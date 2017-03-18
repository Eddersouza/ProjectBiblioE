using System;
using System.Windows.Forms;

using ProjectBiblioE.Presentation.WinForms.Views.Principal;

namespace ProjectBiblioE.Presentation.WinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FirstScreen());
        }
    }
}