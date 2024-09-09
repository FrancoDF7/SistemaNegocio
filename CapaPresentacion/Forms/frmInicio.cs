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

namespace CapaPresentacion.Forms
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            InicializarSubmenus();
        }

        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            MoverForm moverForm = new MoverForm();
            moverForm.MoverFormulario(this.Handle);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelProductosSubmenu);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelClientesSubmenu);
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelProveedoresSubmenu);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelVentasSubmenu);
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelComprasSubmenu);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
           MostrarSubmenu(panelUsuariosSubmenu);
        }

        private void btnContabilidad_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelContabilidadSubmenu);
        }


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
        }
        #endregion

        #endregion

    }
}
