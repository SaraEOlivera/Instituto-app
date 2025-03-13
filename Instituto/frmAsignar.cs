using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Instituto.Datos;

namespace Instituto
{
    public partial class frmAsignar : Form
    {
        public frmAsignar()
        {
            InitializeComponent();
        }

        private void frmAsignar_Load(object sender, EventArgs e)
        {
            cargaGrilla();
        }

        public void cargaGrilla()
        {
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                string query;
                sqlConnection = Conexion.getInstancia().crearConexion();
                query = "Select C.Nombre, E.fecha, CONCAT(D.NombreDoc,'',D.ApellidoDoc) as Docente, C.precio from curso C inner join edicion E on C.NumCurso = E.NumCurso inner join docente D on E.NumeroDoc = D.NumeroDoc  order by C.Nombre";
                //antes del order by iba : where E.fecha > GETDATE()
                SqlCommand comando = new SqlCommand(query, sqlConnection);
                comando.CommandType = CommandType.Text;
                sqlConnection.Open();

                SqlDataReader lector;
                lector = comando.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        int renglon = dtgvCurso.Rows.Add();
                        dtgvCurso.Rows[renglon].Cells[0].Value = lector.GetString(0);
                        dtgvCurso.Rows[renglon].Cells[1].Value = lector.GetString(1);
                        dtgvCurso.Rows[renglon].Cells[2].Value = lector.GetString(2);
                        dtgvCurso.Rows[renglon].Cells[3].Value = lector.GetString(3);
                    }

                }
                else
                {
                    MessageBox.Show("No hay datos para la carga de la grilla");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }



        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
