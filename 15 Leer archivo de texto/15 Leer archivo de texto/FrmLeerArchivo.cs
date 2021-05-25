using System;
using System.Windows.Forms;
using System.IO;
namespace _15_Leer_archivo_de_texto
{
    public partial class FrmLeerArchivo : Form
    {
        public FrmLeerArchivo()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                op.Filter = "Text files| *.txt";
                if (op.ShowDialog()==DialogResult.OK)
                {
                   using(StreamReader sr=new StreamReader(op.FileName))
                    {
                        txtAreaTexto.Text = sr.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: "+ex.Message,"ERROR.",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = "Text file | *.txt";
                if (saveFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    {
                        sw.Write(txtAreaTexto.Text);
                        sw.Close();
                      
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "ERROR.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
