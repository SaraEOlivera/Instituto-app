using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "") 
            {
                txtUsuario.Text = "Usuario";
            }
        }

        private void txtClave_Enter(object sender, EventArgs e)
        {
            if (txtClave.Text == "Contraseña") 
            {
                txtClave.Text = "";
                txtClave.UseSystemPasswordChar = true;
            }
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text == "") 
            {
                txtClave.Text = "Contraseña";
                txtClave.UseSystemPasswordChar = false;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable();
            Datos.Usuarios dato = new Datos.Usuarios();

            tablaLogin = dato.LoginUsuario(txtUsuario.Text, txtClave.Text);
            if (tablaLogin.Rows.Count > 0)
            {
                MessageBox.Show("Ingreso exitoso");
                formPrincipal frmPrincipal = new formPrincipal();
                frmPrincipal.rol = Convert.ToString(tablaLogin.Rows[0][0]);
                frmPrincipal.usuario = Convert.ToString(txtUsuario.Text);
                frmPrincipal.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Usuario y/o clave incorrecto");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }




        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


    }
}
