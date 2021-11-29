using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico
{
    public partial class Inversiones : Form
    {
        public Inversiones()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_Click(object sender, EventArgs e)
        {
            linea.FillColor = Color.FromArgb(51, 168, 161);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            linea.FillColor = Color.FromArgb(51, 168, 161);
            lblTodoSaldo.Visible = true;
        }

        private void guna2TextBox1_MouseLeave(object sender, EventArgs e)
        {
            linea.FillColor = Color.FromArgb(112, 43, 254);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            lblTodoSaldo.Visible = false;
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
