using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.MessageBoxs
{
    public partial class msInformativo : Form
    {
        public msInformativo()
        {
            InitializeComponent();

            //lblMensaje.MaximumSize = new Size(550, 0); //Ancho y alto maximo
            //lblMensaje.AutoSize = true;

            //SetFormSize();
        }

        private void msInformativo_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = "jflkadsñjlakfdsaldjfkñsadflñjksldfjkñasldfakjñsdflakñjsdalfksñjdflaskjñ84029240839204389240389234089234089234089234098dfkjasdflaskjfdaskjñ";
        }


        private void SetFormSize()
        {
            int width = lblMensaje.Width + 140; // Ajusta según sea necesario
            int height = lblMensaje.Height + 140; // Ajusta según sea necesario
            panelCentral.Size = new Size(width, height);
        }


    }
}
