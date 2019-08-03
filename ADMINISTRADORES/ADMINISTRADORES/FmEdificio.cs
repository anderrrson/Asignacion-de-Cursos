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
    public partial class FmEdificio : Form
    {
        public FmEdificio()
        {
            InitializeComponent();
        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void FmEdificio_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FmEdificio i = new FmEdificio();
            i.ShowDialog();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnVisualizar_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter dataAdapter;
            DataSet dataSet;
            ConexionBD conexion = new ConexionBD();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM Edificio WHERE Edificio.cNombre =?nombre";
            command.Parameters.AddWithValue("?nombre", TxtNumero.Text);
            command.CommandType = CommandType.Text;
            command.Connection = conexion.Conectar();
            dataAdapter = new MySqlDataAdapter(command);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Estudiantes");
            DtaEdificio.DataSource = dataSet;
            DtaEdificio.DataMember = "Estudiantes";
            conexion.Desconectar();
        }

        private void DtaEdificio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
