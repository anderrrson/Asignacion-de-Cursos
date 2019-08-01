using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMINISTRADORES
{
    public partial class FmHorario : Form
    {
        public FmHorario()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Horario_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            /*DataTable tabla = new DataTable();
            tabla.Columns.Add("Codigo");
            tabla.Columns.Add("Curso");
            tabla.Columns.Add("Horario");
            tabla.Columns.Add("Seccion");
            tabla.Columns.Add("Salon");

            tabla.Rows.Add("001", "Analisis de Sistemas II", "07:00-08:35", "A", "T-410");
            tabla.Rows.Add("002", "Etica Profesional", "07:00-08:35", "A", "T-410");
            tabla.Rows.Add("003", "Redes I", "08:35-10:05", "A", "T-410");
            tabla.Rows.Add("004", "Desarrollo Web", "08:35-10:00", "A", "T-410");
            tabla.Rows.Add("005", "Arquitectura de Computadoras II", "10:35-12:05", "A", "T-410");

            DgvHorario.DataSource = tabla;
            DgvHorario.Columns[0].Width = 100;
            DgvHorario.Columns[1].Width = 358;
            DgvHorario.Columns[2].Width = 100;
            DgvHorario.Columns[3].Width = 50;
            DgvHorario.Columns[4].Width = 50;*/

            MySqlDataAdapter dataAdapter;
            DataSet dataSet;
            ConexionBD conexion = new ConexionBD();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM AsignacionDetalle " +
                "WHERE AsignacionDetalle.iIdAsignacion = (SELECT Asignacion.idAsignacion FROM Asignacion " +
                "WHERE Asignacion.iIdEstudiantes = ?carnet)";
            command.CommandType = CommandType.Text;
            command.Connection = conexion.Conectar();
            command.Parameters.AddWithValue("?carnet", 1);
            dataAdapter = new MySqlDataAdapter(command);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet,"AsignacionDetalle");
            DgvHorario.DataSource = dataSet;
            DgvHorario.DataMember = "AsignacionDetalle";
            conexion.Desconectar();
        }
    }
}
