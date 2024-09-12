using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CapaDatos
{
    //Esta clase envia a la demas clases la cadena de conexion existente del archivo App.config de la CapaPresentacion
    public class Conexion
    {
        //cadena_conexion es nombre que se le dio al connectionString en el archivo App.config
        public static string cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString();
    }
}
