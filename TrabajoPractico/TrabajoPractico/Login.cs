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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        static string PathUsuarios = ConfigurationManager.AppSettings["PathUsuarios"];
        bool  Existe=false;

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Hide();
        }

        private void mensajeError()
        {

        }


        /*  private void btnLogin_Click(object sender, EventArgs e)
          {

              string LineaUsuario = "";



                  StreamReader srUsuarios = new StreamReader(PathUsuarios);

                  CuentaPerfil frm =new CuentaPerfil();

                  LineaUsuario = srUsuarios.ReadLine();


                  while (LineaUsuario != null)
                  {
                      string[] Usuarios = LineaUsuario.Split(',');

                      if (Usuarios[0]==txtUsuario.Text && Usuarios[1]==txtClave.Text)
                      {
                          frm.Apellido=Usuarios[3];
                          frm.Nombre=Usuarios[2];
                          frm.Usuario=Usuarios[0];
                          frm.Tipo=Usuarios[4];
                          frm.Foto=Usuarios[5];
                          Existe = true;
                          break;
                      }
                      LineaUsuario = srUsuarios.ReadLine();

                  }

                  if (!Existe)
                  {
                      MessageBoxButtons buttons = MessageBoxButtons.OK;
                      DialogResult result;


                      result = MessageBox.Show("Usuario Inexistente", "Login", buttons);


                      return;

                  }
                  else
                  {
                      frm.Show();
                  }

  */

    }
}
