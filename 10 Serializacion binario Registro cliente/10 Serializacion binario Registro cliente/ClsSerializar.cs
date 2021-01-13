using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace _10_Serializacion_binario_Registro_cliente
{
 
    class ClsSerializar
    {
        static SaveFileDialog sv;
        static OpenFileDialog op;
        
        public static void serializar(ClsCliente cliente)
        {
            sv = new SaveFileDialog();
            sv.Filter = "Binary file | *.bin";
            if(sv.ShowDialog()==DialogResult.OK)
            {
                using (FileStream fs = new FileStream(sv.FileName, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, cliente);
                }
            }
        }

        public static ClsCliente deserializar()
        {
            ClsCliente obj=null;
            op = new OpenFileDialog();
            op.Filter = "Binary file | *.bin";
            if(op.ShowDialog()==DialogResult.OK)
            {
                using (FileStream fs = new FileStream(op.FileName, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                     obj = (ClsCliente)bf.Deserialize(fs);
                }
                    
            }
            return obj;
        }
    }
}
