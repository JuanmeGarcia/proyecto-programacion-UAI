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
    public partial class Billetera : Form
    {
        public Billetera()
        {
            InitializeComponent();
            mostrarPorcentajes();
        }

        private void mostrarPorcentajes()
        {
            chartDinero.Series["s1"].Points.AddXY("Pesos", "300");
            chartDinero.Series["s1"].Points.AddXY("Dolares", "300");
            chartDinero.Series["s1"].Points.AddXY("Euros", "300");

            chartDinero.Series["s1"].IsValueShownAsLabel = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            dashboard.abrirFormHijo(new Depositar());
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            dashboard.abrirFormHijo(new Retirar());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            dashboard.abrirFormHijo(new Comprar());
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            dashboard.abrirFormHijo(new Comprar());
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            dashboard.abrirFormHijo(new Vender());
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            dashboard.abrirFormHijo(new Vender());
        }
    }
}
