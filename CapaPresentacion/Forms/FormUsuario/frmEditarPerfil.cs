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
using CapaEntidad;
using CapaNegocio;
using CapaSoporte.Utilidades;
using FontAwesome.Sharp;

namespace CapaPresentacion.Forms.FormUsuario
{
    public partial class frmEditarPerfil : Form
    {

        public Usuario _Usuario = new Usuario();

        public frmEditarPerfil()
        {
            InitializeComponent();
        }

        private void frmEditarPerfil_Load(object sender, EventArgs e)
        {
            //Oculta caracteres de los campos de la contraseña
            txtClave.UseSystemPasswordChar = true;
            txtConfirmarClave.UseSystemPasswordChar = true;

            //Carga en los campos los datos del usuario logeado
            txtId.Text = Usuario.UsuarioLogeado.IdUsuario.ToString();            
            txtDocumento.Text = Usuario.UsuarioLogeado.Documento;
            txtNombreUsuario.Text = Usuario.UsuarioLogeado.NombreUsuario;
            txtCorreo.Text = Usuario.UsuarioLogeado.Correo;
            txtNombre.Text = Usuario.UsuarioLogeado.Nombre;
            txtApellido.Text = Usuario.UsuarioLogeado.Apellido;
            txtClave.Text = Usuario.UsuarioLogeado.Clave;
            txtConfirmarClave.Text = Usuario.UsuarioLogeado.Clave;
            txtIdImagen.Text = Usuario.UsuarioLogeado.IdImagen.ToString();

            Carga_cboRol();
            Carga_cboEstado();

            //Muestra en el combobox cborol el rol que le corresponda al usuario que se selecciono
            foreach (OpcionCombo oc in cboRol.Items)
            {
                //Valida que valor del combo sea el mismo que el de rol del usuario
                if (Convert.ToInt32(oc.Valor) == Usuario.UsuarioLogeado.oRol.IdRol)
                {
                    int indice_combo = cboRol.Items.IndexOf(oc);
                    cboRol.SelectedIndex = indice_combo;
                    break;
                }
            }

            //Muestra en el combobox cboestado el estado que le corresponda al usuario que se selecciono
            foreach (OpcionCombo oc in cboEstado.Items)
            {
                //Valida que valor del combo sea el mismo que el de estado del usuario
                if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(Usuario.UsuarioLogeado.Estado))
                {
                    int indice_combo = cboEstado.Items.IndexOf(oc);
                    cboEstado.SelectedIndex = indice_combo;
                    break;
                }
            }

            iconoUsuario.ImageLocation = RutaImagenes.DevuelveRutaDeImagenes(Usuario.UsuarioLogeado.IdImagen.ToString());

            txtClave.Select();
        }


        //Cambia la icono del usuario en el formulario si selecciona una nueva
        private void btnCambiarImagen_Click(object sender, EventArgs e)
        {
            using (var frm = new frmImagenesUsuario())
            {
                var result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtIdImagen.Text = frm._Usuario.IdImagen.ToString();
                }
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Usuario obj = new Usuario()
            {
                IdUsuario = Convert.ToInt32(txtId.Text),
                Documento = txtDocumento.Text,
                NombreUsuario = txtNombreUsuario.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                Clave = txtClave.Text,
                ConfirmarClave = txtConfirmarClave.Text,
                oRol = new Rol() { IdRol = Convert.ToInt32(((OpcionCombo)cboRol.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombo)cboEstado.SelectedItem).Valor) == 1 ? true : false,
                IdImagen = Convert.ToByte(txtIdImagen.Text)
            };

            if (MessageBox.Show("¿Desea guardar los cambios?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                bool resultado = new CN_Usuario().Editar(obj, out mensaje);

                if (resultado)
                {
                    //Actualiza los datos del usuario logeado actualmente
                    Usuario.UsuarioLogeado.IdImagen = Convert.ToByte(txtIdImagen.Text);
                    Usuario.UsuarioLogeado.Clave = txtClave.Text;
                    Usuario.UsuarioLogeado.Correo = txtCorreo.Text;
                    
                    //Variable que se utiliza para cambiar el icono del usuario en frmInicio
                    _Usuario.IdImagen = Usuario.UsuarioLogeado.IdImagen;

                    MessageBox.Show("Cambios guardados exitosamente", "Infomación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;

                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void txtIdImagen_TextChanged(object sender, EventArgs e)
        {
            iconoUsuario.ImageLocation = RutaImagenes.DevuelveRutaDeImagenes(txtIdImagen.Text);
        }

        //Boton para ver/ocultar los caracteres del campo txtClave
        private void btnVerOcultarClave1_Click(object sender, EventArgs e)
        {
            VisualizacionContrasena(btnVerOcultarClave1, txtClave);
        }

        //Boton para ver/ocultar los caracteres del campo txtConfirmarClave
        private void btnVerOcultarClave2_Click(object sender, EventArgs e)
        {
            VisualizacionContrasena(btnVerOcultarClave2, txtConfirmarClave);
        }

        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            MoverForm.MoverFormulario(this.Handle);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region Metodos 

        public void Carga_cboEstado()
        {
            //Carga combobox cboEstado
            cboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cboEstado.DisplayMember = "Texto"; //El texto que muestra el combobox
            cboEstado.ValueMember = "Valor";
            cboEstado.SelectedIndex = 0;
        }
        public void Carga_cboRol()
        {
            //Carga combobox cborol desde la base de datos
            List<Rol> listaRol = new CN_Rol().Listar();

            foreach (Rol item in listaRol)
            {
                cboRol.Items.Add(new OpcionCombo() { Valor = item.IdRol, Texto = item.Descripcion });
            }
            cboRol.DisplayMember = "Texto";
            cboRol.ValueMember = "Valor";
            cboRol.SelectedIndex = 0;
        }
        public void VisualizacionContrasena(IconButton iconButton, TextBox textBox)
        {
            if (iconButton.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                iconButton.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                iconButton.IconSize = 32;
                textBox.UseSystemPasswordChar = false;
            }
            else
            {
                iconButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
                textBox.UseSystemPasswordChar = true;
                iconButton.IconSize = 30;
            }
            //Comentario: //Les agregue un IconSize diferente porque el tamaño de los iconos no se ven del mismo tamaño cuando cambian
        }

        #endregion

    }
}
