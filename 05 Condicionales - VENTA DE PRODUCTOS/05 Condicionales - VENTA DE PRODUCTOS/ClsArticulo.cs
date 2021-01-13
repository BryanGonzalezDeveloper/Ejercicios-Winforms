using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_Condicionales___VENTA_DE_PRODUCTOS
{
    class ClsArticulo
    {
        string articulo;
        string formaPago;
        int cantidadArticulos;
        double costoArticulo;
        double subtotal;
        double descuento;//5% en pago con tarjeta y 10% en pago al contado.
        double total;
        List<ClsArticulo> lista = new List<ClsArticulo>();
        public ClsArticulo(string articulo, string formaPago, int cantidadArticulos)
        {
            this.articulo = articulo;
            this.formaPago = formaPago;
            this.cantidadArticulos = cantidadArticulos;
        }

         void asignarPrecio()
        {
            switch (articulo)
            {
                case "Coleccion Escolar":
                    costoArticulo = 240;
                    break;
                case "Coleccion PreUniversitaria":
                    costoArticulo = 150;
                    break;
                    case "Coleccion Profesional":
                    costoArticulo = 350;
                    break;

            }
        }

         void calcularSubtotal()
        {
            subtotal = cantidadArticulos * costoArticulo;
        }
         void aplicarDescuento()
        {
            switch (formaPago)
            {
                case "Contado":
                    descuento = costoArticulo *0.1;
                    break;
                case "Tarjeta":
                    descuento = costoArticulo * 0.05;
                    break;
            }
        }
        public void calcularTotal()
        {
            asignarPrecio();
            calcularSubtotal();
            aplicarDescuento();
            total = subtotal - descuento;
        }
        public List<ClsArticulo>getLista()
        {
            lista.Add(this);
            return lista;
        }
        //Descriptores de acceso:
        public string Articulo { get => articulo; set => articulo = value; }
        public string FormaPago { get => formaPago; set => formaPago = value; }
        public int CantidadArticulos { get => cantidadArticulos; set => cantidadArticulos = value; }
        public double CostoArticulo { get => costoArticulo; set => costoArticulo = value; }
        public double Subtotal { get => subtotal; set => subtotal = value; }
        public double Descuento { get => descuento; set => descuento = value; }
        public double Total { get => total; set => total = value; }
    }
}
