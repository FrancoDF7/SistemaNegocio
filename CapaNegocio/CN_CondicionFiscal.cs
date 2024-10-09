using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_CondicionFiscal
    {
        CD_CondicionFiscal objcd_condicionfiscal = new CD_CondicionFiscal();

        public List<CondicionFiscal> Listar()
        {
            return objcd_condicionfiscal.Listar();
        }

    }
}
