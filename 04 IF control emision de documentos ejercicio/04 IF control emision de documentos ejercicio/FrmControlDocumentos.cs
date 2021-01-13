using System;
using System.Windows.Forms;

namespace _04_IF_control_emision_de_documentos_ejercicio
{
    public partial class FrmControlDocumentos : Form
    {
        ClsDocumento objDoc;
        public FrmControlDocumentos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            objDoc = new ClsDocumento(txtNum.Text, dtpEmision.Value, txtEmpresa.Text);
            objDoc.agregarDocumento();
            cargarDatos();
        }
       
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void cargarDatos()
        {
            dgvDatos.DataSource = null;
            foreach (ClsDocumento doc in objDoc.getLista())       
                dgvDatos.Rows.Add(doc.NumeroDoc, doc.NombreEmpresa, doc.FechaEmi.ToShortDateString(), doc.AniosRegistro, doc.Condicion);
        }
        void limpiar()
        {
            txtNum.ResetText();
            txtEmpresa.ResetText();
            dtpEmision.Value = DateTime.Now;
        }
    }
}
