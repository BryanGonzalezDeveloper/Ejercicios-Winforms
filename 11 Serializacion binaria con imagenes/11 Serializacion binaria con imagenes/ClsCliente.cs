using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;


namespace _11_Serializacion_binaria_con_imagenes
{
    [Serializable()]
    class ClsCliente
    {
        string nombre;
        string paterno;
        string materno;
        string correo;
        Bitmap imagen;

        public ClsCliente(string nombre, string paterno, string materno, string correo, Bitmap imagen)
        {
            this.nombre = nombre;
            this.paterno = paterno;
            this.materno = materno;
            this.correo = correo;
            this.imagen = imagen;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Paterno { get => paterno; set => paterno = value; }
        public string Materno { get => materno; set => materno = value; }
        public string Correo { get => correo; set => correo = value; }
        public Bitmap Imagen { get => imagen; set => imagen = value; }
    }
}
