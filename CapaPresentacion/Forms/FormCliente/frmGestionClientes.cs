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
using CapaSoporte;
using CapaSoporte.Utilidades;
using CapaSoporte.Validaciones;
using ClosedXML.Excel;

namespace CapaPresentacion.Forms.FormCliente
{
    public partial class frmGestionClientes : Form
    {

        // CONSTRUCTOR *********************************************************************//
        public frmGestionClientes()
        {
            InitializeComponent();
        }

        #region Eventos

        // EVENTO LOAD DEL FORMULARIO *******************************************************//
        private void frmGestionClientes_Load(object sender, EventArgs e)
        {
            Carga_cboCondicionFiscal();
            Carga_dgvData();
            Carga_cboBusqueda();
        }

        // EVENTOS DE BOTONES **************************************************************//
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Cliente obj = new Cliente()
            {
                IdCliente = Convert.ToInt32(txtId.Text),
                Documento = txtDocumento.Text,
                CUIT = txtCuit1.Text + txtCuit2.Text + txtCuit3.Text,
                NombreCompleto = txtNombreCompleto.Text.Trim(),                
                Provincia = txtProvincia.Text.Trim(), 
                Partido = txtPartido.Text.Trim(),
                Localidad = txtLocalidad.Text.Trim(), 
                Calle = txtCalle.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                oCondicionFiscal = new CondicionFiscal() { IdCondicionFiscal = Convert.ToInt32(((OpcionCombo)cboCondicionFiscal.SelectedItem).Valor) }
            };

            //Si el IdCliente es igual a 0 significa que se esta creando un nuevo cliente,
            //de lo contrario significa que se esta editando un cliente existente.
            if (obj.IdCliente == 0)
            {
                if (MessageBox.Show("¿Desea registrar un nuevo cliente?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idgenerado = new CN_Cliente().Registrar(obj, out mensaje);

                    if (idgenerado != 0)
                    {
                        dgvData.Rows.Add(new object[]
                        {
                            "",
                            idgenerado,
                            txtDocumento.Text,
                            txtCuit1.Text + txtCuit2.Text + txtCuit3.Text,
                            txtNombreCompleto.Text,
                            txtProvincia.Text.Trim() + " - " + txtPartido.Text.Trim() + " - " + txtLocalidad.Text.Trim() + " - " + txtCalle.Text.Trim(), //Direccion
                            txtTelefono.Text,
                            txtCorreo.Text,
                            ((OpcionCombo)cboCondicionFiscal.SelectedItem).Valor.ToString(),
                            ((OpcionCombo)cboCondicionFiscal.SelectedItem).Texto.ToString()
                        });

                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (MessageBox.Show("¿Desea editar el cliente " + txtNombreCompleto.Text + " ?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //EDITAR CLIENTE
                    bool resultado = new CN_Cliente().Editar(obj, out mensaje);

                    //Actualiza en el dgvdata la fila que corresponda con los nuevos valores del cliente que se edito
                    if (resultado)
                    {
                        DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txtIndice.Text)];

                        row.Cells["IdCliente"].Value = txtId.Text;
                        row.Cells["Documento"].Value = txtDocumento.Text;
                        row.Cells["CUIT"].Value = txtCuit1.Text + txtCuit2.Text + txtCuit3.Text;
                        row.Cells["NombreCompleto"].Value = txtNombreCompleto.Text;
                        row.Cells["Direccion"].Value = txtProvincia.Text.Trim() + " - " + txtPartido.Text.Trim() + " - " + txtLocalidad.Text.Trim() + " - " + txtCalle.Text.Trim();
                        row.Cells["Telefono"].Value = txtTelefono.Text;
                        row.Cells["Correo"].Value = txtCorreo.Text;
                        row.Cells["IdCondicionFiscal"].Value = ((OpcionCombo)cboCondicionFiscal.SelectedItem).Valor.ToString();
                        row.Cells["CondicionFiscal"].Value = ((OpcionCombo)cboCondicionFiscal.SelectedItem).Texto.ToString();

                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cboBusqueda.SelectedItem).Valor.ToString();

            if (dgvData.Rows.Count > 0)
            {
                //Para cada fila, verifica si el valor de la celda en la columna especificada contiene el texto de búsqueda (txtbusqueda).
                //Si lo contiene, la fila se hace visible; de lo contrario, se oculta.
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    //Se utiliza ToUpper para convertir ambos texto a mayuscula
                    //para de esta forma forza a coincidan los textos
                    //y no diferencie entre mayusculas y minusculas.
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }

        }
        private void btnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                row.Visible = true;
            }
        }
        //Boton para exportar las filas del dgvData a un archivo Excel
        private void btnExportar_Click(object sender, EventArgs e)
        {
            //Valida que haya registros en el dgvData
            if (dgvData.Rows.Count < 1)
            {
                MessageBox.Show("No hay registros en el dgvData");
            }
            else
            {
                DataTable dt = new DataTable();

                //Siempre y cuando se cumplan las condiciones de if dentro del foreach,
                //se agregar una nueva columna al DataTable dt con el mismo nombre que la cabecera de la columna.
                foreach (DataGridViewColumn columna in dgvData.Columns)
                {
                    if (columna.HeaderText != "" && columna.Visible == true)
                        dt.Columns.Add(columna.HeaderText, typeof(string));
                }

                //Inserta la filas de el dgvData
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    if (row.Visible == true)
                    {
                        dt.Rows.Add(new object[]
                        {
                            //Filas visibles del dgvData
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[5].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[7].Value.ToString(),
                            row.Cells[9].Value.ToString(),
                        });
                    }
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteClientes_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss")); //Nombre del archivo y fecha de creacion
                savefile.Filter = "Excel Files | *xlsx"; //Filtra solamente archivos con extension xlsx

                //Evento que se dispara cuando se presiona aceptar en la ventana para guardar el archivo
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al generar el reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }




        }

        // OTROS EVENTOS ******************************************************************//
        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.user_check_16x18.Width;
                var h = Properties.Resources.user_check_16x18.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.user_check_16x18, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

        }
        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex; //Obtiene el indice de la fila seleccionada

                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtId.Text = dgvData.Rows[indice].Cells["IdCliente"].Value.ToString();
                    txtDocumento.Text = dgvData.Rows[indice].Cells["Documento"].Value.ToString();

