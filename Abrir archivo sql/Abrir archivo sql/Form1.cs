using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Abrir_archivo_sql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string ScriptSql = null;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Sql file | *.sql";
            if(op.ShowDialog()==DialogResult.OK)
            {
                StreamReader file = new StreamReader(op.FileName);
                richTextBox1.Text += file.ReadToEnd();
                ScriptSql = richTextBox1.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ScriptFormateado = ScriptSql.Replace('"', '\'');
            richTextBox1.Text = ScriptFormateado;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Sql script | *.sql";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sv.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter escribir = new StreamWriter(fs);
                escribir.WriteLine(richTextBox1.Text);
                fs.Dispose();
                escribir.Dispose();
                
            }
        }
    }
}
