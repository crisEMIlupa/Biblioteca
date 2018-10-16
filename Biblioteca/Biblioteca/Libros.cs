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
    public partial class Libros : Form
    {
        bool vacio;
        bool esTesis;
        BaseDatos baseDatos;

        public Libros(bool b)
        {
            InitializeComponent();
            baseDatos = new BaseDatos();
            esTesis = b;

            textBox1.GotFocus += RemovePlaceholder;
            textBox1.LostFocus += AddPlaceholder;
            textBox1.TextChanged += VacioPlaceholder;
            textBox1.ForeColor = System.Drawing.Color.Gray;
            if(esTesis)
            {
                textBox1.Text = "Que tesis desea buscar?";
            }else
            {
                textBox1.Text = "Que libro desea buscar?";
            }
            vacio = true;

            this.ActiveControl = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(esTesis)
            {
                baseDatos.buscarLibros(textBox1.Text);
            }else
            {
                baseDatos.buscarTesis(textBox1.Text);
            }
        }

        public void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox textBoxSender = (TextBox)sender;
            if (vacio)
            {
                textBoxSender.Text = "";
                textBoxSender.ForeColor = System.Drawing.Color.Black;
            }
            else { }
        }
        public void AddPlaceholder(object sender, EventArgs e)
        {
            TextBox textBoxSender = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBoxSender.Text))
            {
                if (esTesis)
                {
                    textBox1.Text = "Que tesis desea buscar?";
                }
                else
                {
                    textBox1.Text = "Que libro desea buscar?";
                }
                textBoxSender.ForeColor = System.Drawing.Color.Gray;
                vacio = true;
            }
            else { }
        }
        public void VacioPlaceholder(object sender, EventArgs e)
        {
            TextBox textBoxSender = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBoxSender.Text))
            {
                vacio = true;
            }
            else
            {
                vacio = false;
            }
        }
    }
}
