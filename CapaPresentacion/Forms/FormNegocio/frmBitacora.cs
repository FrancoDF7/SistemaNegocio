using CapaEntidad;
using CapaNegocio;
using CapaSoporte.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Forms.FormNegocio
{
    public partial class frmBitacora : Form
    {
        public frmBitacora()
        {
            InitializeComponent();
        }

        private void frmBitacora_Load(object sender, EventArgs e)
        {
            Carga_dgvData();

            //Carga_cboBusqueda();


        }



        #region Metodos

        //Carga el dgvdata desde la base de datos mediante el metodo listar de clase CN_Bitacora
        public void Carga_dgvData()
        {           
            List<Bitacora> listaBitacora = new CN_Bitacora().Listar();

            foreach (Bitacora item in listaBitacora)
            {
                dgvdata.Rows.Add(new object[] {"", item.IdEvento, item.FechaHora, item.UsuarioLogeado, item.Accion, item.Tabla, item.RegistroAnterior, item.RegistroNuevo
                });
            }
        }

        //public void Carga_cboBusqueda()
        //{
        //    //Carga el combobox cbobusqueda con los valores de los titulos de las columnas del dgvdata
        //    foreach (DataGridViewColumn columna in dgvdata.Columns)
        //    {
        //        if (columna.Visible == true && columna.Name != "btnseleccionar" && columna.Name != "FechaHora" && columna.Name != "RegistroAnterior" && columna.Name != "RegistroNuevo")
        //        {
        //            cboBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
        //        }
        //    }

        //    cboBusqueda.DisplayMember = "Texto";
        //    cboBusqueda.ValueMember = "Valor";
        //    cboBusqueda.SelectedIndex = 0;
        //}

        #endregion

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name =="btnseleccionar")
            {
                int indice = e.RowIndex;

                string nombreUsuario = dgvdata.Rows[indice].Cells["NombreUsuario"].Value.ToString();

                Usuario usuario = new CN_Usuario().Listar().Where(u => u.NombreUsuario == nombreUsuario).FirstOrDefault();

                if (indice >= 0)
                {
                    lblDocumento.Text = usuario.Documento;
                    lblNombreUsuario.Text =  usuario.NombreUsuario;
                    lblNombre.Text =usuario.Nombre;
                    lblApellido.Text = usuario.Apellido;
                    lblCorreo.Text = usuario.Correo;
                    lblRol.Text = usuario.oRol.Descripcion;

                    if (usuario.Estado)
                    {
                        lblEstado.Text = "Activo";
                    }
                    else
                    {
                        lblEstado.Text = "No Activo";
                    }

                    iconoUsuario.ImageLocation = RutaImagenes.DevuelveRutaDeImagenes(usuario.IdImagen.ToString());

                    lblFechaRegistro.Text = usuario.FechaRegistro;



                    txtFechaHora.Text = dgvdata.Rows[indice].Cells["FechaHora"].Value.ToString();
                    txtAccion.Text = dgvdata.Rows[indice].Cells["Accion"].Value.ToString();
                    txtTabla.Text = dgvdata.Rows[indice].Cells["Tabla"].Value.ToString();
                    txtRegistroAnterior.Text = dgvdata.Rows[indice].Cells["RegistroAnterior"].Value.ToString();
                    txtRegistroNuevo.Text = dgvdata.Rows[indice].Cells["RegistroNuevo"].Value.ToString();

                }

            }


        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.user_check_16x18.Width; //Asigna a la variable w el ancho de la imagen check20
                var h = Properties.Resources.user_check_16x18.Height; //Asigna a la variable h el alto de la imagen check20
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2; //Centra imagen horizontalmente
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2; //Centra imagen verticalmente


                e.Graphics.DrawImage(Properties.Resources.user_check_16x18, new Rectangle(x, y, w, h)); //Se dibuja la imagen en utilizando las dimensiones y coordenadas de las variables.
                e.Handled = true; //Esto indica que se ha manejado completamente el evento de pintura de la celda y evita que el sistema realice más procesamiento de pintura estándar
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            List<Bitacora> lista = new List<Bitacora>();

            lista = new CN_Bitacora().AccionesBitacora(dtpFechaInicio.Value.ToString(), dtpFechaFin.Value.ToString());

            dgvdata.Rows.Clear();

            foreach (Bitacora bi in lista)
            {
                dgvdata.Rows.Add(new object[]
                {
                    "", //Boton del dgvData
                    bi.IdEvento,
                    bi.FechaHora,
                    bi.UsuarioLogeado,
                    bi.Accion,
                    bi.Tabla,
                    bi.RegistroAnterior,
                    bi.RegistroNuevo
                });

            }






            //DateTime fechaInicio = dtpFechaInicio.Value;
            //DateTime fechaFin = dtpFechaFin.Value;

            //DataTable dt = (DataTable)dgvdata.DataSource;
            //DataView dv = new DataView(dt);

            //dv.RowFilter = $"[Fecha y Hora] >= #{fechaInicio}# AND [Fecha y Hora] <= #{fechaFin}#";

            //dgvdata.DataSource = dv;

            //dgvdata.Refresh();







            //DateTime fechaInicio = (dtpFechaInicio, "dd")
            //DateTime fechaFin = dtpFechaFin.Value;

            //DataTable dt = (DataTable)dgvdata.DataSource;
            //DataView dv = new DataView(dt);

            //dv.RowFilter = $"[Fecha y Hora] >= #{fechaInicio}# AND [Fecha y Hora] <= #{fechaFin}#";

            //dgvdata.DataSource = dv;

            //dgvdata.Refresh();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblDocumento.Text = "Vacio";
            lblNombreUsuario.Text = "Vacio";
            lblNombre.Text = "Vacio";
            lblApellido.Text = "Vacio";
            lblCorreo.Text = "Vacio";
            lblRol.Text = "Vacio";
            lblEstado.Text = "Vacio";
            lblFechaRegistro.Text = "Vacio";

            iconoUsuario.ImageLocation = RutaImagenes.DevuelveRutaDeImagenes("1");

            txtFechaHora.Text = "";
            txtAccion.Text = "";
            txtTabla.Text = "";
            txtRegistroAnterior.Text = "";
            txtRegistroNuevo.Text = "";
        }
    }
}
