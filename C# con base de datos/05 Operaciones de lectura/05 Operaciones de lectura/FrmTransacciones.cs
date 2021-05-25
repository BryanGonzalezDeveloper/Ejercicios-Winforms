using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Operaciones_de_lectura
{
    public partial class FrmTransacciones : Form
    {
        public FrmTransacciones()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex!=-1)
            {
                var tfnViejo = from dato in lista
                               where dato.nombre.Equals(listBox1.Text)
                               select new {tel= dato.telefono };
                string telefonoViejo = null;
                foreach (var item in tfnViejo)
                {
                    telefonoViejo = item.tel;
                    break;
                }
                obj.updateTelefono(telefonoViejo, txtTelefono.Text);
            }
        }
        List<Db_telefonos> lista;
        ClsConexion obj;
        private void button1_Click(object sender, EventArgs e)
        {
            obj = new ClsConexion();
            lista = obj.consultaSP(txtBusqueda.Text);
           
            foreach (var item in lista)
            {
                listBox1.Items.Add(item.nombre);
            }
        }
    }
}
