using LumenWorks.Framework.IO.Csv;
using System.Data;
using System.IO;
using System.Windows.Forms;
namespace Leer_Archivo_Csv
{
    static class ClsLeer
    {
        static OpenFileDialog op;
        static string path;
        static DataTable dtCsv;
        public static string setPath()
        {
            op = new OpenFileDialog();
            op.Filter = "CSV file | *.csv";
            if (op.ShowDialog() == DialogResult.OK)
            {
                path = op.FileName;
            }

            return path;
        }

        public static DataTable getData(string PATH)
        {
            using (var csvReader = new CsvReader(new StreamReader(File.OpenRead(PATH)), true))
            {             
                    dtCsv = new DataTable();
                    dtCsv.Load(csvReader);
            }
                return dtCsv;
        }


    }
}
