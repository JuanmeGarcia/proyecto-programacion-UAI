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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            abrirFormHijo(new Panel());
        }
        Form activeForm = null;
        public void abrirFormHijo(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(childForm);
            panelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void esconderPanel()
        {
            if (panelSubMenuDinero.Visible)
                panelSubMenuDinero.Visible = false;
        }

        private void mostarPanel(Guna.UI2.WinForms.Guna2Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                esconderPanel();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            mostarPanel(panelSubMenuDinero);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //abrir formulario
            abrirFormHijo(new Perfil());
            esconderPanel();
        }


        private void guna2Button11_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Panel());
            esconderPanel();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Inversiones());

            esconderPanel();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            //abri formulario 
            abrirFormHijo(new Billetera());

            esconderPanel();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Movimientos());
            esconderPanel();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            if(MsgCerrarSesion.Show("Desea cerrar sesion") == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Panel());
        }
    }
}
