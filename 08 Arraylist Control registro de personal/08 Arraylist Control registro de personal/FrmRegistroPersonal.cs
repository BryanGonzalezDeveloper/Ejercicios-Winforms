using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _08_Arraylist_Control_registro_de_personal
{
    public partial class FrmRegistroPersonal : Form
    {
        ClsPersonal emp;
        public FrmRegistroPersonal()
        {
            InitializeComponent();
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblRegistro.Text = ClsRegistro.setNumeroRegistro();
            ClsRegistro.generarColumnas();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            emp.editar(codigo, txtNombre.Text, txtPaterno.Text, txtMaterno.Text, dtpNacimiento.Value, dtpContrato.Value);
            dgvInformacion.DataSource = ClsRegistro.generarTabla(ClsPersonal.empleados);
            limpiar();
            btnRegistrar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnActualizar.Enabled = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(!camposVacios())
                {
                    emp = new ClsPersonal
                    (txtNombre.Text, txtPaterno.Text, txtMaterno.Text, dtpNacimiento.Value, dtpContrato.Value, lblRegistro.Text);
                    emp.agregarPersonal();
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    dgvInformacion.DataSource = ClsRegistro.generarTabla(ClsPersonal.empleados);
                    limpiar();

                    lblRegistro.Text = ClsRegistro.setNumeroRegistro();
                }             
                else
                {
                    MessageBox.Show("ASEGURESE DE LLENAR TODOS LOS CAMPOS");
                }
              
            }
            catch (Exception)
            {

                throw;
            }
        }
        string codigo;
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dgvInformacion.SelectedRows.Count==1)
            {
                btnRegistrar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
              codigo = dgvInformacion.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dgvInformacion.CurrentRow.Cells[1].Value.ToString();
                txtPaterno.Text = dgvInformacion.CurrentRow.Cells[2].Value.ToString();
                txtMaterno.Text = dgvInformacion.CurrentRow.Cells[3].Value.ToString();
                             btnActualizar.Enabled = true;

            }
          
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           if(dgvInformacion.SelectedRows.Count==1)
            {
                emp.eliminar(dgvInformacion.CurrentRow.Cells[0].Value.ToString());
                dgvInformacion.DataSource = ClsRegistro.generarTabla(ClsPersonal.empleados);
            }
        }
        void limpiar()
        {
            txtNombre.ResetText();
            txtPaterno.ResetText();
            txtMaterno.ResetText();
            txtNombre.Focus();
        }

        //verifica que los campos esten llenos
        bool camposVacios()
        {
            bool vacios = false;
            if (string.IsNullOrEmpty(txtNombre.Text) | string.IsNullOrEmpty(txtPaterno.Text) | string.IsNullOrEmpty(txtMaterno.Text))
                vacios = true;
            return vacios;
        }

        //Valida que en los controles textbox se introduzca solo texto
        private void ValidarSoloTexto(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) | char.IsLetter(e.KeyChar)|char.IsWhiteSpace(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
