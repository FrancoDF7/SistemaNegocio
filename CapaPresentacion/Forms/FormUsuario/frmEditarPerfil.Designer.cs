namespace CapaPresentacion.Forms.FormUsuario
{
    partial class frmEditarPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarPerfil));
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtIdImagen = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblRebordes = new System.Windows.Forms.Label();
            this.lblSeccionUsuarios = new System.Windows.Forms.Label();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.iconoSeccion = new FontAwesome.Sharp.IconPictureBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblConfirmarClave = new System.Windows.Forms.Label();
            this.btnVerOcultarClave2 = new FontAwesome.Sharp.IconButton();
            this.btnVerOcultarClave1 = new FontAwesome.Sharp.IconButton();
            this.btnGuardarCambios = new FontAwesome.Sharp.IconButton();
            this.btnCambiarImagen = new FontAwesome.Sharp.IconButton();
            this.iconoUsuario = new System.Windows.Forms.PictureBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.panelDerecho = new System.Windows.Forms.Panel();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoSeccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarClave.Location = new System.Drawing.Point(359, 182);
            this.txtConfirmarClave.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.txtConfirmarClave.MaxLength = 50;
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.ShortcutsEnabled = false;
            this.txtConfirmarClave.Size = new System.Drawing.Size(145, 22);
            this.txtConfirmarClave.TabIndex = 189;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(156, 165);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(70, 14);
            this.lblClave.TabIndex = 203;
            this.lblClave.Text = "Contraseña";
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(159, 182);
            this.txtClave.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.txtClave.MaxLength = 50;
            this.txtClave.Name = "txtClave";
            this.txtClave.ShortcutsEnabled = false;
            this.txtClave.Size = new System.Drawing.Size(145, 22);
            this.txtClave.TabIndex = 188;
            // 
            // txtIdImagen
            // 
            this.txtIdImagen.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdImagen.Location = new System.Drawing.Point(840, 47);
            this.txtIdImagen.MaxLength = 32;
            this.txtIdImagen.Name = "txtIdImagen";
            this.txtIdImagen.ShortcutsEnabled = false;
            this.txtIdImagen.Size = new System.Drawing.Size(30, 22);
            this.txtIdImagen.TabIndex = 202;
            this.txtIdImagen.TabStop = false;
            this.txtIdImagen.Text = "1";
            this.txtIdImagen.Visible = false;
            this.txtIdImagen.TextChanged += new System.EventHandler(this.txtIdImagen_TextChanged);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Enabled = false;
            this.txtDocumento.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(158, 84);
            this.txtDocumento.MaxLength = 8;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.ShortcutsEnabled = false;
            this.txtDocumento.Size = new System.Drawing.Size(178, 22);
            this.txtDocumento.TabIndex = 183;
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblNumeroDocumento.Location = new System.Drawing.Point(155, 69);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(117, 14);
            this.lblNumeroDocumento.TabIndex = 195;
            this.lblNumeroDocumento.Text = "Número Documento";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(155, 50);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(132, 14);
            this.lblSubtitulo.TabIndex = 197;
            this.lblSubtitulo.Text = "DETALLES USUARIO";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(563, 67);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(106, 14);
            this.lblCorreo.TabIndex = 196;
            this.lblCorreo.Text = "Correo Electrónico";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(566, 84);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ShortcutsEnabled = false;
            this.txtCorreo.Size = new System.Drawing.Size(267, 22);
            this.txtCorreo.TabIndex = 184;
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(358, 133);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ShortcutsEnabled = false;
            this.txtApellido.Size = new System.Drawing.Size(177, 22);
            this.txtApellido.TabIndex = 186;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(159, 133);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(177, 22);
            this.txtNombre.TabIndex = 185;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(355, 70);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(49, 14);
            this.lblUsuario.TabIndex = 193;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(156, 116);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 14);
            this.lblNombre.TabIndex = 192;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(356, 116);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 14);
            this.lblApellido.TabIndex = 194;
            this.lblApellido.Text = "Apellido";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(804, 47);
            this.txtId.MaxLength = 32;
            this.txtId.Name = "txtId";
            this.txtId.ShortcutsEnabled = false;
            this.txtId.Size = new System.Drawing.Size(30, 22);
            this.txtId.TabIndex = 201;
            this.txtId.TabStop = false;
            this.txtId.Text = "0";
            this.txtId.Visible = false;
            // 
            // lblRebordes
            // 
            this.lblRebordes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRebordes.Location = new System.Drawing.Point(4, 40);
            this.lblRebordes.Name = "lblRebordes";
            this.lblRebordes.Size = new System.Drawing.Size(875, 187);
            this.lblRebordes.TabIndex = 198;
            this.lblRebordes.Visible = false;
            // 
            // lblSeccionUsuarios
            // 
            this.lblSeccionUsuarios.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblSeccionUsuarios.ForeColor = System.Drawing.Color.White;
            this.lblSeccionUsuarios.Location = new System.Drawing.Point(0, 3);
            this.lblSeccionUsuarios.Name = "lblSeccionUsuarios";
            this.lblSeccionUsuarios.Size = new System.Drawing.Size(190, 25);
            this.lblSeccionUsuarios.TabIndex = 92;
            this.lblSeccionUsuarios.Text = "Editar mi perfil";
            this.lblSeccionUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeccionUsuarios.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseDown);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Controls.Add(this.iconoSeccion);
            this.panelBarraTitulo.Controls.Add(this.lblSeccionUsuarios);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(883, 28);
            this.panelBarraTitulo.TabIndex = 206;
            this.panelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCerrar.BackgroundImage = global::CapaPresentacion.Properties.Resources.close_15x15;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 23;
            this.btnCerrar.Location = new System.Drawing.Point(845, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(38, 28);
            this.btnCerrar.TabIndex = 93;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // iconoSeccion
            // 
            this.iconoSeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.iconoSeccion.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.iconoSeccion.IconColor = System.Drawing.Color.White;
            this.iconoSeccion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconoSeccion.IconSize = 24;
            this.iconoSeccion.Location = new System.Drawing.Point(2, 2);
            this.iconoSeccion.Margin = new System.Windows.Forms.Padding(2);
            this.iconoSeccion.Name = "iconoSeccion";
            this.iconoSeccion.Size = new System.Drawing.Size(28, 24);
            this.iconoSeccion.TabIndex = 91;
            this.iconoSeccion.TabStop = false;
            this.iconoSeccion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseDown);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Enabled = false;
            this.txtNombreUsuario.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(358, 84);
            this.txtNombreUsuario.MaxLength = 32;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.ShortcutsEnabled = false;
            this.txtNombreUsuario.Size = new System.Drawing.Size(176, 22);
            this.txtNombreUsuario.TabIndex = 207;
            // 
            // lblConfirmarClave
            // 
            this.lblConfirmarClave.AutoSize = true;
            this.lblConfirmarClave.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarClave.Location = new System.Drawing.Point(356, 165);
            this.lblConfirmarClave.Name = "lblConfirmarClave";
            this.lblConfirmarClave.Size = new System.Drawing.Size(126, 14);
            this.lblConfirmarClave.TabIndex = 208;
            this.lblConfirmarClave.Text = "Confirmar contraseña";
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
            this.btnVerOcultarClave2.Location = new System.Drawing.Point(503, 182);
            this.btnVerOcultarClave2.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.btnVerOcultarClave2.Name = "btnVerOcultarClave2";
            this.btnVerOcultarClave2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnVerOcultarClave2.Size = new System.Drawing.Size(32, 22);
            this.btnVerOcultarClave2.TabIndex = 205;
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
            this.btnVerOcultarClave1.Location = new System.Drawing.Point(304, 182);
            this.btnVerOcultarClave1.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.btnVerOcultarClave1.Name = "btnVerOcultarClave1";
            this.btnVerOcultarClave1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnVerOcultarClave1.Size = new System.Drawing.Size(32, 22);
            this.btnVerOcultarClave1.TabIndex = 204;
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
            this.btnGuardarCambios.Location = new System.Drawing.Point(566, 174);
            this.btnGuardarCambios.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(144, 35);
            this.btnGuardarCambios.TabIndex = 190;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
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
            this.btnCambiarImagen.Location = new System.Drawing.Point(22, 169);
            this.btnCambiarImagen.Name = "btnCambiarImagen";
            this.btnCambiarImagen.Size = new System.Drawing.Size(115, 44);
            this.btnCambiarImagen.TabIndex = 187;
            this.btnCambiarImagen.Text = "Cambiar imagen";
            this.btnCambiarImagen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCambiarImagen.UseVisualStyleBackColor = false;
            this.btnCambiarImagen.Click += new System.EventHandler(this.btnCambiarImagen_Click);
            // 
            // iconoUsuario
            // 
            this.iconoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("iconoUsuario.Image")));
            this.iconoUsuario.Location = new System.Drawing.Point(22, 50);
            this.iconoUsuario.Name = "iconoUsuario";
            this.iconoUsuario.Size = new System.Drawing.Size(113, 113);
            this.iconoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconoUsuario.TabIndex = 200;
            this.iconoUsuario.TabStop = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(733, 117);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(45, 14);
            this.lblEstado.TabIndex = 212;
            this.lblEstado.Text = "Estado";
            // 
            // cboEstado
            // 
            this.cboEstado.BackColor = System.Drawing.SystemColors.Window;
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Enabled = false;
            this.cboEstado.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(736, 133);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(97, 22);
            this.cboEstado.TabIndex = 210;
            // 
            // cboRol
            // 
            this.cboRol.BackColor = System.Drawing.SystemColors.Window;
            this.cboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRol.Enabled = false;
            this.cboRol.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Location = new System.Drawing.Point(566, 133);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(144, 22);
            this.cboRol.TabIndex = 209;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuario.Location = new System.Drawing.Point(563, 116);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(92, 14);
            this.lblTipoUsuario.TabIndex = 211;
            this.lblTipoUsuario.Text = "Tipo de Usuario";
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(3, 229);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(877, 3);
            this.panelInferior.TabIndex = 214;
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 28);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(3, 204);
            this.panelIzquierdo.TabIndex = 215;
            // 
            // panelDerecho
            // 
            this.panelDerecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panelDerecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDerecho.Location = new System.Drawing.Point(880, 28);
            this.panelDerecho.Name = "panelDerecho";
            this.panelDerecho.Size = new System.Drawing.Size(3, 204);
            this.panelDerecho.TabIndex = 213;
            // 
            // frmEditarPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(883, 232);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.panelIzquierdo);
            this.Controls.Add(this.panelDerecho);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.cboRol);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.lblConfirmarClave);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.btnVerOcultarClave2);
            this.Controls.Add(this.txtConfirmarClave);
            this.Controls.Add(this.btnVerOcultarClave1);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.txtIdImagen);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.lblNumeroDocumento);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCambiarImagen);
            this.Controls.Add(this.iconoUsuario);
            this.Controls.Add(this.lblRebordes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditarPerfil";
            this.Load += new System.EventHandler(this.frmEditarPerfil_Load);
            this.panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconoSeccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnVerOcultarClave2;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private FontAwesome.Sharp.IconButton btnVerOcultarClave1;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private FontAwesome.Sharp.IconButton btnGuardarCambios;
        private System.Windows.Forms.TextBox txtIdImagen;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtId;
        private FontAwesome.Sharp.IconButton btnCambiarImagen;
        private System.Windows.Forms.PictureBox iconoUsuario;
        private System.Windows.Forms.Label lblRebordes;
        private FontAwesome.Sharp.IconPictureBox iconoSeccion;
        private System.Windows.Forms.Label lblSeccionUsuarios;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblConfirmarClave;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Panel panelDerecho;
    }
}