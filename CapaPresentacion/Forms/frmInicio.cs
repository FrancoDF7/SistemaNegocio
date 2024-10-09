using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Forms.FormNegocio;
using CapaPresentacion.Forms.FormUsuario;
using CapaPresentacion.Forms.FormCliente;
using CapaSoporte;
using CapaSoporte.Utilidades;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaPresentacion.Forms
{
    public partial class frmInicio : Form
    {
        private static IconButton BotonSeccion = null;
        private static Button BotonPanelSubmenu = null;
        private static Form FormularioActivo = null;

        public frmInicio(Usuario objusuario = null)
        {
            //Genera un usuario predefinido para no tener acceder a la base de datos para probar el programa
            if (objusuario == null)
            {
                Usuario.UsuarioLogeado = new Usuario() { NombreUsuario = "ADMIN PREDEFINIDO", IdUsuario = 1 };
            }
            else
            {
                //Guarda la informacion del usuario que se logeo en la variable de tipo usuario
                Usuario.UsuarioLogeado = objusuario;                
            }

            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            CN_Usuario cn_Usuario = new CN_Usuario();
            cn_Usuario.RegistraLogin(Usuario.UsuarioLogeado.NombreUsuario); //Registra login en la bitacora

            //FALTA ESPEFICAR QUE BOTONES SE DEJARA SELECCIONAR DENTRO DEL SUBMENU AL EMPLEADO
            CargaPermisos();

            #region Muestra datos del usuario logeado
            txtIdImagen.Text = Usuario.UsuarioLogeado.IdImagen.ToString();
            lblUsuario.Text = Usuario.UsuarioLogeado.NombreUsuario;
            lblRol.Text = Usuario.UsuarioLogeado.oRol.Descripcion;
            #endregion
            InicializarSubmenus();
        }

        #region Eventos mover formulario
        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {            
            MoverForm.MoverFormulario(this.Handle);
        }
        private void lblnombrenegocio_MouseDown(object sender, MouseEventArgs e)
        {
            MoverForm.MoverFormulario(this.Handle);
        }
        private void piclogonegocio_MouseDown(object sender, MouseEventArgs e)
        {
            MoverForm.MoverFormulario(this.Handle);
        }
        #endregion



        #region Eventos botones Productos
        private void btnProductos_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelProductosSubmenu);
        }
        #endregion

        #region Eventos botones Clientes
        private void btnClientes_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelClientesSubmenu);
        }

        private void btnGestionClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(null, btnGestionClientes, new frmGestionClientes());
        }

        #endregion

        #region Eventos botones Proveedores
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelProveedoresSubmenu);
        }
        #endregion

        #region Eventos botones Ventas
        private void btnVentas_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelVentasSubmenu);
        }
        #endregion

        #region Eventos botones Compras
        private void btnCompras_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelComprasSubmenu);
        }
        #endregion

        #region Eventos botones Usuarios
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
           MostrarSubmenu(panelUsuariosSubmenu);
        }
        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(null, btnGestionUsuarios, new frmGestionUsuarios());
        }
        private void btnUsuariosPerfil_Click(object sender, EventArgs e)
        {
            
        }

        //Cambia el icono del usuario en el frmInicio si que se cambio al editar el usuario
        private void btnEditarMiUsuario_Click(object sender, EventArgs e)
        {            
            using (var frm = new frmEditarPerfil())
            {
                var result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtIdImagen.Text = frm._Usuario.IdImagen.ToString();
                }
            }

        }

        #endregion

        #region Eventos botones Contabilidad
        private void btnContabilidad_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region Eventos botones Negocio
        private void btnNegocio_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelNegocioSubmenu);
        }

        private void btnDetallesNegocio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(null,btnDetallesNegocio, new frmNegocio());
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            AbrirFormulario(null, btnBitacora, new frmBitacora());
        }

        #endregion


        #region Metodos

        #region Metodos de Submenus
        //Ocultar todos los submenus al iniciar la aplicacion
        private void InicializarSubmenus()
        {
            panelProductosSubmenu.Visible = false;
            panelClientesSubmenu.Visible = false;
            panelProveedoresSubmenu.Visible = false;
            panelComprasSubmenu.Visible = false;
            panelVentasSubmenu.Visible = false;
            panelUsuariosSubmenu.Visible = false;
            panelContabilidadSubmenu.Visible = false;
            panelNegocioSubmenu.Visible = false;
        }
        
        //Si el submenu no esta visible lo muestra y oculta el que este visible,
        //si esta visible el submenu seleccionado lo oculta
        private void MostrarSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }        
        //Metodo con condicionales que ocultan el submenu que este visible
        private void OcultarSubmenu()
        {
            if (panelProductosSubmenu.Visible == true)
            {
                panelProductosSubmenu.Visible = false;
            }
            if (panelClientesSubmenu.Visible == true)
            {
                panelClientesSubmenu.Visible = false;
            }
            if (panelProveedoresSubmenu.Visible == true)
            {
                panelProveedoresSubmenu.Visible = false;
            }
            if (panelComprasSubmenu.Visible == true)
            {
                panelComprasSubmenu.Visible = false;
            }
            if (panelVentasSubmenu.Visible == true)
            {
                panelVentasSubmenu.Visible = false;
            }
            if (panelUsuariosSubmenu.Visible == true)
            {
                panelUsuariosSubmenu.Visible = false;
            }
            if(panelContabilidadSubmenu.Visible == true)
            {
                panelContabilidadSubmenu.Visible = false;
            }
            if (panelNegocioSubmenu.Visible == true)
            {
                panelNegocioSubmenu.Visible = false;
            }
        }


        #endregion

        #region Metodo para mostrar formularios dentro del frmInicio

        //Cuando se llama al metodo se le pasa null al parametro que no corresponda
        //con el tipo de boton se le hace click.
        private void AbrirFormulario(IconButton iconboton, Button boton  ,Form formulario)
        {
            //Si ya se seleccion un boton anteriormente vuelve blanco todos los controles
            if (BotonSeccion != null || boton != null)
            {
                EstablecerBackColorBlanco(panelOpciones);
            }            

            //Verifica el que boton presionado sea de tipo iconbutton
            if (iconboton != null)
            {
                BotonSeccion = iconboton;
                iconboton.BackColor = Color.FromArgb(0, 192, 192);
            }

            //Verifica el que boton presionado sea de tipo button
            if (boton != null)
            {
                BotonPanelSubmenu = boton;
                boton.BackColor = Color.FromArgb(0, 192, 192);
            }
            

            if (FormularioActivo != null)
            {
                //Si es que actualmente hay un formulario activo lo cierra
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.White;
           

            panelCentral.Controls.Add(formulario);
            formulario.Show();

            //Centra el horizontalmente y lo coloca en la parte superior
            formulario.Left = (panelCentral.Width - formulario.Width) / 2;
            formulario.Top = 0;
        }
        #endregion

        //Vuelve de color blanco todo los controles
        //que esten dentro del control que se pase por parametros
        private void EstablecerBackColorBlanco(Control control)
        {
            control.BackColor = Color.White;

            // Recorrer todos los controles hijos
            foreach (Control childControl in control.Controls)
            {
                EstablecerBackColorBlanco(childControl);
            }
        }
        public void CargaPermisos()
        {
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(Usuario.UsuarioLogeado.IdUsuario);

            //Si la cantidad de registros devueltos es mayor a 2 es un usuario
            //con rol de Administrador de lo contrario es un empleado
            if (ListaPermisos.Count > 2)
            {
                btnProductos.Visible = true;
                btnClientes.Visible = true;
                btnProveedores.Visible = true;
                btnVentas.Visible = true;
                btnCompras.Visible = true;
                btnUsuarios.Visible = true;
                btnContabilidad.Visible = true;
                btnNegocio.Visible = true;
            }
            else
            {
                btnClientes.Visible = true;
                btnVentas.Visible = true;
            }
        }

        #endregion

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Actualiza el icono de usuario segun el su IdImagen.
        //Nota: Se dispara el evento cuando carga el frmInicio y cuando se cierra el frmEditarPerfil
        private void txtIdImagen_TextChanged(object sender, EventArgs e)
        {
            iconoUsuario.ImageLocation = RutaImagenes.DevuelveRutaDeImagenes(txtIdImagen.Text);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


    }
}
