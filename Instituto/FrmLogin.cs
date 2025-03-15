using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Datos;


namespace Instituto
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario") 
            {
                txtUsuario.Text = "";   
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text)) 
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtClave_Enter(object sender, EventArgs e)
        {
            if (txtClave.Text == "Contraseña") 
            {
                txtClave.Text = "";
                txtClave.UseSystemPasswordChar = true;
                txtClave.ForeColor = Color.Black;
            }
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClave.Text)) 
            {
                txtClave.Text = "Contraseña";
                txtClave.ForeColor = Color.Gray;
                txtClave.UseSystemPasswordChar = false;
            }
        }




        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
