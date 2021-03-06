﻿using System;

namespace _12_Serializacion_XML
{
    public class ClsProducto
    {
        string descripcion;
        string categoria;
        double precio;
        int cantidad;
        DateTime vencimiento;

        public ClsProducto()
        {

        }

        public ClsProducto(string descripcion, string categoria, double precio, int cantidad, DateTime vencimiento)
        {
            this.descripcion = descripcion;
            this.categoria = categoria;
            this.precio = precio;
            this.cantidad = cantidad;
            this.vencimiento = vencimiento;
        }

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public DateTime Vencimiento { get => vencimiento; set => vencimiento = value; }
    }
}
