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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Libros vista = new Libros(false);
            vista.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login vista = new Login();
            vista.Visible = true;
        }

        private void tesisButton_Click(object sender, EventArgs e)
        {
            Libros vista = new Libros(true);
            vista.Visible = true;
        }
    }
}
