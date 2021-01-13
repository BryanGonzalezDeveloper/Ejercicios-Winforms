using System;
using System.Windows.Forms;

namespace _07_Condicionales___Registro_de_estudiantes
{
    public partial class FrmPostulante : Form
    {
        public FrmPostulante()
        {
            InitializeComponent();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            if(cboCarrera.SelectedIndex!=-1)
            {
                try
                {
                    ClsPostulante objPostulante = new ClsPostulante(txtNombre.Text, Convert.ToByte(txtPuntaje.Text), cboCarrera.Text);
                    objPostulante.setInformacion();
                    richResultado.Text = objPostulante.ToString();
                }
                catch (Exception ez)
                {

                    MessageBox.Show(ez.Message);
                }
                 
            }else
                MessageBox.Show("Selecciona una carrera");
        }
    }
}
