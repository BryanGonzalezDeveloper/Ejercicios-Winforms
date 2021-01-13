using System;
using System.Collections;

namespace _08_Arraylist_Control_registro_de_personal
{
    class ClsPersonal
    {
        string nombre;
        string paterno;
        string materno;
        string codigo;
        DateTime nacimiento;
        DateTime contrato;
        public  static ArrayList empleados = new ArrayList();
        public ClsPersonal(string nombre, string paterno, string materno, DateTime nacimiento, DateTime contrato, string codigo)
        {
            this.Nombre = nombre;
            this.Paterno = paterno;
            this.Materno = materno;
            this.Nacimiento = nacimiento;
            this.Contrato = contrato;
            this.Codigo = codigo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Paterno { get => paterno; set => paterno = value; }
        public string Materno { get => materno; set => materno = value; }
        public DateTime Nacimiento { get => nacimiento; set => nacimiento = value; }
        public DateTime Contrato { get => contrato; set => contrato = value; }
        public string Codigo { get => codigo; set => codigo = value; }

        public void agregarPersonal()
        {
            empleados.Add(this);
        }
        public void editar(string codigo, string nombre, string paterno, string materno, DateTime nacimiento, DateTime contrato)
        {
            foreach (ClsPersonal emp in empleados)
            {
                if (emp.Codigo.Equals(codigo))
                {
                    emp.Nombre = nombre;
                    emp.Paterno = paterno;
                    emp.Materno = materno;
                    emp.Nacimiento = nacimiento;
                    emp.Contrato = contrato;
                }
            }
        }

        public void eliminar(string codigo)
        {
            int i = 0;
            foreach (ClsPersonal emp in empleados)
            {
                if (emp.Codigo.Equals(codigo))
                {
                    empleados.RemoveAt(i);
                    break;
                }
                    
                i++;
            }
        }
    }
}
