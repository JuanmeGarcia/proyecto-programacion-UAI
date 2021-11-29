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
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            dashboard.abrirFormHijo(new Depositar());
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            Dialog.Show("Este balance incluye pesos y divisa extranjera");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            dashboard.abrirFormHijo(new Billetera());
            
        }
    }
}
