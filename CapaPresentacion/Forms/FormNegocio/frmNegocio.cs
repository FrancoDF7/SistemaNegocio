using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaSoporte.Validaciones;
using System.Windows.Media.TextFormatting;

namespace CapaPresentacion.Forms.FormNegocio
{
    public partial class frmNegocio : Form
    {
        public frmNegocio()
        {
            InitializeComponent();
        }

        //Convierte array de byte a una imagen
        public Image ByteToImage(byte[] imageBytes)
        {
            //Permite guardar imagenes en memoria
            MemoryStream ms = new MemoryStream();
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);

            return image;
        }

        private void frmNegocio_Load(object sender, EventArgs e)
        {
            bool obtenido = true;
            byte[] byteimage = new CN_Negocio().ObtenerLogo(out obtenido);

            if (obtenido)
                picLogo1.Image = ByteToImage(byteimage);


            Negocio datos = new CN_Negocio().ObtenerDatos();
            txtnombrenegocio.Text = datos.Nombre;
            txtcuit1.Text = datos.CuitParte1;
            txtcuit2.Text = datos.CuitParte2;
            txtcuit3.Text = datos.CuitParte3;
            txtprovincia.Text = datos.Provincia;
            txtpartido.Text = datos.Partido;
            txtlocalidad.Text = datos.Localidad;
            txtcalle.Text = datos.Calle;
            txttelefono.Text = datos.Telefono;
            dtpFechaActividades.Text = datos.FechaInicioActividades;

        }

        private void btnguardarcambios_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Negocio obj = new Negocio()
            {
                Nombre = txtnombrenegocio.Text,
                CUIT = txtcuit1.Text  + txtcuit2.Text + txtcuit3.Text,
                Calle = txtcalle.Text,
                Localidad = txtlocalidad.Text,
                Partido = txtpartido.Text,
                Provincia = txtprovincia.Text,
                Telefono = txttelefono.Text,
                FechaInicioActividades = dtpFechaActividades.Text
            };

            bool respuesta = new CN_Negocio().GuardarDatos(obj, out mensaje);

            if (respuesta)
                MessageBox.Show("Los cambios fueron guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar los cambios:\n\n" + mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnsubir_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            OpenFileDialog oOpenFileDialog = new OpenFileDialog();

            oOpenFileDialog.Filter = "Files|*.jpg;*.jpeg;*.png";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] byteImage = File.ReadAllBytes(oOpenFileDialog.FileName);
                bool respuesta = new CN_Negocio().ActualizarLogo(byteImage, out mensaje);

                if (respuesta)
                    picLogo1.Image = ByteToImage(byteImage);
                else
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


        }




        #region Validaciones Evento KeyPress
        private void txtcuit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionKeyPress.SoloNumerosEnteros(e);
        }
        private void txtcuit2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionKeyPress.SoloNumerosEnteros(e);
        }
        private void txtcuit3_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionKeyPress.SoloNumerosEnteros(e);
        }
        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionKeyPress.SoloNumerosEnteros(e);
        }
        private void txtprovincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionKeyPress.SoloLetrasYNumeros(e);
        }
        private void txtpartido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionKeyPress.SoloLetrasYNumeros(e);
        }
        private void txtlocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionKeyPress.SoloLetrasYNumeros(e);
        }
        private void txtcalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionKeyPress.SoloLetrasYNumeros(e);
        }
        #endregion



    }
}
