using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaSoporte.Utilidades;
using CapaNegocio;
using CapaSoporte.Validaciones;
using System.IO;
using FontAwesome.Sharp;
using ClosedXML.Excel;
using CapaPresentacion.MessageBoxCustom;

namespace CapaPresentacion.Forms.FormUsuario
{
    public partial class frmGestionUsuarios : Form
    {
        //FALTA AGREGARLE QUE SE CAMBIE EL ICONO DEL USUARIO EN FRMINICIO SI QUE SE EDITA EL USUARIO LOGEADO EN ES MOMENTO

        //VARIABLES E INSTANCIAS
        private DialogResult respuesta;
        
        // CONSTRUCTOR *********************************************************************//
        public frmGestionUsuarios()
        {
            InitializeComponent();
        }


        #region Eventos

        // EVENTO LOAD DEL FORMULARIO *******************************************************//
        private void frmGestionUsuarios_Load(object sender, EventArgs e)
        {
            txtDocumento.Select();

            txtClave.UseSystemPasswordChar = true;
            txtConfirmarClave.UseSystemPasswordChar = true;

            Carga_cboEstado();

            Carga_cboRol();

            Carga_dgvData();

            Carga_cboBusqueda();
        }

        // EVENTOS DE BOTONES***************************************************************//

        //Boton para guardar y editar usuarios
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
                Correo = txtCorreo.Text.ToLower().Trim(),
                Clave = txtClave.Text,
                ConfirmarClave = txtConfirmarClave.Text,
                oRol = new Rol() { IdRol = Convert.ToInt32(((OpcionCombo)cboRol.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombo)cboEstado.SelectedItem).Valor) == 1 ? true : false,
                IdImagen = Convert.ToByte(txtIdImagen.Text)
            };

