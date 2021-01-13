using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace _11_Serializacion_binaria_con_imagenes
{
    class ClsSerializar
    {
        public static void serializar(ClsCliente cliente)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Binary file | *.bin";
            if(sv.ShowDialog()==DialogResult.OK)
            {
                using(FileStream fs=new FileStream(sv.FileName,FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, cliente);
                }
            }
        }

        public static ClsCliente deserializar()
        {
            ClsCliente objcliente=null;
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Binary file | *.bin";
            if(op.ShowDialog()==DialogResult.OK)
            {
                using(FileStream fs=new FileStream(op.FileName,FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    objcliente = (ClsCliente)bf.Deserialize(fs);
                }
            }
            return objcliente;
        }
    }
}
