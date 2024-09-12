using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaSoporte.Validaciones
{
    public class ValidacionKeyPress
    {
        //Permite solamente (numeros enteros y borrar)
        public void SoloNumerosEnteros(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) {
                e.Handled = false;
            }
            else {
                e.Handled = true;
            }
        }

        //Permite solamente (letras, borrar, espacio)
        public void SoloLetras(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar)) {
                e.Handled = false;
            }
            else {
                e.Handled = true;
            }
        }

        //Permite solamente (letras, numeros, borrar, espacio)
        public void SoloLetrasYNumeros(KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar)) {
                e.Handled = false;
            }
            else {
                e.Handled = true;
            }
        }



    }
}
