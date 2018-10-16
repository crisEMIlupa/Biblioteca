using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Login : Form
    {
        bool codigoVacio;
        bool contraseñaVacio;
        LoginControlador logincontrolador;

        public Login()
        {
            InitializeComponent();
            logincontrolador = new LoginControlador();
            codigoVacio = true;
            contraseñaVacio = true;
            label1.ForeColor = System.Drawing.Color.Red;

            codigoTextBox.GotFocus += RemovePlaceholderCodigo;
            codigoTextBox.LostFocus += AddPlaceholderCodigo;
            codigoTextBox.TextChanged += VacioPlaceholderCodigo;
            codigoTextBox.ForeColor = System.Drawing.Color.Gray;

            contraseñaTextBox.GotFocus += RemovePlaceholderContraseña;
            contraseñaTextBox.LostFocus += AddPlaceholderContraseña;
            contraseñaTextBox.TextChanged += VacioPlaceholderContraseña;
            contraseñaTextBox.ForeColor = System.Drawing.Color.Gray;

            this.ActiveControl = ingresarButton;
        }

        private void ingresarButton_Click(object sender, EventArgs e)
        {
            bool exito = logincontrolador.login(codigoTextBox.Text, contraseñaTextBox.Text);
            if(exito)
            {
                //
            }else
            {
                label1.Text = "Codigo o Contraseña invalidos";
            }
        }

        public void RemovePlaceholderCodigo(object sender, EventArgs e)
        {
            TextBox textBoxSender = (TextBox)sender;
            if (codigoVacio)
            {
                textBoxSender.Text = "";
                textBoxSender.ForeColor = System.Drawing.Color.Black;
            }
            else { }
        }
        public void AddPlaceholderCodigo(object sender, EventArgs e)
        {
            TextBox textBoxSender = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBoxSender.Text))
            {
                textBoxSender.Text = "Usuario";
                textBoxSender.ForeColor = System.Drawing.Color.Gray;
                codigoVacio = true;
            }
            else { }
        }
        public void VacioPlaceholderCodigo(object sender, EventArgs e)
        {
            TextBox textBoxSender = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBoxSender.Text))
            {
                codigoVacio = true;
            }
            else
            {
                codigoVacio = false;
            }
        }

        public void RemovePlaceholderContraseña(object sender, EventArgs e)
        {
            TextBox textBoxSender = (TextBox)sender;
            if (contraseñaVacio)
            {
                textBoxSender.Text = "";
                textBoxSender.ForeColor = System.Drawing.Color.Black;
            }
            else { }
        }
        public void AddPlaceholderContraseña(object sender, EventArgs e)
        {
            TextBox textBoxSender = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBoxSender.Text))
            {
                textBoxSender.Text = "Contraseña";
                textBoxSender.ForeColor = System.Drawing.Color.Gray;
                contraseñaVacio = true;
            }
            else { }
        }
        public void VacioPlaceholderContraseña(object sender, EventArgs e)
        {
            TextBox textBoxSender = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBoxSender.Text))
            {
                contraseñaVacio = true;
            }
            else
            {
                contraseñaVacio = false;
            }
        }
    }
}
