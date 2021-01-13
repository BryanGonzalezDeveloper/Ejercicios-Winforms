namespace _07_Condicionales___Registro_de_estudiantes
{
    class ClsPostulante
    {
        string nombre;
        byte puntaje;
        string carrera;
        string condicion;
        byte puntajeFaltante;
        byte puntajeRequerido;
        //Puntajes requeridos en cada carrera:
        byte puntajeSistemas = 100;
        byte puntajeSoftware = 120;
        byte puntajeMecanica = 140;
        byte puntajeIndustrial = 160;
        public ClsPostulante(string nombre, byte puntaje, string carrera)
        {
            this.nombre = nombre;
            this.puntaje = puntaje;
            this.carrera = carrera;
        }
        public void setInformacion()
        {
            switch (carrera)
            {
                case "Ing. sistemas":
                    if (puntaje >= puntajeSistemas)
                    {
                        condicion = "ACEPTADO";
                        puntajeFaltante = 0;
                    }
                    else
                    {
                        condicion = "RECHAZADO";
                        puntajeFaltante = (byte)(puntajeSistemas - puntaje);
                    }
                    puntajeRequerido = puntajeSistemas;
                    break;
                case "Ing. software":
                    if (puntaje >= puntajeSoftware)
                    {
                        condicion = "ACEPTADO";
                        puntajeFaltante = 0;
                    }
                    else
                    {
                        condicion = "RECHAZADO";
                        puntajeFaltante = (byte)(puntajeSoftware - puntaje);
                    }
                    puntajeRequerido = puntajeSoftware;

                    break;
                case "Ing. mecanica":
                    if (puntaje >= puntajeMecanica)
                    {
                        condicion = "ACEPTADO";
                        puntajeFaltante = 0;
                    }
                    else
                    {
                        condicion = "RECHAZADO";
                        puntajeFaltante = (byte)(puntajeMecanica - puntaje);
                    }
                    puntajeRequerido = puntajeMecanica;

                    break;
                case "Ing. industrial":
                    if (puntaje >= puntajeIndustrial)
                    {
                        condicion = "ACEPTADO";
                        puntajeFaltante = 0;
                    }
                    else
                    {
                        condicion = "RECHAZADO";
                        puntajeFaltante = (byte)(puntajeIndustrial - puntaje);
                    }
                    puntajeRequerido = puntajeIndustrial;

                    break;
            }
        }

        public override string ToString()
        {
            return string.Format("Nombre del postulante: {0}\nCarrera seleccionada: {1}\nPuntaje obtenido: {2}\nPuntaje requerido: {3}\n" +
                "Puntaje faltante: {4}\nCondicion: {5}", nombre, carrera, puntaje, puntajeRequerido, puntajeFaltante, condicion);
        }
    }
}
