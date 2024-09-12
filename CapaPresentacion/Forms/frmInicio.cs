using CapaPresentacion.Forms.FormNegocio;
using CapaPresentacion.Forms.FormUsuario;
using CapaSoporte;
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
        //private static Usuario usuarioActual;
        private static IconButton BotonSeccion = null;
        private static Form FormularioActivo = null;
        MoverForm moverForm = new MoverForm();

        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            InicializarSubmenus();
        }


        #region Eventos mover formulario
        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {            
            moverForm.MoverFormulario(this.Handle);
        }
        private void lblnombrenegocio_MouseDown(object sender, MouseEventArgs e)
        {
            moverForm.MoverFormulario(this.Handle);
        }
        private void piclogonegocio_MouseDown(object sender, MouseEventArgs e)
        {
            moverForm.MoverFormulario(this.Handle);
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
        private void btnUsuariosCrear_Click(object sender, EventArgs e)
        {
            frmCrearUsuario frmCrearUsuario = new frmCrearUsuario();
            frmCrearUsuario.ShowDialog();
        }
        private void btnUsuariosPerfil_Click(object sender, EventArgs e)
        {
            frmEditarPerfil frmEditarPerfil = new frmEditarPerfil();
            frmEditarPerfil.ShowDialog();
        }
        #endregion

        #region Eventos botones Contabilidad
        private void btnContabilidad_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelContabilidadSubmenu);
            AbrirFormulario(btnContabilidad, new frmEditarPerfil());
        }
        #endregion

        #region Eventos botones Negocio
        private void btnNegocio_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelNegocioSubmenu);
            AbrirFormulario(btnNegocio, new frmNegocio());
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


        private void AbrirFormulario(IconButton boton, Form formulario)
        {
            if (BotonSeccion != null)
            {
                BotonSeccion.BackColor = Color.White;
            }

            boton.BackColor = Color.FromArgb(0, 192, 192);
            BotonSeccion = boton;

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

        }

        #endregion

    }
}
