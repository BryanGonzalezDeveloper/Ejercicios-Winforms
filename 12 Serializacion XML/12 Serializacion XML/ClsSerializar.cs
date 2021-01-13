using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace _12_Serializacion_XML
{
    class ClsSerializar
    {
        public static void Serializar(ClsProducto producto)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Xml file | *.xml";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(sv.FileName, FileMode.Create))
                {
                   
                    XmlSerializer objXml = new XmlSerializer(typeof(ClsProducto));
                    objXml.Serialize(fs, producto);
                }
            }
        }

        public static ClsProducto deserealizar()
        {
            ClsProducto objProducto = null;
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Xml file | *.xml";
            if (op.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(op.FileName, FileMode.Open))
                {
                    XmlSerializer objXml = new XmlSerializer(typeof(ClsProducto));
                    objProducto = (ClsProducto)objXml.Deserialize(fs);
                }
            }
            return objProducto;
        }
    }
}