                    string cuit = dgvData.Rows[indice].Cells["CUIT"].Value.ToString();

                    txtCuit1.Text = cuit.Substring(0, 2);
                    txtCuit2.Text = cuit.Substring(2, 8);
                    txtCuit3.Text = cuit.Substring(10, 1);

                    txtNombreCompleto.Text = dgvData.Rows[indice].Cells["NombreCompleto"].Value.ToString();

                    //Separa la direccion obtenido del dgvData y coloca la parte que corresponda en su campo de texto
                    string[] partesDireccion = dgvData.Rows[indice].Cells["Direccion"].Value.ToString().Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                    txtProvincia.Text = partesDireccion[0].Trim();
                    txtPartido.Text = partesDireccion[1].Trim();
                    txtLocalidad.Text = partesDireccion[2].Trim();
                    txtCalle.Text = partesDireccion[3].Trim();

                    txtTelefono.Text = dgvData.Rows[indice].Cells["Telefono"].Value.ToString();
                    txtCorreo.Text = dgvData.Rows[indice].Cells["Correo"].Value.ToString();


                    //Muestra en el combobox cboCondicionFiscal la Condicion Fiscal que le corresponda al cliente que se selecciono
                    foreach (OpcionCombo oc in cboCondicionFiscal.Items)
                    {
                        //Valida que valor del combo sea el mismo que el de rol del usuario
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["IdCondicionFiscal"].Value))
                        {
                            int indice_combo = cboCondicionFiscal.Items.IndexOf(oc);
                            cboCondicionFiscal.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }



        }
        private void cboBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";

            txtBusqueda.AutoCompleteCustomSource = AutoCompletado.Carga_Autocompletado(cboBusqueda, "Cliente");
        }

        //Lo que se escribe en el documento lo escribe en el CUIT
        private void txtDocumento_KeyUp(object sender, KeyEventArgs e)
        {
            txtCuit2.Text = txtDocumento.Text;
        }


        #region Eventos KeyPress
        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionKeyPress.SoloNumerosEnteros(e);
        }
        private void txtCuit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionKeyPress.SoloNumerosEnteros(e);
        }
        private void txtCuit2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionKeyPress.SoloNumerosEnteros(e);
        }
        private void txtCuit3_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionKeyPress.SoloNumerosEnteros(e);
        }
        private void txtNombreCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionKeyPress.SoloLetras(e);
        }
        private void txtProvincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionKeyPress.SoloLetrasYNumeros(e);
        }
        private void txtLocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionKeyPress.SoloLetrasYNumeros(e);
        }
        private void txtCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionKeyPress.SoloLetrasYNumeros(e);
        }
        private void txtPartido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionKeyPress.SoloLetrasYNumeros(e);
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionKeyPress.SoloNumerosEnteros(e);
        }
        #endregion

        #endregion

        // METODOS *************************************************************************//

        #region Metodos
        public void Carga_cboCondicionFiscal()
        {
            List<CondicionFiscal> lista = new CN_CondicionFiscal().Listar();

            foreach (CondicionFiscal item in lista)
            {
                cboCondicionFiscal.Items.Add(new OpcionCombo() { Valor = item.IdCondicionFiscal, Texto = item.Descripcion });
            }
            cboCondicionFiscal.DisplayMember = "Texto";
            cboCondicionFiscal.ValueMember = "Valor";
            cboCondicionFiscal.SelectedIndex = 0;
        }
        public void Carga_cboBusqueda()
        {
            //Carga el combobox cbobusqueda con los valores de los titulos de las columnas del dgvdata
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cboBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            cboBusqueda.DisplayMember = "Texto";
            cboBusqueda.ValueMember = "Valor";
            cboBusqueda.SelectedIndex = 0;
        }
        public void Carga_dgvData()
        {
            List<Cliente> listaClientes = new CN_Cliente().Listar();

            foreach (Cliente item in listaClientes)
            {
                dgvData.Rows.Add(new object[] {"",
                    item.IdCliente,
                    item.Documento,
                    item.CUIT,
                    item.NombreCompleto,
                    item.Direccion,
                    item.Telefono,
                    item.Correo,
                    item.oCondicionFiscal.IdCondicionFiscal,
                    item.oCondicionFiscal.Descripcion
                });
            }

        }
        public void Limpiar()
        {
            txtId.Text = "0";

            txtDocumento.Text = "";
            txtCuit1.Text = "";
            txtCuit2.Text = "";
            txtCuit3.Text = "";
            txtNombreCompleto.Text = "";
            txtProvincia.Text = "";
            txtPartido.Text = "";
            txtLocalidad.Text = "";
            txtCalle.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";

            cboCondicionFiscal.SelectedIndex = 0;
        }

        #endregion


    }
}
