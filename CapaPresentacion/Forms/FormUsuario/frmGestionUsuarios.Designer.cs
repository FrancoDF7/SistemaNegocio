namespace CapaPresentacion.Forms.FormUsuario
{
    partial class frmGestionUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionUsuarios));
            this.label8 = new System.Windows.Forms.Label();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.iconoSeccion = new FontAwesome.Sharp.IconPictureBox();
            this.lblSeccionUsuarios = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.btnexportar = new System.Windows.Forms.Button();
            this.btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblListaUsuarios = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdImagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtIdImagen = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblConfirmarClave = new System.Windows.Forms.Label();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.btnVerOcultarClave2 = new FontAwesome.Sharp.IconButton();
            this.btnVerOcultarClave1 = new FontAwesome.Sharp.IconButton();
            this.btnGuardarCambios = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnCambiarImagen = new FontAwesome.Sharp.IconButton();
            this.iconoUsuario = new System.Windows.Forms.PictureBox();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoSeccion)).BeginInit();
            this.panelInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(150, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 19);
            this.label8.TabIndex = 143;
            this.label8.Text = "DATOS DEL USUARIO";
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BarraTitulo.Controls.Add(this.iconoSeccion);
            this.BarraTitulo.Controls.Add(this.lblSeccionUsuarios);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(899, 28);
            this.BarraTitulo.TabIndex = 142;
            // 
            // iconoSeccion
            // 
            this.iconoSeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.iconoSeccion.IconChar = FontAwesome.Sharp.IconChar.UsersGear;
            this.iconoSeccion.IconColor = System.Drawing.Color.White;
            this.iconoSeccion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconoSeccion.IconSize = 36;
            this.iconoSeccion.Location = new System.Drawing.Point(325, -1);
            this.iconoSeccion.Margin = new System.Windows.Forms.Padding(2);
            this.iconoSeccion.Name = "iconoSeccion";
            this.iconoSeccion.Size = new System.Drawing.Size(36, 37);
            this.iconoSeccion.TabIndex = 91;
            this.iconoSeccion.TabStop = false;
            // 
            // lblSeccionUsuarios
            // 
            this.lblSeccionUsuarios.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblSeccionUsuarios.ForeColor = System.Drawing.Color.White;
            this.lblSeccionUsuarios.Location = new System.Drawing.Point(0, 3);
            this.lblSeccionUsuarios.Name = "lblSeccionUsuarios";
            this.lblSeccionUsuarios.Size = new System.Drawing.Size(899, 25);
            this.lblSeccionUsuarios.TabIndex = 92;
            this.lblSeccionUsuarios.Text = "Gestión de Usuarios";
            this.lblSeccionUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(559, 57);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(106, 14);
            this.lblCorreo.TabIndex = 137;
            this.lblCorreo.Text = "Correo Electrónico";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(562, 74);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ShortcutsEnabled = false;
            this.txtCorreo.Size = new System.Drawing.Size(267, 22);
            this.txtCorreo.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(729, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 14);
            this.label12.TabIndex = 138;
            this.label12.Text = "Estado";
            // 
            // cboEstado
            // 
            this.cboEstado.BackColor = System.Drawing.SystemColors.Window;
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(732, 123);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(97, 22);
            this.cboEstado.TabIndex = 7;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(154, 74);
            this.txtDocumento.MaxLength = 8;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.ShortcutsEnabled = false;
            this.txtDocumento.Size = new System.Drawing.Size(178, 22);
            this.txtDocumento.TabIndex = 1;
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            // 
            // cboRol
            // 
            this.cboRol.BackColor = System.Drawing.SystemColors.Window;
            this.cboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRol.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Location = new System.Drawing.Point(562, 123);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(144, 22);
            this.cboRol.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(354, 123);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ShortcutsEnabled = false;
            this.txtApellido.Size = new System.Drawing.Size(177, 22);
            this.txtApellido.TabIndex = 5;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(155, 123);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(177, 22);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuario.Location = new System.Drawing.Point(559, 106);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(92, 14);
            this.lblTipoUsuario.TabIndex = 132;
            this.lblTipoUsuario.Text = "Tipo de Usuario";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(355, 74);
            this.txtNombreUsuario.MaxLength = 32;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.ShortcutsEnabled = false;
            this.txtNombreUsuario.Size = new System.Drawing.Size(176, 22);
            this.txtNombreUsuario.TabIndex = 2;
            this.txtNombreUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreUsuario_KeyPress);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(351, 60);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(49, 14);
            this.lblUsuario.TabIndex = 131;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(152, 106);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 14);
            this.lblNombre.TabIndex = 130;
            this.lblNombre.Text = "Nombre";
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblNumeroDocumento.Location = new System.Drawing.Point(151, 59);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(117, 14);
            this.lblNumeroDocumento.TabIndex = 136;
            this.lblNumeroDocumento.Text = "Número Documento";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(352, 106);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 14);
            this.lblApellido.TabIndex = 135;
            this.lblApellido.Text = "Apellido";
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelInferior.Controls.Add(this.btnexportar);
            this.panelInferior.Controls.Add(this.btnlimpiarbuscador);
            this.panelInferior.Controls.Add(this.btnbuscar);
            this.panelInferior.Controls.Add(this.txtBusqueda);
            this.panelInferior.Controls.Add(this.cboBusqueda);
            this.panelInferior.Controls.Add(this.label11);
            this.panelInferior.Controls.Add(this.lblListaUsuarios);
            this.panelInferior.Controls.Add(this.dgvData);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 220);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(899, 383);
            this.panelInferior.TabIndex = 154;
            // 
            // btnexportar
            // 
            this.btnexportar.BackColor = System.Drawing.Color.White;
            this.btnexportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexportar.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportar.Image = global::CapaPresentacion.Properties.Resources.file_type_excel;
            this.btnexportar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnexportar.Location = new System.Drawing.Point(35, 57);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(121, 28);
            this.btnexportar.TabIndex = 17;
            this.btnexportar.Text = "Descargar Excel";
            this.btnexportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexportar.UseVisualStyleBackColor = false;
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // btnlimpiarbuscador
            // 
            this.btnlimpiarbuscador.BackColor = System.Drawing.Color.White;
            this.btnlimpiarbuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiarbuscador.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiarbuscador.ForeColor = System.Drawing.Color.White;
            this.btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiarbuscador.IconColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiarbuscador.IconSize = 20;
            this.btnlimpiarbuscador.Location = new System.Drawing.Point(789, 59);
            this.btnlimpiarbuscador.Margin = new System.Windows.Forms.Padding(2);
            this.btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            this.btnlimpiarbuscador.Size = new System.Drawing.Size(40, 22);
            this.btnlimpiarbuscador.TabIndex = 16;
            this.btnlimpiarbuscador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiarbuscador.UseVisualStyleBackColor = false;
            this.btnlimpiarbuscador.Click += new System.EventHandler(this.btnlimpiarbuscador_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.White;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscar.IconColor = System.Drawing.Color.Black;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 20;
            this.btnbuscar.Location = new System.Drawing.Point(741, 59);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(40, 22);
            this.btnbuscar.TabIndex = 15;
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBusqueda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBusqueda.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(591, 59);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(141, 22);
            this.txtBusqueda.TabIndex = 14;
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqueda.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Location = new System.Drawing.Point(461, 59);
            this.cboBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(126, 22);
            this.cboBusqueda.TabIndex = 13;
            this.cboBusqueda.SelectedIndexChanged += new System.EventHandler(this.cboBusqueda_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(392, 62);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 14);
            this.label11.TabIndex = 58;
            this.label11.Text = "Buscar por:";
            // 
            // lblListaUsuarios
            // 
            this.lblListaUsuarios.BackColor = System.Drawing.Color.White;
            this.lblListaUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblListaUsuarios.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaUsuarios.Location = new System.Drawing.Point(6, 6);
            this.lblListaUsuarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListaUsuarios.Name = "lblListaUsuarios";
            this.lblListaUsuarios.Padding = new System.Windows.Forms.Padding(2, 6, 0, 0);
            this.lblListaUsuarios.Size = new System.Drawing.Size(883, 86);
            this.lblListaUsuarios.TabIndex = 22;
            this.lblListaUsuarios.Text = "Lista de Usuarios:";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.Id,
            this.Documento,
            this.NombreUsuario,
            this.Nombre,
            this.Apellido,
            this.Correo,
            this.Clave,
            this.IdRol,
            this.Rol,
            this.EstadoValor,
            this.Estado,
            this.IdImagen});
            this.dgvData.Location = new System.Drawing.Point(6, 98);
            this.dgvData.Margin = new System.Windows.Forms.Padding(2);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowHeadersWidth = 51;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(883, 278);
            this.dgvData.TabIndex = 21;
            this.dgvData.TabStop = false;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.FillWeight = 18.18182F;
            this.btnseleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.MinimumWidth = 40;
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            this.btnseleccionar.Width = 40;
            // 
            // Id
            // 
            this.Id.HeaderText = "IdUsuario";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 86;
            // 
            // Documento
            // 
            this.Documento.FillWeight = 142.1074F;
            this.Documento.HeaderText = "Nro Documento";
            this.Documento.MinimumWidth = 6;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 156;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.FillWeight = 166.7499F;
            this.NombreUsuario.HeaderText = "Usuario";
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.ReadOnly = true;
            this.NombreUsuario.Width = 184;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 95.80006F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 105;
            // 
            // Apellido
            // 
            this.Apellido.FillWeight = 102.0334F;
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 112;
            // 
            // Correo
            // 
            this.Correo.FillWeight = 94.09978F;
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 104;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.MinimumWidth = 6;
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.Visible = false;
            this.Clave.Width = 76;
            // 
            // IdRol
            // 
            this.IdRol.HeaderText = "IdRol";
            this.IdRol.MinimumWidth = 6;
            this.IdRol.Name = "IdRol";
            this.IdRol.ReadOnly = true;
            this.IdRol.Visible = false;
            this.IdRol.Width = 73;
            // 
            // Rol
            // 
            this.Rol.FillWeight = 71.46111F;
            this.Rol.HeaderText = "Rol";
            this.Rol.MinimumWidth = 6;
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            this.Rol.Width = 78;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "EstadoValor";
            this.EstadoValor.MinimumWidth = 6;
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            this.EstadoValor.Width = 123;
            // 
            // Estado
            // 
            this.Estado.FillWeight = 109.5666F;
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 121;
            // 
            // IdImagen
            // 
            this.IdImagen.HeaderText = "IdImagen";
            this.IdImagen.Name = "IdImagen";
            this.IdImagen.ReadOnly = true;
            this.IdImagen.Visible = false;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(4, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(890, 187);
            this.label13.TabIndex = 155;
            this.label13.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(808, 37);
            this.txtId.MaxLength = 32;
            this.txtId.Name = "txtId";
            this.txtId.ShortcutsEnabled = false;
            this.txtId.Size = new System.Drawing.Size(30, 22);
            this.txtId.TabIndex = 172;
            this.txtId.TabStop = false;
            this.txtId.Text = "0";
            this.txtId.Visible = false;
            // 
            // txtIdImagen
            // 
            this.txtIdImagen.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdImagen.Location = new System.Drawing.Point(844, 37);
            this.txtIdImagen.MaxLength = 32;
            this.txtIdImagen.Name = "txtIdImagen";
            this.txtIdImagen.ShortcutsEnabled = false;
            this.txtIdImagen.Size = new System.Drawing.Size(30, 22);
            this.txtIdImagen.TabIndex = 173;
            this.txtIdImagen.TabStop = false;
            this.txtIdImagen.Text = "1";
            this.txtIdImagen.Visible = false;
            this.txtIdImagen.TextChanged += new System.EventHandler(this.txtIdImagen_TextChanged);
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(155, 172);
            this.txtClave.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.txtClave.MaxLength = 50;
            this.txtClave.Name = "txtClave";
            this.txtClave.ShortcutsEnabled = false;
            this.txtClave.Size = new System.Drawing.Size(145, 22);
            this.txtClave.TabIndex = 9;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(152, 155);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(70, 14);
            this.lblClave.TabIndex = 178;
            this.lblClave.Text = "Contraseña";
            // 
            // lblConfirmarClave
            // 
            this.lblConfirmarClave.AutoSize = true;
            this.lblConfirmarClave.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarClave.Location = new System.Drawing.Point(352, 155);
            this.lblConfirmarClave.Name = "lblConfirmarClave";
            this.lblConfirmarClave.Size = new System.Drawing.Size(126, 14);
            this.lblConfirmarClave.TabIndex = 179;
            this.lblConfirmarClave.Text = "Confirmar contraseña";
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarClave.Location = new System.Drawing.Point(354, 172);
            this.txtConfirmarClave.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.txtConfirmarClave.MaxLength = 50;
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.ShortcutsEnabled = false;
            this.txtConfirmarClave.Size = new System.Drawing.Size(145, 22);
            this.txtConfirmarClave.TabIndex = 10;
            // 
            // btnVerOcultarClave2
            // 
            this.btnVerOcultarClave2.BackColor = System.Drawing.Color.White;
            this.btnVerOcultarClave2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerOcultarClave2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnVerOcultarClave2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerOcultarClave2.ForeColor = System.Drawing.Color.White;
            this.btnVerOcultarClave2.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnVerOcultarClave2.IconColor = System.Drawing.Color.Black;
            this.btnVerOcultarClave2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerOcultarClave2.IconSize = 30;
            this.btnVerOcultarClave2.Location = new System.Drawing.Point(499, 172);
            this.btnVerOcultarClave2.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.btnVerOcultarClave2.Name = "btnVerOcultarClave2";
            this.btnVerOcultarClave2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnVerOcultarClave2.Size = new System.Drawing.Size(32, 22);
            this.btnVerOcultarClave2.TabIndex = 182;
            this.btnVerOcultarClave2.TabStop = false;
            this.btnVerOcultarClave2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnVerOcultarClave2.UseVisualStyleBackColor = false;
            this.btnVerOcultarClave2.Click += new System.EventHandler(this.btnVerOcultarClave2_Click);
            // 
            // btnVerOcultarClave1
            // 
            this.btnVerOcultarClave1.BackColor = System.Drawing.Color.White;
            this.btnVerOcultarClave1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerOcultarClave1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnVerOcultarClave1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerOcultarClave1.ForeColor = System.Drawing.Color.White;
            this.btnVerOcultarClave1.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnVerOcultarClave1.IconColor = System.Drawing.Color.Black;
            this.btnVerOcultarClave1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerOcultarClave1.IconSize = 30;
            this.btnVerOcultarClave1.Location = new System.Drawing.Point(300, 172);
            this.btnVerOcultarClave1.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.btnVerOcultarClave1.Name = "btnVerOcultarClave1";
            this.btnVerOcultarClave1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnVerOcultarClave1.Size = new System.Drawing.Size(32, 22);
            this.btnVerOcultarClave1.TabIndex = 180;
            this.btnVerOcultarClave1.TabStop = false;
            this.btnVerOcultarClave1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnVerOcultarClave1.UseVisualStyleBackColor = false;
            this.btnVerOcultarClave1.Click += new System.EventHandler(this.btnVerOcultarClave1_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardarCambios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarCambios.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarCambios.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardarCambios.IconColor = System.Drawing.Color.Black;
            this.btnGuardarCambios.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnGuardarCambios.IconSize = 20;
            this.btnGuardarCambios.Location = new System.Drawing.Point(562, 164);
            this.btnGuardarCambios.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(144, 35);
            this.btnGuardarCambios.TabIndex = 11;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 20;
            this.btnLimpiar.Location = new System.Drawing.Point(733, 164);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(96, 35);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCambiarImagen
            // 
            this.btnCambiarImagen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCambiarImagen.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnCambiarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarImagen.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.btnCambiarImagen.ForeColor = System.Drawing.Color.Black;
            this.btnCambiarImagen.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btnCambiarImagen.IconColor = System.Drawing.Color.Black;
            this.btnCambiarImagen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCambiarImagen.IconSize = 30;
            this.btnCambiarImagen.Location = new System.Drawing.Point(18, 159);
            this.btnCambiarImagen.Name = "btnCambiarImagen";
            this.btnCambiarImagen.Size = new System.Drawing.Size(115, 44);
            this.btnCambiarImagen.TabIndex = 8;
            this.btnCambiarImagen.Text = "Cambiar imagen";
            this.btnCambiarImagen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCambiarImagen.UseVisualStyleBackColor = false;
            this.btnCambiarImagen.Click += new System.EventHandler(this.btnCambiarImagen_Click);
            // 
            // iconoUsuario
            // 
            this.iconoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("iconoUsuario.Image")));
            this.iconoUsuario.Location = new System.Drawing.Point(18, 40);
            this.iconoUsuario.Name = "iconoUsuario";
            this.iconoUsuario.Size = new System.Drawing.Size(113, 113);
            this.iconoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconoUsuario.TabIndex = 170;
            this.iconoUsuario.TabStop = false;
            // 
            // txtIndice
            // 
            this.txtIndice.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndice.Location = new System.Drawing.Point(772, 37);
            this.txtIndice.MaxLength = 32;
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.ShortcutsEnabled = false;
            this.txtIndice.Size = new System.Drawing.Size(30, 22);
            this.txtIndice.TabIndex = 156;
            this.txtIndice.TabStop = false;
            this.txtIndice.Text = "-1";
            this.txtIndice.Visible = false;
            // 
            // frmGestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 603);
            this.Controls.Add(this.btnVerOcultarClave2);
            this.Controls.Add(this.txtConfirmarClave);
            this.Controls.Add(this.btnVerOcultarClave1);
            this.Controls.Add(this.lblConfirmarClave);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtIdImagen);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.lblNumeroDocumento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCambiarImagen);
            this.Controls.Add(this.iconoUsuario);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.cboRol);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionUsuarios";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmGestionUsuarios_Load);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconoSeccion)).EndInit();
            this.panelInferior.ResumeLayout(false);
            this.panelInferior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label lblSeccionUsuarios;
        private FontAwesome.Sharp.IconPictureBox iconoSeccion;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblListaUsuarios;
        private System.Windows.Forms.PictureBox iconoUsuario;
        private FontAwesome.Sharp.IconButton btnCambiarImagen;
        private System.Windows.Forms.Button btnexportar;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtIdImagen;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnGuardarCambios;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblConfirmarClave;
        private FontAwesome.Sharp.IconButton btnVerOcultarClave1;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private FontAwesome.Sharp.IconButton btnVerOcultarClave2;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdImagen;
        private System.Windows.Forms.TextBox txtIndice;
    }
}