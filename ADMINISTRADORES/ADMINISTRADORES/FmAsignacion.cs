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
    public partial class FmAsignacion : Form
    {
        private Panel PnlEscritorioPrincipal;
        public FmAsignacion(Panel PnlEscritorio)
        {
            PnlEscritorioPrincipal = PnlEscritorio;
            InitializeComponent();
        }

        /*private void PicHorario_Click(object sender, EventArgs e)
        {
            FmDire o = new FmDire();
            o.Show();
        }*/

        private void FmAsignacion_Load(object sender, EventArgs e)
        {

        }

        private void GpnIngresocursos_Enter(object sender, EventArgs e)
        {

        }

        private void GpbCursosadicionales_Enter(object sender, EventArgs e)
        {

        }

        private void LblRevisar_Click(object sender, EventArgs e)
        {

        }

        private void PnlLinea1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtNcarnet_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblNcarnet_Click(object sender, EventArgs e)
        {

        }

        private void LblAsignaciones_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            /* if (this.PnlEscritorioPrincipal.Controls.Count > 0)
                 this.PnlEscritorioPrincipal.Controls.RemoveAt(0);

             Form formulario = new FmDire() as Form; //Convierte Formulario a Formulario Interno
             formulario.TopLevel = false;
             formulario.Dock = DockStyle.Fill;
             this.PnlEscritorioPrincipal.Controls.Add(formulario);
             this.PnlEscritorioPrincipal.Tag = formulario;
             formulario.Show();

             //FmDire i = new FmDire();
             //i.ShowDialog();*/

            FmDire trasladar = new FmDire();        

            trasladar.TxtCarne.Text = DtaAsignacion.Rows[0].Cells[0].Value.ToString();
            trasladar.TxtNombres.Text = DtaAsignacion.Rows[0].Cells[1].Value.ToString();
            trasladar.TxtApellidos.Text = DtaAsignacion.Rows[0].Cells[2].Value.ToString();
            trasladar.TxtDireccion.Text = DtaAsignacion.Rows[0].Cells[4].Value.ToString();

            trasladar.TxtCod1.Text = DtaCursos.Rows[0].Cells[0].Value.ToString();
            trasladar.TxtCod2.Text = DtaCursos.Rows[1].Cells[0].Value.ToString();
            trasladar.TxtCod3.Text = DtaCursos.Rows[2].Cells[0].Value.ToString();
            trasladar.TxtCod4.Text = DtaCursos.Rows[3].Cells[0].Value.ToString();
            trasladar.TxtCod5.Text = DtaCursos.Rows[4].Cells[0].Value.ToString();

            trasladar.TxtNCurso1.Text = DtaCursos.Rows[0].Cells[1].Value.ToString();
            trasladar.TxtNCurso2.Text = DtaCursos.Rows[1].Cells[1].Value.ToString();
            trasladar.TxtNCurso3.Text = DtaCursos.Rows[2].Cells[1].Value.ToString();
            trasladar.TxtNCurso4.Text = DtaCursos.Rows[3].Cells[1].Value.ToString();
            trasladar.TxtNCurso5.Text = DtaCursos.Rows[4].Cells[1].Value.ToString();

            trasladar.TtxLab1.Text = DtaCursos.Rows[0].Cells[2].Value.ToString();
            trasladar.TtxLab2.Text = DtaCursos.Rows[1].Cells[2].Value.ToString();
            trasladar.TtxLab3.Text = DtaCursos.Rows[2].Cells[2].Value.ToString();
            trasladar.TtxLab4.Text = DtaCursos.Rows[3].Cells[2].Value.ToString();
            trasladar.TtxLab5.Text = DtaCursos.Rows[4].Cells[2].Value.ToString();

            trasladar.ShowDialog();
        }

        private void BtnVisualizar_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter dataAdapter;
            DataSet dataSet;
            ConexionBD conexion = new ConexionBD();

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM Estudiantes WHERE Estudiantes.iIdEstudiantes = ?carnet";
            command.Parameters.AddWithValue("?carnet",TxtNcarnet.Text);
            command.CommandType = CommandType.Text;
            command.Connection = conexion.Conectar();
            dataAdapter = new MySqlDataAdapter(command);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Estudiantes");
            DtaAsignacion.DataSource = dataSet;
            DtaAsignacion.DataMember = "Estudiantes"; 
            command.Connection = conexion.Desconectar();


            MySqlDataAdapter dataAdapter1;
            DataSet dataSet1;
            MySqlCommand command1 = new MySqlCommand();

            command1.CommandText = "SELECT * FROM Curso";
            command1.CommandType = CommandType.Text;

            command1.Connection = conexion.Conectar();
            dataAdapter1 = new MySqlDataAdapter(command1);
            dataSet1 = new DataSet();
            dataAdapter1.Fill(dataSet1, "Curso");
            DtaCursos.DataSource = dataSet1;
            DtaCursos.DataMember = "Curso";
            command1.Connection = conexion.Desconectar();

        }

        private void DtaAsignacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DtaCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtCodigo1.Text = DtaCursos.Rows[0].Cells[0].Value.ToString();
            TxtCodigo2.Text = DtaCursos.Rows[1].Cells[0].Value.ToString();
            TxtCodigo3.Text = DtaCursos.Rows[2].Cells[0].Value.ToString();
            TxtCodigo4.Text = DtaCursos.Rows[3].Cells[0].Value.ToString();
            TxtCodigo5.Text = DtaCursos.Rows[4].Cells[0].Value.ToString();
        }
    }
}
