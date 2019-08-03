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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;



namespace ADMINISTRADORES
{
    public partial class FmAsignacionCat : Form
    {
        public FmAsignacionCat()
        {
            InitializeComponent();
        }

        private void LblAsignaciones_Click(object sender, EventArgs e)
        {

        }

        private void FmAsignacionCat_Load(object sender, EventArgs e)
        {

        }

        private void TxtCodigo5_TextChanged(object sender, EventArgs e)
        {

        }

        private void DtaAsignacionCat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnVisualizar_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter dataAdapter;
            DataSet dataSet;
            ConexionBD conexion = new ConexionBD();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM Estudiantes WHERE Estudiantes.iIdEstudiantes =?carnet";
            command.Parameters.AddWithValue("?carnet", TxtNcarnet.Text);
            command.CommandType = CommandType.Text;
            command.Connection = conexion.Conectar();
            dataAdapter = new MySqlDataAdapter(command);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Estudiantes");
            DtaAsignacionCat.DataSource = dataSet;
            DtaAsignacionCat.DataMember = "Estudiantes";
            conexion.Desconectar();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Document boleta = new Document();
            PdfWriter.GetInstance(boleta, new FileStream("E:/Crear Dire.pdf", FileMode.Create));
            boleta.Open();
            /* boleta.Add(l);*/
            boleta.Close();
            MessageBox.Show("DIRE LISTO");
        }
    }
}
