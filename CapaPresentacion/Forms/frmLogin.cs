using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaSoporte;

namespace CapaPresentacion.Forms
{
    public partial class frmLogin : Form
    {
        

        public frmLogin()
        {
            InitializeComponent();
        }


        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            MoverForm moverForm = new MoverForm();
            moverForm.MoverFormulario(this.Handle);
        }
    }
}
