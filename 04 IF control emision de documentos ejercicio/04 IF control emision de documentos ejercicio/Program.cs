using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _04_IF_control_emision_de_documentos_ejercicio
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
            Application.Run(new FrmControlDocumentos());
        }
    }
}
