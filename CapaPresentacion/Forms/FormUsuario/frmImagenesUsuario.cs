using CapaEntidad;
using CapaSoporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Forms.FormUsuario
{
    public partial class frmImagenesUsuario : Form
    {
        private static PictureBox pictureBoxAnterior;
        public Usuario _Usuario = new Usuario();

        public frmImagenesUsuario()
        {
            InitializeComponent();
        }

        //Se encarga se cambia el color de todos los picturebox
        //cuando el mouse pasa por arriba o deja de estarlo
        #region
        
        private void ImagenesUsuarios_MouseEnter(object sender, EventArgs e)
        {
            CambiaColorPB_MouseEnter_MouseLeave((PictureBox)sender, Color.FromArgb(240,240,250));
        }

        private void ImagenesUsuarios_MouseLeave(object sender, EventArgs e)
        {
            CambiaColorPB_MouseEnter_MouseLeave((PictureBox)sender, Color.White);
        }
        #endregion

        #region Eventos Click
        private void imgUsuario1_Click(object sender, EventArgs e)
        {
            CambiarColorAlHacerClick(sender);
            _Usuario.IdImagen = 1;
        }

        private void imgUsuario2_Click(object sender, EventArgs e)
        {
            CambiarColorAlHacerClick(sender);
            _Usuario.IdImagen = 2;
        }

        private void imgUsuario3_Click(object sender, EventArgs e)
        {
            CambiarColorAlHacerClick(sender);
            _Usuario.IdImagen = 3;
        }

        private void imgUsuario4_Click(object sender, EventArgs e)
        {
            CambiarColorAlHacerClick(sender);
            _Usuario.IdImagen = 4;
        }

        private void imgUsuario5_Click(object sender, EventArgs e)
        {
            CambiarColorAlHacerClick(sender);
            _Usuario.IdImagen = 5;
        }

        private void imgUsuario6_Click(object sender, EventArgs e)
        {
            CambiarColorAlHacerClick(sender);
            _Usuario.IdImagen = 6;
        }

        private void imgUsuario7_Click(object sender, EventArgs e)
        {
            CambiarColorAlHacerClick(sender);
            _Usuario.IdImagen = 7;
        }

        private void imgUsuario8_Click(object sender, EventArgs e)
        {
            CambiarColorAlHacerClick(sender);
            _Usuario.IdImagen = 8;
        }

        #endregion

        #region Metodos
        public void CambiaColorPB_MouseEnter_MouseLeave(PictureBox pictureBox, Color color)
        {
            if (pictureBox.BackColor != Color.DarkSlateGray)
            {
                pictureBox.BackColor = color;
            }

        }
        private void CambiarColorAlHacerClick(object sender)
        {
            PictureBox pictureBoxClickeado = sender as PictureBox;

            // Si hay un PictureBox anterior, restablece su color
            if (pictureBoxAnterior != null)
            {
                pictureBoxAnterior.BackColor = Color.White;
            }

            // Cambia el color del PictureBox clickeado
            pictureBoxClickeado.BackColor = Color.DarkSlateGray;

            // Actualiza la referencia al PictureBox anterior
            pictureBoxAnterior = pictureBoxClickeado;
        }

        #endregion


        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            MoverForm.MoverFormulario(this.Handle);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Verifica que se haya seleccionado una imagen            
            if (_Usuario.IdImagen != 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una imagen", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
