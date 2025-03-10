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
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }
        internal string rol;
        internal string usuario;


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = $"Usuario {usuario} ({rol})";
        }

        private void btnInscribirPostulante_Click(object sender, EventArgs e)
        {
            frmInscripcion inscripcion = new frmInscripcion();
            inscripcion.Show();
            this.Hide();
        }

        private void btnAsignarCurso_Click(object sender, EventArgs e)
        {
            frmAsignar asignacion = new frmAsignar();
            asignacion.Show();
            this.Hide();
        }
    }
}
