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
            command.CommandText = "SELECT * FROM Catedratico WHERE Catedratico.iIdCatedratico = ?carnet";
            command.Parameters.AddWithValue("?carnet",TxtNcarnet.Text);
            command.CommandType = CommandType.Text;
            command.Connection = conexion.Conectar();
            dataAdapter = new MySqlDataAdapter(command);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Catedratico");
            DtaAsignacionCat.DataSource = dataSet;
            DtaAsignacionCat.DataMember = "Catedratico"; 
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
            DtaCursosCat.DataSource = dataSet1;
            DtaCursosCat.DataMember = "Curso";
            command1.Connection = conexion.Desconectar();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void DtaCursosCat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtCodigo1.Text = DtaCursosCat.Rows[0].Cells[0].Value.ToString();
            TxtCodigo2.Text = DtaCursosCat.Rows[1].Cells[0].Value.ToString();
            TxtCodigo3.Text = DtaCursosCat.Rows[2].Cells[0].Value.ToString();
            TxtCodigo4.Text = DtaCursosCat.Rows[3].Cells[0].Value.ToString();
            TxtCodigo5.Text = DtaCursosCat.Rows[4].Cells[0].Value.ToString();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
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
