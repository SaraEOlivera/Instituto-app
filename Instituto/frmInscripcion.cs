using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Instituto.Entidades;

namespace Instituto
{
    public partial class frmInscripcion : Form
    {
        public frmInscripcion()
        {
            InitializeComponent();
        }

        private void frmInscripcion_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formPrincipal principal = new formPrincipal();
            principal.Show();
            this.Hide();
        }

        private void btnIngresarPostulante_Click(object sender, EventArgs e)
        {
            if (txtNombrePostulante.Text == "" || txtApellidoPostulante.Text == "" || txtDocumentoPostulante.Text == "" || cboTipoPostulante.Text == "") 
            {
                MessageBox.Show("Debe completar datos requeridos (*) ", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string respuesta;
                E_Postulante nuevoPostulante = new E_Postulante();
                nuevoPostulante.NombrePost = txtNombrePostulante.Text;
                nuevoPostulante.ApellidoPost = txtApellidoPostulante.Text;
                nuevoPostulante.DocumentoPost = Convert.ToInt32(txtDocumentoPostulante.Text);
                nuevoPostulante.TipoDocuPost = cboTipoPostulante.Text;

                Datos.Postulantes postulantes = new Datos.Postulantes();
                respuesta = postulantes.NuevoPost(nuevoPostulante);

                bool esNumero = int.TryParse(respuesta, out int codigo);
                if (esNumero) 
                {
                    if (codigo == 1) 
                    {
                        MessageBox.Show("El postulante ya existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("El postulante se almacenó con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombrePostulante.Text = "";
            txtApellidoPostulante.Text = "";
            txtDocumentoPostulante.Text = "";
            cboTipoPostulante.Text = "";
            txtNombrePostulante.Focus();
        }




        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
