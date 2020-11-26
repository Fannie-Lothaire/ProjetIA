using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetIAv0
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false); 
            Application.Run(new frmAccueil());
        }
    }
}
