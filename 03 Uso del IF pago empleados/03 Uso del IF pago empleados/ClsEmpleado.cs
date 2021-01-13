using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Uso_del_IF_pago_empleados
{
    class ClsEmpleado
    {
        string nombre;
        string puesto;
        double sueldo;
        double descuento=0;
        double sueldoNeto;
        public ClsEmpleado(string nombre, string puesto)
        {
            this.nombre = nombre;
            this.puesto = puesto;
        }

        //Se asigna el sueldo segun el puesto del empleado:
        void asignarSueldo()
        {
            switch (puesto)
            {
                case "Jefe":
                    sueldo = 3500;
                    break;
                case "Administrativo":
                    sueldo = 2500;
                    break;
                case "Tecnico":
                    sueldo = 1700;
                    break;
                case "Operario":
                    sueldo = 1000;
                    break;
            }
        }
        void asignarDescuento()
        {
            if (sueldo > 2000)
                descuento = 0.125;
        }
       public void AsignarSueldoNeto()
        {
            asignarSueldo();
            asignarDescuento();
            double deduccion = sueldo * descuento;
            sueldoNeto = sueldo - deduccion;
        }
        public override string ToString()
        {
            return string.Format("*********************\n"+"Nombre del empleado:"+nombre+
                "\nSueldo bruto:"+sueldo+"\nPorcentaje de descuento aplicado:"+descuento+"\nSueldo neto:"+sueldoNeto);
        }
    }
}
