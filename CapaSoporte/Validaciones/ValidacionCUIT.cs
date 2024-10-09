using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSoporte.Validaciones
{
    public static class ValidacionCUIT
    {
        public static bool Validar(string cuit)
        {
            //Almacena el digito verificador
            int verificador = int.Parse(cuit[cuit.Length - 1].ToString());

            int[] coeficientes = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };

            int resultado = 0;

            for (int i = 0; i < 10; i++)
            {
                int digito = int.Parse(cuit.Substring(i, 1));

                 resultado += digito * coeficientes[i];                
            }

            resultado = 11 - (resultado % 11);

            //Reglas especiales del CUIT cuando el digito verificador da 11 o 10 
            //se ajusta su valor a 0 o 9 ya que el digito verificador no puede poseer mas de un digito
            if (resultado == 11) resultado = 0;
            if (resultado == 10) resultado = 9;

            if (resultado == verificador)
            {
                return true;
            }
            else
            {
                return false;
            }

        }



    }
}
