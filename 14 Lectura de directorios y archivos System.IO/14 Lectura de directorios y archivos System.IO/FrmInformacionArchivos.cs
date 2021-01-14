using System;
using System.IO;
using System.Windows.Forms;

namespace _14_Lectura_de_directorios_y_archivos_System.IO
{
    public partial class FrmInformacionArchivos : Form
    {
        public FrmInformacionArchivos()
        {
            InitializeComponent();
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string PATH = txtPath.Text;
                if (File.Exists(PATH))
                {
                    txtInfo.Text = ClsArchivo.getInformacion(PATH);
                    txtInfo.Text += ClsArchivo.getContenidoArchivo(PATH);
                }
                else if (Directory.Exists(PATH))
                {
                    txtInfo.Text = ClsArchivo.getInformacion(PATH);
                    txtInfo.Text += "LISTA DE DIRECTORIOS EN ESTA RUTA:\n\n";
                    foreach (string file in ClsArchivo.getContenidoDirectorio(PATH))
                    {
                        txtInfo.Text += file + "\n\n";
                    }
                }
                else
                    MessageBox.Show("El archivo o directorio: " + PATH + " no existe.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtPath_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //Al dar enter se debe hace la misma accion que cuando se da click al boton, por lo tanto se debe
                pbBuscar_Click(sender, e);//invocar al metodo del boton.


        }



    }
}
