using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;

namespace _08_Arraylist_Control_registro_de_personal
{
    class ClsRegistro
    {
        static int num = 0;
     static   DataTable dt=new DataTable();
        public static void generarColumnas()
        {
            dt.Columns.Add("CODIGO");
            dt.Columns.Add("NOMBRE");
            dt.Columns.Add("APELLIDO PATERNO");
            dt.Columns.Add("APELLIDO MATERNO");
            dt.Columns.Add("FECHA DE NACIMIENTO");
            dt.Columns.Add("FECHA DE CONTRATO");
            
        }
        public static DataTable generarTabla(ArrayList personalLista)
        {
            dt.Rows.Clear();
            foreach (ClsPersonal empleado in personalLista)
            {
                dt.Rows.Add(empleado.Codigo, empleado.Nombre, empleado.Paterno, empleado.Materno, empleado.Nacimiento, empleado.Contrato);
            }
            return dt;
        }
        public static string setNumeroRegistro()
        {
            num++;
            return "R"+num.ToString().PadLeft(5,'0');
        }


    }
}
