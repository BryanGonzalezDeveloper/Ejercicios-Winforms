using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10_Serializacion_binario_Registro_cliente
{
    [Serializable()]
    class ClsCliente
    {
        string nombre;
        string paterno;
        string materno;
        string email;

        public ClsCliente(string nombre, string paterno, string materno, string email)
        {
            this.nombre = nombre;
            this.paterno = paterno;
            this.materno = materno;
            this.email = email;
        }


        public string Nombre { get => nombre; set => nombre = value; }
        public string Paterno { get => paterno; set => paterno = value; }
        public string Materno { get => materno; set => materno = value; }
        public string Email { get => email; set => email = value; }
    }
}
