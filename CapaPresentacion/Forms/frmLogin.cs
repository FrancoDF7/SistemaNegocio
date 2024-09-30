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
using CapaEntidad;
using CapaNegocio;
using CapaSoporte;

namespace CapaPresentacion.Forms
{
    public partial class frmLogin : Form
    {        

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtusuario.Select();

            txtclave.UseSystemPasswordChar = true;
        }

        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            MoverForm.MoverFormulario(this.Handle);
        }

        private void btniniciarsesion_Click(object sender, EventArgs e)
        {
            //El metodo Listar devuelve una lista de usuarios.
            //Where filtra un usuario de la lista que coincida con el numero de documento y su clave, de lo contrario devuelve null.
            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.NombreUsuario == txtusuario.Text && u.Clave == txtclave.Text).FirstOrDefault();

            if (ousuario != null)
            {
                 //Le envia al constructor del formulario Inicio los datos del usuario que encontro
                frmInicio form = new frmInicio(ousuario);

                form.Show();
                this.Hide();

                //Llama al metodo frm_closing para que cuando el formulario Inicio se cierre.
                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("No se encontro el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Muestra nuevamente el formulario Login y resetea los campos de documento y contraseña.
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtusuario.Text = "";
            txtclave.Text = "";

            //Muestra el formulario
            this.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
