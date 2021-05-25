using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06Transacciones_sql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_telefonosDataSet.tbl_telefono' table. You can move, or remove it, as needed.
            this.tbl_telefonoTableAdapter.Fill(this.db_telefonosDataSet.tbl_telefono);

        }
        ClsConexion objDB = new ClsConexion();
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count==1)
            {
                string telViejo = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                objDB.updateTelefono(telViejo, txtTelefonoNuevo.Text);
                
            }
        }
    }
}
