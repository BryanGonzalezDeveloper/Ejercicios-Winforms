using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace _09_Serializacion_de_una_cadena_de_texto
{
    class ClsSerializacion
    {
        static SaveFileDialog sv;
        static OpenFileDialog op;
        public static void serializar(string texto)
        {
            sv = new SaveFileDialog();
            sv.Filter = "Binary file | *.bin";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(sv.FileName, FileMode.Create))
                {
                    //convierte texto en binario
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, texto);
                }
            }
        }

        public static string deserializar()
        {
            op = new OpenFileDialog();
            string texto = string.Empty;
            op.Filter = "Binary file | *.bin";
            if (op.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(op.FileName, FileMode.Open))
                {
                    //convertir el archivo binario en texto
                    BinaryFormatter bf = new BinaryFormatter(); ;
                    texto = bf.Deserialize(fs).ToString();
                }
            }
            return texto;
        }
    }
}
