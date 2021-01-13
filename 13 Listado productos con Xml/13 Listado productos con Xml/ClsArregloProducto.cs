using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
namespace _13_Listado_productos_con_Xml
{
    [XmlRoot("ClsProducto")]
    class ClsArregloProducto
    {
        [XmlArrayItem(typeof(ClsProducto))]
        public List<ClsProducto> listaProductos = new List<ClsProducto>();

        public static ClsArregloProducto leerXml()
        {
            ClsArregloProducto objArr = null;
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Xml file | *.xml";
            if(op.ShowDialog()==DialogResult.OK)
            {
                using (FileStream file = new FileStream(op.FileName, FileMode.Open))
                {
                    XmlSerializer objXml = new XmlSerializer(typeof(ClsArregloProducto));
                     objArr = (ClsArregloProducto)objXml.Deserialize(file);
                }

            }
            return objArr;
        }
    }
}
