using System;
using System.IO;
namespace _14_Lectura_de_directorios_y_archivos_System.IO
{
    class ClsArchivo
    {
        static string informacion;
        public static string getInformacion(string path)
        {
            informacion = "El archivo o directorio: " + path + " existe.\n\n";
            informacion += "Creacion: " + File.GetCreationTime(path).ToLongDateString() + "\n\n";
            informacion += "Ultima modificacion: " + File.GetLastWriteTime(path) + "\n\n";
            informacion += "Ultimo acceso: " + File.GetLastAccessTime(path) + "\n\n";
            return informacion;
        }

        public static string getContenidoArchivo(string path)
        {
            try
            {
                using (StreamReader archivo = new StreamReader(path))
                {
                    informacion = archivo.ReadToEnd();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return informacion;
        }

        public static string[] getContenidoDirectorio(string path)
        {
            return Directory.GetDirectories(path);
        }
    }
}
