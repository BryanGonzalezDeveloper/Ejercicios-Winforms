using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06_Condicionales___Registro_multas_de_transito
{
    class ClsMulta
    {
        string placa;
        double velocidad;
        string fecha;
        string hora;
        double multa;

        public string Placa { get => placa; set => placa = value; }
        public double Velocidad { get => velocidad; set => velocidad = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
        public double Multa { get => multa; set => multa = value; }

        public ClsMulta(string placa, double velocidad, string fecha, string hora)
        {
            this.Placa = placa;
            this.Velocidad = velocidad;
            this.Fecha = fecha;
            this.Hora = hora;
        }
       public void asignarMulta()
        {
            if (Velocidad <= 70)
                Multa = 0.00;
            else if (Velocidad <= 90)
                Multa = 120;
            else if (Velocidad <= 100)
                Multa = 240;
            else if (Velocidad > 100)
                Multa = 350;
                
        }

      
        
    }
}
