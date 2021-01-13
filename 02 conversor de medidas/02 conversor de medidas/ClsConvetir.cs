using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_conversor_de_medidas
{
    class ClsConvetir
    {
         double  Metros;
        double centimetros;
        public ClsConvetir(double metros)
        {
            Metros = metros;
        }

        //convierte una cantidad de metros a centimetros
        public  double MetroCentimetro()
        {
            centimetros = Metros * 100;
            return centimetros;
        }

        //convierte una cantidad de metros a pulgadas
        public double MetroPulgada()
        {
            return centimetros / 2.54;
        }

        //convierte una cantidad de metros a pies
        public double MetroPie()
        {
            return centimetros / 30.48;
        }

        //convierte una cantidad de metros a yardas
        public double MetroYarda()
        {
            return centimetros / 91.44;
        }
    }
}