            //Si el IdUsuario es igual a 0 significa que se esta creando un nuevo usuario,
            //de lo contrario significa que se esta editando un usuario existente.
            if (obj.IdUsuario == 0)
            {
                if (MessageBox.Show("¿Desea registrar un nuevo usuario?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //REGISTRAR NUEVO USUARIO
                    int idgenerado = new CN_Usuario().Registrar(obj, out mensaje);

                    //Si el idusuariogenerado es distinto de 0 significa que se registro correctamente el usuario
                    if (idgenerado != 0)
                    {
                        //Carga datagridview con los datos del nuevo usuario, el primer valor lleva "" ya que no posee un valor como tal porque es un botón
                        dgvData.Rows.Add(new object[] {"", idgenerado, txtDocumento.Text, txtNombreUsuario.Text, txtNombre.Text, txtApellido.Text, txtCorreo.Text, txtClave.Text,
                ((OpcionCombo)cboRol.SelectedItem).Valor.ToString(),
                ((OpcionCombo)cboRol.SelectedItem).Texto.ToString(),
                ((OpcionCombo)cboEstado.SelectedItem).Valor.ToString(),
                ((OpcionCombo)cboEstado.SelectedItem).Texto.ToString(),
                txtIdImagen.Text
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
                if (MessageBox.Show("¿Desea editar el usuario " + txtNombreUsuario.Text + " ?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //EDITAR USUARIO
                    bool resultado = new CN_Usuario().Editar(obj, out mensaje);

                    //Actualiza en el dgvdata la fila que corresponda con los nuevos valores del usuario que se edito
                    if (resultado)
                    {
                        DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txtIndice.Text)];

                        row.Cells["Id"].Value = txtId.Text;
                        row.Cells["Documento"].Value = txtDocumento.Text;
                        row.Cells["NombreUsuario"].Value = txtNombreUsuario.Text;
                        row.Cells["Nombre"].Value = txtNombre.Text;
                        row.Cells["Apellido"].Value = txtApellido.Text;
                        row.Cells["Correo"].Value = txtCorreo.Text;
                        row.Cells["Clave"].Value = txtClave.Text;
                        row.Cells["IdRol"].Value = ((OpcionCombo)cboRol.SelectedItem).Valor.ToString();
                        row.Cells["Rol"].Value = ((OpcionCombo)cboRol.SelectedItem).Texto.ToString();
                        row.Cells["EstadoValor"].Value = ((OpcionCombo)cboEstado.SelectedItem).Valor.ToString();
                        row.Cells["Estado"].Value = ((OpcionCombo)cboEstado.SelectedItem).Texto.ToString();
                        row.Cells["IdImagen"].Value = txtIdImagen.Text;

                        Limpiar();

                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //Boton para volver a su valor original a los campos de creacion/edicion de usuario
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        //Boton para llamar al formulario para cambiar la imagen del perfil del usuario
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

        //Boton para buscar uno o varios usuario en el dgvData
        private void btnbuscar_Click(object sender, EventArgs e)
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

        //Boton para limpiar txtbusqueda y hacer visibles nuevamente todas las filas si es que se hizo una busqueda
        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                row.Visible = true;
            }
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

        //Boton para exportar las filas del dgvData a un archivo Excel
        private void btnexportar_Click(object sender, EventArgs e)
        {
            //Valida que haya registros en el dgvdata
            if (dgvData.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                //Siempre y cuando se cumplan las condiciones del if dentro de foreach,
                //se agregar una nueva columna al DataTable dt con el mismo nombre que la cabecera de la columna.
                foreach (DataGridViewColumn columna in dgvData.Columns)
                {
                    if (columna.HeaderText != "" && columna.Visible == true)
                        dt.Columns.Add(columna.HeaderText, typeof(string));
                }

                //Inserta la filas de el dgvdata
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    if (row.Visible == true)
                    {
                        dt.Rows.Add(new object[]
                        {
                           //Solamente se encuentra las filas visibles dgvdata
                           row.Cells[2].Value.ToString(),
                           row.Cells[3].Value.ToString(),
                           row.Cells[4].Value.ToString(),
                           row.Cells[5].Value.ToString(),
                           row.Cells[6].Value.ToString(),
                           row.Cells[9].Value.ToString(),
                           row.Cells[11].Value.ToString(),
                        });
                    }
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteUsuarios_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss")); //Nombre del archivo excel junto con su fecha de creacion
                savefile.Filter = "Excel Files | *xlsx"; //Filtra "hace visible" solamente archivos con la extension xlsx

                //Evento que se dispara cuando se presiona aceptar para guardar
                //el archivo en la ubicacion que hallamos seleccionado
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
                    catch
                    {
                        MessageBox.Show("Error al generar el reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }

        // OTROS EVENTOS *********************************************************//

        //Agrega una imagen boton para seleccionar un usuario en el dgvData
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

        //Se encarga de completar los campos de texto y combobox con los datos del usuario que se va editar, obteniendo los datos de dgvdata.
        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex; //Obtiene el indice de la fila seleccionada

                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtId.Text = dgvData.Rows[indice].Cells["Id"].Value.ToString();
                    txtDocumento.Text = dgvData.Rows[indice].Cells["Documento"].Value.ToString();
                    txtNombreUsuario.Text = dgvData.Rows[indice].Cells["NombreUsuario"].Value.ToString();
                    txtNombre.Text = dgvData.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtApellido.Text = dgvData.Rows[indice].Cells["Apellido"].Value.ToString();
                    txtCorreo.Text = dgvData.Rows[indice].Cells["Correo"].Value.ToString();
                    txtClave.Text = dgvData.Rows[indice].Cells["Clave"].Value.ToString();
                    txtConfirmarClave.Text = dgvData.Rows[indice].Cells["Clave"].Value.ToString();
                    txtIdImagen.Text = dgvData.Rows[indice].Cells["IdImagen"].Value.ToString();

                    //Muestra imagen que le corresponde al usuario cuando lo selecciona en el dgvdata
                    iconoUsuario.ImageLocation = RutaImagenes.DevuelveRutaDeImagenes(dgvData.Rows[indice].Cells["IdImagen"].Value.ToString());

                    //Muestra en el combobox cborol el rol que le corresponda al usuario que se selecciono
                    foreach (OpcionCombo oc in cboRol.Items)
                    {
                        //Valida que valor del combo sea el mismo que el de rol del usuario
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["IdRol"].Value))
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
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cboEstado.Items.IndexOf(oc);
                            cboEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                }
            }

            txtNombreUsuario.Enabled = false;
        }

        //Muestra la imagen que le corresponda al IdImagen cuando cambia el texto del txtIdImagen
        private void txtIdImagen_TextChanged(object sender, EventArgs e)
        {
            iconoUsuario.ImageLocation = RutaImagenes.DevuelveRutaDeImagenes(txtIdImagen.Text);
        }

        //Carga los valores de autocompletado en txtBusqueda cada vez que se cambia la opcion del cboBusqueda
        private void cboBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Vacia textbox al cambiar de opcion en el combobox
            txtBusqueda.Text = "";

            txtBusqueda.AutoCompleteCustomSource = AutoCompletado.Carga_Autocompletado(cboBusqueda, "Usuario");
        }


        #region Eventos KeyPress
        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionKeyPress.SoloNumerosEnteros(e);
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionKeyPress.SoloLetras(e);
        }
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionKeyPress.SoloLetras(e);
        }
        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionKeyPress.Valida_NombreUsuario(e);
        }
        #endregion

        #endregion


        // METODOS ******************************************************************//
        #region Metodos
        private void Limpiar()
        {
            txtDocumento.Text = "";
            txtNombreUsuario.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtClave.Text = "";
            txtConfirmarClave.Text = "";

            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtIdImagen.Text = "1";

            txtNombreUsuario.Enabled = true;

            cboRol.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;

            txtDocumento.Select();
        }
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
        public void Carga_dgvData()
        {
            //MOSTRAR TODOS LOS USUARIOS
            //Esta porcion de codigo carga el dgvdata desde la base de datos mediante el metodo listar de clase CN_Usuario.
            List<Usuario> listaUsuario = new CN_Usuario().Listar();

            foreach (Usuario item in listaUsuario)
            {
                dgvData.Rows.Add(new object[] {"", item.IdUsuario, item.Documento, item.NombreUsuario, item.Nombre, item.Apellido, item.Correo, item.Clave,
                item.oRol.IdRol,
                item.oRol.Descripcion,
                item.Estado == true ? 1 : 0,  //Si es true muestra 1 de lo contrario 0
                item.Estado == true ? "Activo" : "No Activo", //Si es true muestra Activo de lo contrario No Activo
                item.IdImagen
                });
            }

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
