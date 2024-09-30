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

namespace CapaPresentacion.MessageBoxCustom
{
    public partial class MessageBoxCustom : Form
    {
        //public MessageBoxCustom()
        //{
        //    InitializeComponent();
        //}

        //Campos
        private Color primaryColor = Color.CornflowerBlue;
        private int borderSize = 1;

        //Propiedades
        //public Color PrimaryColor
        //{
        //    get { return primaryColor; }
        //    set
        //    {
        //        primaryColor = value;
        //        this.BackColor = primaryColor; //Color de borde del form
        //        this.panelTitleBar.BackColor = primaryColor; //Color de fondo del la barra de titulo
        //    }
        //}

        //Constructores
        public MessageBoxCustom(string textoMensaje)
        {
            InitializeComponent();
            InitializeItems();
            this.labelMessage.Text = textoMensaje;
            this.labelCaption.Text = "";
            SetFormSize(); //Ajusta el tamaño del formulario
            SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1); //Selecciona el boton predeterminado
        }

        public MessageBoxCustom(string textoMensaje, string textoTitulo)
        {
            InitializeComponent();
            InitializeItems();
            this.labelMessage.Text = textoMensaje;
            this.labelCaption.Text = textoTitulo;
            SetFormSize(); //Ajusta el tamaño del formulario
            SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1); //Selecciona el boton predeterminado
        }

        public MessageBoxCustom(string textoMensaje, string textoTitulo, MessageBoxButtons buttons)
        {
            InitializeComponent();
            InitializeItems();
            this.labelMessage.Text = textoMensaje;
            this.labelCaption.Text = textoTitulo;
            SetFormSize(); //Ajusta el tamaño del formulario
            SetButtons(buttons, MessageBoxDefaultButton.Button1); //Selecciona el boton predeterminado
        }

        public MessageBoxCustom(string textoMensaje, string textoTitulo, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            InitializeComponent();
            InitializeItems();
            this.labelMessage.Text = textoMensaje;
            this.labelCaption.Text = textoTitulo;
            SetFormSize();
            SetButtons(buttons, MessageBoxDefaultButton.Button1);//Set [Default Button 1]
            SetIcon(icon);
        }
        public MessageBoxCustom(string textoMensaje, string textoTitulo, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            InitializeComponent();
            InitializeItems();
            this.labelMessage.Text = textoMensaje;
            this.labelCaption.Text = textoTitulo;
            SetFormSize();
            SetButtons(buttons, defaultButton);
            SetIcon(icon);
        }

        #region Metodos

        //Establece el valor predeterminado de los items del formulario
        private void InitializeItems()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize); //Establece el tamaño del borde
            this.labelMessage.MaximumSize = new Size(550, 0);
            this.btnClose.DialogResult = DialogResult.Cancel;
            this.button1.DialogResult = DialogResult.OK;
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button3.Visible = false;
        }

        //Establece el tamaño del formulario segun el tamaño de los items
        private void SetFormSize()
        {
            int widht = this.labelMessage.Width + this.pictureBoxIcon.Width + this.panelBody.Padding.Left;
            int height = this.panelTitleBar.Height + this.labelMessage.Height + this.panelButtons.Height + this.panelBody.Padding.Top;
            this.Size = new Size(widht, height);
        }

        private void SetButtons(MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton)
        {
            int xCenter = (this.panelButtons.Width - button1.Width) / 2;
            int yCenter = (this.panelButtons.Height - button1.Height) / 2;

            switch (buttons)
            {

                case MessageBoxButtons.OK:
                    button1.Visible = true;
                    button1.Location = new Point(xCenter, yCenter);
                    button1.Text = "OK";
                    button1.DialogResult = DialogResult.OK;
                    break;


                case MessageBoxButtons.OKCancel:
                    //OK Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - (button1.Width / 2) - 5, yCenter);
                    button1.Text = "Aceptar";
                    button1.DialogResult = DialogResult.OK; //DialogResult = OK
                    //Cancel Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter + (button2.Width / 2) + 5, yCenter);
                    button2.Text = "Cancelar";
                    button2.DialogResult = DialogResult.Cancel;//DialogResult = Cancel
                    button2.BackColor = Color.DimGray;
                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//Solo hay 2 botones, por lo que el botón predeterminado no puede ser Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;


                case MessageBoxButtons.RetryCancel:
                    //Retry Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - (button1.Width / 2) - 5, yCenter);
                    button1.Text = "Reintentar";
                    button1.DialogResult = DialogResult.Retry;//DialogResult = Retry

                    button2.Visible = true;
                    button2.Location = new Point(xCenter + (button2.Width / 2) + 5, yCenter);
                    button2.Text = "Cancelar";
                    button2.DialogResult = DialogResult.Cancel;//DialogResult = Cancel
                    button2.BackColor = Color.DimGray;
                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//Solo hay 2 botones, por lo que el botón predeterminado no puede ser Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;


                case MessageBoxButtons.YesNo:
                    //Yes Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - (button1.Width / 2) - 5, yCenter);
                    button1.Text = "Si";
                    button1.DialogResult = DialogResult.Yes;//Set DialogResult
                                                            //No Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter + (button2.Width / 2) + 5, yCenter);
                    button2.Text = "No";
                    button2.DialogResult = DialogResult.No;//Set DialogResult
                    button2.BackColor = Color.IndianRed;
                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;


                case MessageBoxButtons.YesNoCancel:
                    //Yes Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - button1.Width - 5, yCenter);
                    button1.Text = "Si";
                    button1.DialogResult = DialogResult.Yes;//Set DialogResult
                                                            //No Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter, yCenter);
                    button2.Text = "No";
                    button2.DialogResult = DialogResult.No;//Set DialogResult
                    button2.BackColor = Color.IndianRed;
                    //Cancel Button
                    button3.Visible = true;
                    button3.Location = new Point(xCenter + button2.Width + 5, yCenter);
                    button3.Text = "Cancelar";
                    button3.DialogResult = DialogResult.Cancel;//Set DialogResult
                    button3.BackColor = Color.DimGray;
                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;


                case MessageBoxButtons.AbortRetryIgnore:
                    //Abort Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - button1.Width - 5, yCenter);
                    button1.Text = "Abortar";
                    button1.DialogResult = DialogResult.Abort;//Set DialogResult
                    button1.BackColor = Color.Goldenrod;
                    //Retry Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter, yCenter);
                    button2.Text = "Reintentar";
                    button2.DialogResult = DialogResult.Retry;//Set DialogResult                    
                                                              //Ignore Button
                    button3.Visible = true;
                    button3.Location = new Point(xCenter + button2.Width + 5, yCenter);
                    button3.Text = "Ignorar";
                    button3.DialogResult = DialogResult.Ignore;//Set DialogResult
                    button3.BackColor = Color.IndianRed;
                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;

            }

        }

        //Establece el boton prederminado al que se le hace foco
        private void SetDefaultButton(MessageBoxDefaultButton defaultButton)
        {
            switch (defaultButton)
            {
                case MessageBoxDefaultButton.Button1:
                    button1.Select();
                    button1.ForeColor = Color.White;
                    button1.Font = new Font(button1.Font, FontStyle.Underline);
                    break;

                case MessageBoxDefaultButton.Button2:
                    button2.Select();
                    button2.ForeColor = Color.White;
                    button2.Font = new Font(button2.Font, FontStyle.Underline);
                    break;

                case MessageBoxDefaultButton.Button3:
                    button3.Select();
                    button3.ForeColor = Color.White;
                    button3.Font = new Font(button3.Font, FontStyle.Underline);
                    break;
            }
        }

        private void SetIcon(MessageBoxIcon icon)
        {
            switch (icon)
            {
                case MessageBoxIcon.Error:
                    this.pictureBoxIcon.Image = Properties.Resources.error_icon_40x42;
                    //PrimaryColor = Color.FromArgb(231, 76, 60);
                    this.btnClose.FlatAppearance.MouseOverBackColor = Color.Crimson;
                    break;

                case MessageBoxIcon.Information:
                    this.pictureBoxIcon.Image = Properties.Resources.information_icon_40x40;
                    //PrimaryColor = Color.FromArgb(33, 150, 243);
                    break;

                case MessageBoxIcon.Question:
                    this.pictureBoxIcon.Image = Properties.Resources.question_icon_40x42;
                    //PrimaryColor = Color.FromArgb(52, 152, 219);
                    break;

                case MessageBoxIcon.Exclamation:
                    this.pictureBoxIcon.Image = Properties.Resources.question_icon_40x42;
                    //PrimaryColor = Color.FromArgb(255, 182, 54);
                    break;

                case MessageBoxIcon.None:
                    this.pictureBoxIcon.Image = Properties.Resources.check20;
                    //PrimaryColor = Color.CornflowerBlue;
                    break;
            }
        }

        #endregion

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            MoverForm.MoverFormulario(this.Handle);
        }
    }
}
