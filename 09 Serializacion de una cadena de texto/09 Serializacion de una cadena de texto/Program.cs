using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _09_Serializacion_de_una_cadena_de_texto
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
            Application.Run(new FrmSerializacion());
        }
    }
}
