namespace CapaFormularios.Forms.FormUsuario
{
    partial class frmInicializarContrasena
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
            this.components = new System.ComponentModel.Container();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.lblInicializarContrasena = new System.Windows.Forms.Label();
            this.lblVerificaContrasena = new System.Windows.Forms.Label();
            this.txtContraNueva2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContraNueva1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblExplicacion = new System.Windows.Forms.Label();
            this.errorContrasena2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorContrasena1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnCambiarContrasena = new FontAwesome.Sharp.IconButton();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.iconInicializarContrasena = new FontAwesome.Sharp.IconPictureBox();
            this.btnVerContrasena1 = new FontAwesome.Sharp.IconButton();
            this.btnVerContrasena2 = new FontAwesome.Sharp.IconButton();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorContrasena2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContrasena1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconInicializarContrasena)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Controls.Add(this.lblInicializarContrasena);
            this.BarraTitulo.Controls.Add(this.iconInicializarContrasena);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(304, 28);
            this.BarraTitulo.TabIndex = 57;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // lblInicializarContrasena
            // 
            this.lblInicializarContrasena.AutoSize = true;
            this.lblInicializarContrasena.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicializarContrasena.ForeColor = System.Drawing.Color.White;
            this.lblInicializarContrasena.Location = new System.Drawing.Point(34, 6);
            this.lblInicializarContrasena.Name = "lblInicializarContrasena";
            this.lblInicializarContrasena.Size = new System.Drawing.Size(207, 19);
            this.lblInicializarContrasena.TabIndex = 90;
            this.lblInicializarContrasena.Text = "Inicializar Contraseña";
            this.lblInicializarContrasena.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // lblVerificaContrasena
            // 
            this.lblVerificaContrasena.AccessibleDescription = "";
            this.lblVerificaContrasena.AutoSize = true;
            this.lblVerificaContrasena.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerificaContrasena.ForeColor = System.Drawing.Color.Red;
            this.lblVerificaContrasena.Location = new System.Drawing.Point(16, 134);
            this.lblVerificaContrasena.Name = "lblVerificaContrasena";
            this.lblVerificaContrasena.Size = new System.Drawing.Size(110, 13);
            this.lblVerificaContrasena.TabIndex = 64;
            this.lblVerificaContrasena.Text = "Contraseña Insegura";
            this.lblVerificaContrasena.Visible = false;
            // 
            // txtContraNueva2
            // 
            this.txtContraNueva2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraNueva2.ForeColor = System.Drawing.Color.Black;
            this.txtContraNueva2.Location = new System.Drawing.Point(21, 172);
            this.txtContraNueva2.MaxLength = 32;
            this.txtContraNueva2.Name = "txtContraNueva2";
            this.txtContraNueva2.ShortcutsEnabled = false;
            this.txtContraNueva2.Size = new System.Drawing.Size(203, 23);
            this.txtContraNueva2.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(17, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 61;
            this.label5.Text = "Repetir Contraseña";
            // 
            // txtContraNueva1
            // 
            this.txtContraNueva1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraNueva1.ForeColor = System.Drawing.Color.Black;
            this.txtContraNueva1.Location = new System.Drawing.Point(18, 107);
            this.txtContraNueva1.MaxLength = 32;
            this.txtContraNueva1.Name = "txtContraNueva1";
            this.txtContraNueva1.ShortcutsEnabled = false;
            this.txtContraNueva1.Size = new System.Drawing.Size(206, 23);
            this.txtContraNueva1.TabIndex = 58;
            this.txtContraNueva1.TextChanged += new System.EventHandler(this.txtContraNueva1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 15);
            this.label4.TabIndex = 59;
            this.label4.Text = "Contraseña Nueva";
            // 
            // lblExplicacion
            // 
            this.lblExplicacion.AutoSize = true;
            this.lblExplicacion.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacion.ForeColor = System.Drawing.Color.Black;
            this.lblExplicacion.Location = new System.Drawing.Point(10, 40);
            this.lblExplicacion.Name = "lblExplicacion";
            this.lblExplicacion.Size = new System.Drawing.Size(13, 15);
            this.lblExplicacion.TabIndex = 65;
            this.lblExplicacion.Text = "*";
            // 
            // errorContrasena2
            // 
            this.errorContrasena2.ContainerControl = this;
            // 
            // errorContrasena1
            // 
            this.errorContrasena1.ContainerControl = this;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCancelar.IconColor = System.Drawing.Color.White;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 30;
            this.btnCancelar.Location = new System.Drawing.Point(21, 215);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 30);
            this.btnCancelar.TabIndex = 67;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCambiarContrasena
            // 
            this.btnCambiarContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnCambiarContrasena.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiarContrasena.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCambiarContrasena.FlatAppearance.BorderSize = 2;
            this.btnCambiarContrasena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarContrasena.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarContrasena.ForeColor = System.Drawing.Color.White;
            this.btnCambiarContrasena.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCambiarContrasena.IconColor = System.Drawing.Color.White;
            this.btnCambiarContrasena.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCambiarContrasena.IconSize = 30;
            this.btnCambiarContrasena.Location = new System.Drawing.Point(167, 215);
            this.btnCambiarContrasena.Name = "btnCambiarContrasena";
            this.btnCambiarContrasena.Size = new System.Drawing.Size(111, 30);
            this.btnCambiarContrasena.TabIndex = 66;
            this.btnCambiarContrasena.Text = "Aceptar";
            this.btnCambiarContrasena.UseVisualStyleBackColor = false;
            this.btnCambiarContrasena.Click += new System.EventHandler(this.btnCambiarContrasena_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 23;
            this.btnCerrar.Location = new System.Drawing.Point(266, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(38, 28);
            this.btnCerrar.TabIndex = 91;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // iconInicializarContrasena
            // 
            this.iconInicializarContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iconInicializarContrasena.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconInicializarContrasena.IconColor = System.Drawing.Color.White;
            this.iconInicializarContrasena.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconInicializarContrasena.IconSize = 28;
            this.iconInicializarContrasena.Location = new System.Drawing.Point(5, 2);
            this.iconInicializarContrasena.Margin = new System.Windows.Forms.Padding(2);
            this.iconInicializarContrasena.Name = "iconInicializarContrasena";
            this.iconInicializarContrasena.Size = new System.Drawing.Size(37, 28);
            this.iconInicializarContrasena.TabIndex = 89;
            this.iconInicializarContrasena.TabStop = false;
            this.iconInicializarContrasena.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // btnVerContrasena1
            // 
            this.btnVerContrasena1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnVerContrasena1.FlatAppearance.BorderSize = 2;
            this.btnVerContrasena1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerContrasena1.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnVerContrasena1.IconColor = System.Drawing.Color.Black;
            this.btnVerContrasena1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerContrasena1.IconSize = 32;
            this.btnVerContrasena1.Location = new System.Drawing.Point(242, 104);
            this.btnVerContrasena1.Name = "btnVerContrasena1";
            this.btnVerContrasena1.Size = new System.Drawing.Size(36, 30);
            this.btnVerContrasena1.TabIndex = 69;
            this.btnVerContrasena1.UseVisualStyleBackColor = true;
            // 
            // btnVerContrasena2
            // 
            this.btnVerContrasena2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnVerContrasena2.FlatAppearance.BorderSize = 2;
            this.btnVerContrasena2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerContrasena2.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnVerContrasena2.IconColor = System.Drawing.Color.Black;
            this.btnVerContrasena2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerContrasena2.IconSize = 32;
            this.btnVerContrasena2.Location = new System.Drawing.Point(242, 169);
            this.btnVerContrasena2.Name = "btnVerContrasena2";
            this.btnVerContrasena2.Size = new System.Drawing.Size(36, 30);
            this.btnVerContrasena2.TabIndex = 70;
            this.btnVerContrasena2.UseVisualStyleBackColor = true;
            // 
            // frmInicializarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 256);
            this.Controls.Add(this.btnVerContrasena2);
            this.Controls.Add(this.btnVerContrasena1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCambiarContrasena);
            this.Controls.Add(this.lblExplicacion);
            this.Controls.Add(this.lblVerificaContrasena);
            this.Controls.Add(this.txtContraNueva2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtContraNueva1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BarraTitulo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmInicializarContrasena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInicializarContrasena";
            this.Load += new System.EventHandler(this.frmInicializarContrasena_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorContrasena2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContrasena1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconInicializarContrasena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label lblInicializarContrasena;
        private FontAwesome.Sharp.IconPictureBox iconInicializarContrasena;
        private System.Windows.Forms.Label lblVerificaContrasena;
        private System.Windows.Forms.TextBox txtContraNueva2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContraNueva1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblExplicacion;
        private FontAwesome.Sharp.IconButton btnCambiarContrasena;
        private System.Windows.Forms.ErrorProvider errorContrasena2;
        private System.Windows.Forms.ErrorProvider errorContrasena1;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnVerContrasena1;
        private FontAwesome.Sharp.IconButton btnVerContrasena2;
    }
}