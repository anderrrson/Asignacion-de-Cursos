using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace ADMINISTRADORES
{
    public partial class FmInscripcion : Form
    {
        FmBoletaInscripcion A = new FmBoletaInscripcion();
        ConexionBD conexion = new ConexionBD();
        Panel PnlEscritorio;
        public FmInscripcion(Panel PnlPricipal)
        {
            PnlEscritorio = PnlPricipal;
            InitializeComponent();
        }

        FmBoletaInscripcion transferir = new FmBoletaInscripcion();
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
            A.Show();
        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        FmBoletaInscripcion trasladar = new FmBoletaInscripcion();

        private void Button1_Click(object sender, EventArgs e)
        {
            /* if (this.PnlEscritorio.Controls.Count > 0)
                 this.PnlEscritorio.Controls.RemoveAt(0);

             Form formulario = new FmBoletaInscripcion() as Form; //Convierte Formulario a Formulario Interno
             formulario.TopLevel = false;
             formulario.Dock = DockStyle.Fill;
             this.PnlEscritorio.Controls.Add(formulario);
             this.PnlEscritorio.Tag = formulario;
             formulario.Show(); */

            MySqlDataAdapter dataAdapter;
            DataSet dataSet;
            ConexionBD conexion = new ConexionBD();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM Estudiantes WHERE Estudiantes.iIdEstudiantes =?carnet";
            command.Parameters.AddWithValue("?carnet", TxtNumero.Text);
            command.CommandType = CommandType.Text;
            command.Connection = conexion.Conectar();
            dataAdapter = new MySqlDataAdapter(command);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Estudiantes");
            DtaInscripcion.DataSource = dataSet;
            DtaInscripcion.DataMember = "Estudiantes";
            conexion.Desconectar();




        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }


        private void Button2_Click(object sender, EventArgs e)
        {
            FmBoletaInscripcion trasladar = new FmBoletaInscripcion();
            /*trasladar.TxtCarne.Text = DtaInscripcion.CurrentCell.Value.ToString();
            trasladar.TxtNombre.Text = DtaInscripcion.CurrentRow.Cells().Value.ToString();*/

            trasladar.TxtCarne.Text = DtaInscripcion.Rows[0].Cells[0].Value.ToString();
            trasladar.TxtNombre.Text = DtaInscripcion.Rows[0].Cells[1].Value.ToString();
            trasladar.TxtApellido.Text = DtaInscripcion.Rows[0].Cells[2].Value.ToString();
            trasladar.TxtDireccion.Text = DtaInscripcion.Rows[0].Cells[4].Value.ToString();
            trasladar.TxtTelefono.Text = DtaInscripcion.Rows[0].Cells[6].Value.ToString();
            trasladar.ShowDialog();
        }

        private static void DtaInscripcion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          

            

        }

        private void DtaInscripcion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
