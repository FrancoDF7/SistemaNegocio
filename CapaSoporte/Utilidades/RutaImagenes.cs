using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaSoporte.Utilidades
{
    public static class RutaImagenes
    {
        public static string DevuelveRutaDeImagenes(string idImagen)
        {
            //Ya Application.StartupPath devuelve
            //la ubicacion del proyecto junto en la carpeta Debug en especifico
            //reemplaze la parte \bin\Debug por la ubicacion del proyecto
            //para poder hacerlo portable si es que cambia la ubicacion del proyecto
            string directorioProyecto = Application.StartupPath;

            string rutaImagen = Path.Combine((directorioProyecto).Replace("\\bin\\Debug", "\\Img\\ImgUsuarios\\img_usuario") + idImagen + ".png");

            return rutaImagen;

        }

    }
}
