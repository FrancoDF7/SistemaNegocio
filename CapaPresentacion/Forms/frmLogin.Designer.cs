namespace CapaPresentacion.Forms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.piclogonegocio = new System.Windows.Forms.PictureBox();
            this.lblnombrenegocio = new System.Windows.Forms.Label();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.panelImagen = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblErrorLogin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btniniciarsesion = new FontAwesome.Sharp.IconButton();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogonegocio)).BeginInit();
            this.panelImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelBarraTitulo.Controls.Add(this.piclogonegocio);
            this.panelBarraTitulo.Controls.Add(this.lblnombrenegocio);
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(526, 28);
            this.panelBarraTitulo.TabIndex = 19;
            this.panelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseDown);
            // 
            // piclogonegocio
            // 
            this.piclogonegocio.Image = ((System.Drawing.Image)(resources.GetObject("piclogonegocio.Image")));
            this.piclogonegocio.Location = new System.Drawing.Point(3, 3);
            this.piclogonegocio.Name = "piclogonegocio";
            this.piclogonegocio.Size = new System.Drawing.Size(25, 25);
            this.piclogonegocio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogonegocio.TabIndex = 49;
            this.piclogonegocio.TabStop = false;
            // 
            // lblnombrenegocio
            // 
            this.lblnombrenegocio.AutoSize = true;
            this.lblnombrenegocio.BackColor = System.Drawing.Color.Transparent;
            this.lblnombrenegocio.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombrenegocio.ForeColor = System.Drawing.Color.White;
            this.lblnombrenegocio.Location = new System.Drawing.Point(32, 5);
            this.lblnombrenegocio.Name = "lblnombrenegocio";
            this.lblnombrenegocio.Size = new System.Drawing.Size(109, 23);
            this.lblnombrenegocio.TabIndex = 50;
            this.lblnombrenegocio.Text = "Mi Negocio";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 23;
            this.btnCerrar.Location = new System.Drawing.Point(488, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(38, 28);
            this.btnCerrar.TabIndex = 44;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(231, 86);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(257, 23);
            this.txtusuario.TabIndex = 47;
            this.txtusuario.Text = "Franco123";
            // 
            // txtclave
            // 
            this.txtclave.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclave.Location = new System.Drawing.Point(231, 140);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(257, 23);
            this.txtclave.TabIndex = 48;
            this.txtclave.Text = "123";
            // 
            // panelImagen
            // 
            this.panelImagen.Controls.Add(this.pictureBox1);
            this.panelImagen.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelImagen.Location = new System.Drawing.Point(0, 28);
            this.panelImagen.Name = "panelImagen";
            this.panelImagen.Size = new System.Drawing.Size(195, 209);
            this.panelImagen.TabIndex = 49;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 124;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 50;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = "Contraseña";
            // 
            // lblErrorLogin
            // 
            this.lblErrorLogin.AutoSize = true;
            this.lblErrorLogin.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorLogin.ForeColor = System.Drawing.Color.Black;
            this.lblErrorLogin.Location = new System.Drawing.Point(230, 167);
            this.lblErrorLogin.Name = "lblErrorLogin";
            this.lblErrorLogin.Size = new System.Drawing.Size(64, 15);
            this.lblErrorLogin.TabIndex = 53;
            this.lblErrorLogin.Text = "ErrorLogin";
            this.lblErrorLogin.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 54;
            this.label3.Text = "Inicio de Sesión";
            // 
            // btniniciarsesion
            // 
            this.btniniciarsesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btniniciarsesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btniniciarsesion.FlatAppearance.BorderSize = 2;
            this.btniniciarsesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btniniciarsesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btniniciarsesion.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniniciarsesion.ForeColor = System.Drawing.Color.White;
            this.btniniciarsesion.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btniniciarsesion.IconColor = System.Drawing.Color.White;
            this.btniniciarsesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btniniciarsesion.IconSize = 25;
            this.btniniciarsesion.Location = new System.Drawing.Point(293, 189);
            this.btniniciarsesion.Name = "btniniciarsesion";
            this.btniniciarsesion.Size = new System.Drawing.Size(151, 34);
            this.btniniciarsesion.TabIndex = 123;
            this.btniniciarsesion.Text = "Iniciar Sesión";
            this.btniniciarsesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btniniciarsesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btniniciarsesion.UseVisualStyleBackColor = false;
            this.btniniciarsesion.Click += new System.EventHandler(this.btniniciarsesion_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(526, 237);
            this.Controls.Add(this.btniniciarsesion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblErrorLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelImagen);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.panelBarraTitulo);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogonegocio)).EndInit();
            this.panelImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraTitulo;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Panel panelImagen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblErrorLogin;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btniniciarsesion;
        private System.Windows.Forms.PictureBox piclogonegocio;
        private System.Windows.Forms.Label lblnombrenegocio;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}