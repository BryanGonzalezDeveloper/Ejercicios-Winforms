using System;

namespace _13_Listado_productos_con_Xml
{
    public class ClsProducto
    {
        string descripcion;
        string categoria;
        double precio;
        int cantidad;
        DateTime vencimiento;

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public DateTime Vencimiento { get => vencimiento; set => vencimiento = value; }
    }
}
