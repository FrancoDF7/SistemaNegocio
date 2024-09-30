using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Bitacora
    {
        CD_Bitacora objcd_bitacora = new CD_Bitacora();

        public List<Bitacora> Listar()
        {
            return objcd_bitacora.Listar();
        }


        public List<Bitacora> AccionesBitacora(string fechainicio, string fechafin)
        {
            return objcd_bitacora.AccionesBitacora(fechainicio, fechafin);
        }

    }
}
