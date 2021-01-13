using System;
using System.Collections.Generic;

namespace _04_IF_control_emision_de_documentos_ejercicio
{
    class ClsDocumento
    {
        List<ClsDocumento> lista = new List<ClsDocumento>();
        //atributos
        string numeroDoc;
        DateTime fechaEmi;
        string nombreEmpresa;

        int anioActual = DateTime.Now.Year;
        int aniosRegistro;
        string condicion;

        public string NumeroDoc { get => numeroDoc; }
        public DateTime FechaEmi { get => fechaEmi; }
        public string NombreEmpresa { get => nombreEmpresa; }
        public int AniosRegistro { get => aniosRegistro; }
        public string Condicion { get => condicion; }

        public ClsDocumento(string numeroDoc, DateTime fechaEmi, string nombreEmpresa)
        {
            this.numeroDoc = numeroDoc;
            this.fechaEmi = fechaEmi;
            this.nombreEmpresa = nombreEmpresa;
        }

        //Metodo que calcula la cantidad de años que han pasado desde que se emitio el documento:
        int calcularAnioRegistro()
        {
            aniosRegistro = anioActual - FechaEmi.Year;
            return AniosRegistro;
        }

        string asignarCondicion()
        {
            if (AniosRegistro <= 5)
                condicion = "Habilitado.";
            else
                condicion = "Inhabilitado.";
            return Condicion;
        }

        public void agregarDocumento()
        {
            calcularAnioRegistro();
            asignarCondicion();
            lista.Add(this);
        }
        public List<ClsDocumento> getLista()
        {
            return lista;
        }


    }
}
