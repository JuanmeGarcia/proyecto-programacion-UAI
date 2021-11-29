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
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
        }
        // muestra el boton de cancelar cuando hay texto y lo posiciona arriba
        //sino, lo mantiene oculto.
        private void mostrarBoton(Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            if(textBox.Text != "")
            {
                btnCancelar.Visible = true;
                btnCancelar.Dock = DockStyle.Top;
                btnAceptar.Dock = DockStyle.Bottom;
            }
            else
            {
                btnCancelar.Visible = false;
                btnCancelar.Dock = DockStyle.Bottom;
                btnAceptar.Dock = DockStyle.Top;
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            mostrarBoton(guna2TextBox1);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Clear();
        }
    }
}
