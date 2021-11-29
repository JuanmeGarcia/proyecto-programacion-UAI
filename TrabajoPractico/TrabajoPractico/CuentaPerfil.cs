using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;


namespace TrabajoPractico
{
    public partial class CuentaPerfil : Form
    {
        public CuentaPerfil()
        {
            InitializeComponent();
        }
        public string Nombre;
        public string Apellido;
        public string Tipo;
        public string Usuario;
        public string Foto;
        
        private void CuentaPerfil_Load(object sender, EventArgs e)
        {
            lblApellido.Text = Apellido;
            lblNombre.Text = Nombre;
            lblTipoUsuario.Text = Usuario;
            lblUsuario.Text = Usuario;

            pPerfil.Image = Image.FromFile(Foto);


        }

        private void pPerfil_Click(object sender, EventArgs e)
        {

        }
    }
}
