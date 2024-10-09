namespace CapaPresentacion.Forms.FormCliente
{
    partial class frmGestionClientes
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
            this.iconoSeccion = new FontAwesome.Sharp.IconPictureBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.lblSeccionClientes = new System.Windows.Forms.Label();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCondicionFiscal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CondicionFiscal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblListaClientes = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnGuardarCambios = new FontAwesome.Sharp.IconButton();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtPartido = new System.Windows.Forms.TextBox();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.cboCondicionFiscal = new System.Windows.Forms.ComboBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCondicionFiscal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCuit3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCuit2 = new System.Windows.Forms.TextBox();
            this.txtCuit1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconoSeccion)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            this.panelInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconoSeccion
            // 
            this.iconoSeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.iconoSeccion.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.iconoSeccion.IconColor = System.Drawing.Color.White;
            this.iconoSeccion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconoSeccion.IconSize = 36;
            this.iconoSeccion.Location = new System.Drawing.Point(328, -2);
            this.iconoSeccion.Margin = new System.Windows.Forms.Padding(2);
            this.iconoSeccion.Name = "iconoSeccion";
            this.iconoSeccion.Size = new System.Drawing.Size(36, 37);
            this.iconoSeccion.TabIndex = 91;
            this.iconoSeccion.TabStop = false;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BarraTitulo.Controls.Add(this.iconoSeccion);
            this.BarraTitulo.Controls.Add(this.lblSeccionClientes);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(899, 28);
            this.BarraTitulo.TabIndex = 143;
            // 
            // lblSeccionClientes
            // 
            this.lblSeccionClientes.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblSeccionClientes.ForeColor = System.Drawing.Color.White;
            this.lblSeccionClientes.Location = new System.Drawing.Point(0, 0);
            this.lblSeccionClientes.Name = "lblSeccionClientes";
            this.lblSeccionClientes.Size = new System.Drawing.Size(899, 28);
            this.lblSeccionClientes.TabIndex = 92;
            this.lblSeccionClientes.Text = "Gestión de Clientes";
            this.lblSeccionClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelInferior.Controls.Add(this.btnExportar);
            this.panelInferior.Controls.Add(this.btnLimpiarBuscador);
            this.panelInferior.Controls.Add(this.btnBuscar);
            this.panelInferior.Controls.Add(this.txtBusqueda);
            this.panelInferior.Controls.Add(this.cboBusqueda);
            this.panelInferior.Controls.Add(this.label11);
            this.panelInferior.Controls.Add(this.dgvData);
            this.panelInferior.Controls.Add(this.lblListaClientes);
            this.panelInferior.Controls.Add(this.label9);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 220);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(899, 383);
            this.panelInferior.TabIndex = 155;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.White;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Image = global::CapaPresentacion.Properties.Resources.file_type_excel;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExportar.Location = new System.Drawing.Point(35, 57);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(121, 28);
            this.btnExportar.TabIndex = 17;
            this.btnExportar.Text = "Descargar Excel";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnLimpiarBuscador
            // 
            this.btnLimpiarBuscador.BackColor = System.Drawing.Color.White;
            this.btnLimpiarBuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarBuscador.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBuscador.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarBuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarBuscador.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarBuscador.IconSize = 20;
            this.btnLimpiarBuscador.Location = new System.Drawing.Point(789, 59);
            this.btnLimpiarBuscador.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            this.btnLimpiarBuscador.Size = new System.Drawing.Size(40, 22);
            this.btnLimpiarBuscador.TabIndex = 16;
            this.btnLimpiarBuscador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarBuscador.UseVisualStyleBackColor = false;
            this.btnLimpiarBuscador.Click += new System.EventHandler(this.btnLimpiarBuscador_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 20;
            this.btnBuscar.Location = new System.Drawing.Point(741, 59);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 22);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBusqueda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBusqueda.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(547, 59);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(185, 22);
            this.txtBusqueda.TabIndex = 14;
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqueda.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Location = new System.Drawing.Point(351, 59);
            this.cboBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(192, 22);
            this.cboBusqueda.TabIndex = 13;
            this.cboBusqueda.SelectedIndexChanged += new System.EventHandler(this.cboBusqueda_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(279, 62);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 14);
            this.label11.TabIndex = 58;
            this.label11.Text = "Buscar por:";
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
            this.IdCliente,
            this.Documento,
            this.CUIT,
            this.NombreCompleto,
            this.Direccion,
            this.Telefono,
            this.Correo,
            this.IdCondicionFiscal,
            this.CondicionFiscal});
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
            this.btnseleccionar.FillWeight = 13.06545F;
            this.btnseleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.MinimumWidth = 40;
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            this.btnseleccionar.Width = 40;
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "IdCliente";
            this.IdCliente.MinimumWidth = 6;
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Visible = false;
            this.IdCliente.Width = 86;
            // 
            // Documento
            // 
            this.Documento.FillWeight = 100.5776F;
            this.Documento.HeaderText = "Nro Documento";
            this.Documento.MinimumWidth = 6;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 147;
            // 
            // CUIT
            // 
            this.CUIT.FillWeight = 119.8264F;
            this.CUIT.HeaderText = "CUIT";
            this.CUIT.Name = "CUIT";
            this.CUIT.ReadOnly = true;
            this.CUIT.Width = 175;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.FillWeight = 68.84187F;
            this.NombreCompleto.HeaderText = "Nombre Completo / Razón Social";
            this.NombreCompleto.MinimumWidth = 6;
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 101;
            // 
            // Direccion
            // 
            this.Direccion.FillWeight = 73.32114F;
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 107;
            // 
            // Telefono
            // 
            this.Telefono.FillWeight = 67.62004F;
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 99;
            // 
            // Correo
            // 
            this.Correo.FillWeight = 71.85994F;
            this.Correo.HeaderText = "Correo Electrónico";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 105;
            // 
            // IdCondicionFiscal
            // 
            this.IdCondicionFiscal.HeaderText = "IdCondicionFiscal";
            this.IdCondicionFiscal.MinimumWidth = 6;
            this.IdCondicionFiscal.Name = "IdCondicionFiscal";
            this.IdCondicionFiscal.ReadOnly = true;
            this.IdCondicionFiscal.Visible = false;
            this.IdCondicionFiscal.Width = 73;
            // 
            // CondicionFiscal
            // 
            this.CondicionFiscal.FillWeight = 71.85994F;
            this.CondicionFiscal.HeaderText = "Condición Fiscal";
            this.CondicionFiscal.Name = "CondicionFiscal";
            this.CondicionFiscal.ReadOnly = true;
            this.CondicionFiscal.Width = 106;
            // 
            // lblListaClientes
            // 
            this.lblListaClientes.BackColor = System.Drawing.Color.White;
            this.lblListaClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblListaClientes.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaClientes.Location = new System.Drawing.Point(6, 6);
            this.lblListaClientes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListaClientes.Name = "lblListaClientes";
            this.lblListaClientes.Padding = new System.Windows.Forms.Padding(2, 6, 0, 0);
            this.lblListaClientes.Size = new System.Drawing.Size(882, 86);
            this.lblListaClientes.TabIndex = 22;
            this.lblListaClientes.Text = "Lista de Clientes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(2095, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 14);
            this.label9.TabIndex = 209;
            this.label9.Text = "DIRECCIÓN";
            // 
            // panelSuperior
            // 
            this.panelSuperior.Controls.Add(this.btnLimpiar);
            this.panelSuperior.Controls.Add(this.txtTelefono);
            this.panelSuperior.Controls.Add(this.btnGuardarCambios);
            this.panelSuperior.Controls.Add(this.txtCalle);
            this.panelSuperior.Controls.Add(this.txtLocalidad);
            this.panelSuperior.Controls.Add(this.txtPartido);
            this.panelSuperior.Controls.Add(this.txtProvincia);
            this.panelSuperior.Controls.Add(this.cboCondicionFiscal);
            this.panelSuperior.Controls.Add(this.txtCorreo);
            this.panelSuperior.Controls.Add(this.lblCondicionFiscal);
            this.panelSuperior.Controls.Add(this.label4);
            this.panelSuperior.Controls.Add(this.label3);
            this.panelSuperior.Controls.Add(this.label6);
            this.panelSuperior.Controls.Add(this.label7);
            this.panelSuperior.Controls.Add(this.label1);
            this.panelSuperior.Controls.Add(this.txtCuit3);
            this.panelSuperior.Controls.Add(this.label10);
            this.panelSuperior.Controls.Add(this.lblCorreo);
            this.panelSuperior.Controls.Add(this.txtCuit2);
            this.panelSuperior.Controls.Add(this.txtCuit1);
            this.panelSuperior.Controls.Add(this.label5);
            this.panelSuperior.Controls.Add(this.txtDocumento);
            this.panelSuperior.Controls.Add(this.lblNumeroDocumento);
            this.panelSuperior.Controls.Add(this.label8);
            this.panelSuperior.Controls.Add(this.txtNombreCompleto);
            this.panelSuperior.Controls.Add(this.lblNombre);
            this.panelSuperior.Controls.Add(this.txtId);
            this.panelSuperior.Controls.Add(this.txtIndice);
            this.panelSuperior.Controls.Add(this.label2);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSuperior.Location = new System.Drawing.Point(0, 28);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(899, 192);
            this.panelSuperior.TabIndex = 156;
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
            this.btnLimpiar.Location = new System.Drawing.Point(767, 141);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(96, 35);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(607, 56);
            this.txtTelefono.MaxLength = 15;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ShortcutsEnabled = false;
            this.txtTelefono.Size = new System.Drawing.Size(192, 22);
            this.txtTelefono.TabIndex = 11;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
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
            this.btnGuardarCambios.Location = new System.Drawing.Point(607, 141);
            this.btnGuardarCambios.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(144, 35);
            this.btnGuardarCambios.TabIndex = 13;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // txtCalle
            // 
            this.txtCalle.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalle.Location = new System.Drawing.Point(423, 103);
            this.txtCalle.MaxLength = 50;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.ShortcutsEnabled = false;
            this.txtCalle.Size = new System.Drawing.Size(164, 22);
            this.txtCalle.TabIndex = 9;
            this.txtCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalle_KeyPress);
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalidad.Location = new System.Drawing.Point(423, 56);
            this.txtLocalidad.MaxLength = 50;
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.ShortcutsEnabled = false;
            this.txtLocalidad.Size = new System.Drawing.Size(164, 22);
            this.txtLocalidad.TabIndex = 8;
            this.txtLocalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLocalidad_KeyPress);
            // 
            // txtPartido
            // 
            this.txtPartido.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartido.Location = new System.Drawing.Point(237, 103);
            this.txtPartido.MaxLength = 50;
            this.txtPartido.Name = "txtPartido";
            this.txtPartido.ShortcutsEnabled = false;
            this.txtPartido.Size = new System.Drawing.Size(163, 22);
            this.txtPartido.TabIndex = 7;
            this.txtPartido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPartido_KeyPress);
            // 
            // txtProvincia
            // 
            this.txtProvincia.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvincia.Location = new System.Drawing.Point(235, 56);
            this.txtProvincia.MaxLength = 50;
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.ShortcutsEnabled = false;
            this.txtProvincia.Size = new System.Drawing.Size(164, 22);
            this.txtProvincia.TabIndex = 6;
            this.txtProvincia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProvincia_KeyPress);
            // 
            // cboCondicionFiscal
            // 
            this.cboCondicionFiscal.BackColor = System.Drawing.SystemColors.Window;
            this.cboCondicionFiscal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCondicionFiscal.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCondicionFiscal.FormattingEnabled = true;
            this.cboCondicionFiscal.Location = new System.Drawing.Point(424, 149);
            this.cboCondicionFiscal.Name = "cboCondicionFiscal";
            this.cboCondicionFiscal.Size = new System.Drawing.Size(163, 22);
            this.cboCondicionFiscal.TabIndex = 10;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(607, 103);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ShortcutsEnabled = false;
            this.txtCorreo.Size = new System.Drawing.Size(256, 22);
            this.txtCorreo.TabIndex = 12;
            // 
            // lblCondicionFiscal
            // 
            this.lblCondicionFiscal.AutoSize = true;
            this.lblCondicionFiscal.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondicionFiscal.Location = new System.Drawing.Point(421, 132);
            this.lblCondicionFiscal.Name = "lblCondicionFiscal";
            this.lblCondicionFiscal.Size = new System.Drawing.Size(97, 14);
            this.lblCondicionFiscal.TabIndex = 191;
            this.lblCondicionFiscal.Text = "Condición Fiscal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(420, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 14);
            this.label4.TabIndex = 213;
            this.label4.Text = "Calle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(421, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 212;
            this.label3.Text = "Localidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(234, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 14);
            this.label6.TabIndex = 211;
            this.label6.Text = "Partido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(234, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 14);
            this.label7.TabIndex = 210;
            this.label7.Text = "Provincia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 14);
            this.label1.TabIndex = 202;
            this.label1.Text = "CUIT";
            // 
            // txtCuit3
            // 
            this.txtCuit3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuit3.Location = new System.Drawing.Point(173, 99);
            this.txtCuit3.MaxLength = 1;
            this.txtCuit3.Name = "txtCuit3";
            this.txtCuit3.ShortcutsEnabled = false;
            this.txtCuit3.Size = new System.Drawing.Size(34, 22);
            this.txtCuit3.TabIndex = 4;
            this.txtCuit3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCuit3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuit3_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(604, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 14);
            this.label10.TabIndex = 215;
            this.label10.Text = "Teléfono";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(604, 87);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(106, 14);
            this.lblCorreo.TabIndex = 194;
            this.lblCorreo.Text = "Correo Electrónico";
            // 
            // txtCuit2
            // 
            this.txtCuit2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuit2.Location = new System.Drawing.Point(59, 99);
            this.txtCuit2.MaxLength = 8;
            this.txtCuit2.Name = "txtCuit2";
            this.txtCuit2.ReadOnly = true;
            this.txtCuit2.ShortcutsEnabled = false;
            this.txtCuit2.Size = new System.Drawing.Size(103, 22);
            this.txtCuit2.TabIndex = 3;
            this.txtCuit2.TabStop = false;
            this.txtCuit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCuit2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuit2_KeyPress);
            // 
            // txtCuit1
            // 
            this.txtCuit1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuit1.Location = new System.Drawing.Point(12, 99);
            this.txtCuit1.MaxLength = 2;
            this.txtCuit1.Name = "txtCuit1";
            this.txtCuit1.ShortcutsEnabled = false;
            this.txtCuit1.Size = new System.Drawing.Size(34, 22);
            this.txtCuit1.TabIndex = 2;
            this.txtCuit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCuit1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuit1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 23);
            this.label5.TabIndex = 203;
            this.label5.Text = "-";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(12, 56);
            this.txtDocumento.MaxLength = 8;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.ShortcutsEnabled = false;
            this.txtDocumento.Size = new System.Drawing.Size(195, 22);
            this.txtDocumento.TabIndex = 1;
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            this.txtDocumento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDocumento_KeyUp);
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblNumeroDocumento.Location = new System.Drawing.Point(9, 41);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(117, 14);
            this.lblNumeroDocumento.TabIndex = 193;
            this.lblNumeroDocumento.Text = "Número Documento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(9, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 19);
            this.label8.TabIndex = 195;
            this.label8.Text = "DATOS DEL CLIENTE";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCompleto.Location = new System.Drawing.Point(12, 149);
            this.txtNombreCompleto.MaxLength = 70;
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.ShortcutsEnabled = false;
            this.txtNombreCompleto.Size = new System.Drawing.Size(387, 22);
            this.txtNombreCompleto.TabIndex = 5;
            this.txtNombreCompleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCompleto_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(9, 132);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(188, 14);
            this.lblNombre.TabIndex = 189;
            this.lblNombre.Text = "Nombre Completo / Razón Social";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(859, 3);
            this.txtId.MaxLength = 32;
            this.txtId.Name = "txtId";
            this.txtId.ShortcutsEnabled = false;
            this.txtId.Size = new System.Drawing.Size(30, 22);
            this.txtId.TabIndex = 197;
            this.txtId.TabStop = false;
            this.txtId.Text = "0";
            this.txtId.Visible = false;
            // 
            // txtIndice
            // 
            this.txtIndice.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndice.Location = new System.Drawing.Point(823, 3);
            this.txtIndice.MaxLength = 32;
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.ShortcutsEnabled = false;
            this.txtIndice.Size = new System.Drawing.Size(30, 22);
            this.txtIndice.TabIndex = 196;
            this.txtIndice.TabStop = false;
            this.txtIndice.Text = "0";
            this.txtIndice.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 23);
            this.label2.TabIndex = 204;
            this.label2.Text = "-";
            // 
            // frmGestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 603);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionClientes";
            this.Text = "frmGestionClientes";
            this.Load += new System.EventHandler(this.frmGestionClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconoSeccion)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.panelInferior.ResumeLayout(false);
            this.panelInferior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconoSeccion;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label lblSeccionClientes;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Button btnExportar;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscador;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblListaClientes;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Panel panelSuperior;
        private FontAwesome.Sharp.IconButton btnGuardarCambios;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.ComboBox cboCondicionFiscal;
        private System.Windows.Forms.Label lblCondicionFiscal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCuit3;
        private System.Windows.Forms.TextBox txtCuit2;
        private System.Windows.Forms.TextBox txtCuit1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPartido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCondicionFiscal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CondicionFiscal;
    }
}