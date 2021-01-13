using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Gui_Pago_empleados_POO
{
    class ClsEmpleado
    {
        string nombre;
        double sueldoHora;
        int horasTrab;
        double sueldoBruto, sueldoNeto,sueldoBase;
        //Se aplica una bonificacion del 20 % al sueldo base para generar el sueldo bruto
        double bonificacion = 0.20;
        //se aplica una deduccion de 12% al sueldo bruto para generar el sueldo neto
        double deduccion = 0.12;

        public double SueldoBruto { get => sueldoBruto; }
        public double SueldoNeto { get => sueldoNeto;  }
        public double Bonificacion { get => bonificacion;  }
        public double Deduccion { get => deduccion;  }
        public string Nombre { get => nombre;  }
        public double SueldoHora { get => sueldoHora;  }
        public int HorasTrab { get => horasTrab;  }
        public double SueldoBase { get => sueldoBase; }

        public ClsEmpleado(string nombre, double sueldoHora, int horasTrab)
        {
            this.nombre = nombre;
            this.sueldoHora = sueldoHora;
            this.horasTrab = horasTrab;
        }

        public  void generarSueldoBase()
        {
            sueldoBase = horasTrab * sueldoHora;
        }
        public void generarBonificacion()
        {
            bonificacion *= sueldoBase;
        }
        public void generarSueldoBruto()
        {
            sueldoBruto = sueldoBase + bonificacion;
        }
        public void generarDeduccion()
        {
            deduccion *= sueldoBruto;
        }
        public void generarSueldoNeto()
        {
            sueldoNeto = sueldoBruto - deduccion;
        }


    }
}
