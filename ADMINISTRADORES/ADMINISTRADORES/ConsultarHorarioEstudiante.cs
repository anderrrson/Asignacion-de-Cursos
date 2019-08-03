using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMINISTRADORES
{
    public class ConsultarHorarioEstudiante
    {
        private TextBox mCarnet;
        private DataGridView DgvHorario;
        public ConsultarHorarioEstudiante(DataGridView tablaHorario, TextBox carnet)
        {
            DgvHorario = tablaHorario;
            mCarnet = carnet;
        }

        public void ObtenerHorario()
        {

            if (!mCarnet.Text.Equals(""))
            {

                MySqlDataAdapter dataAdapter;
                DataSet dataSet;
                ConexionBD conexion = new ConexionBD();
                MySqlCommand command = new MySqlCommand();

                command.CommandText = "SELECT COUNT(*) AS conteo FROM AsignacionDetalle WHERE AsignacionDetalle.iIdSemestre = ?semestre " +
                    "AND AsignacionDetalle.iIdAsignacion = (SELECT Asignacion.idAsignacion FROM Asignacion WHERE Asignacion.iIdEstudiantes = ?carnet)";
                command.Connection = conexion.Conectar();
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("?carnet", mCarnet.Text);
                command.Parameters.AddWithValue("?semestre", 1);
                dataAdapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                int conteo = 0;

                if (dataTable.Rows.Count > 0)
                {
                    DataRow dataRow = dataTable.Rows[0];
                    conteo = Convert.ToInt32(dataRow["conteo"]);
                }
                command.Connection = conexion.Desconectar();

                if (conteo > 0)
                {
                    command.CommandText = "SELECT iIdAsignacion AS ID," +
                        "cDescripcion AS Descripcion," +
                        "concat((SELECT cHoraInicio FROM Horario WHERE Horario.iIdHorario = AsignacionDetalle.iIdHorario),'-',(SELECT cHoraFinal FROM Horario WHERE Horario.iIdHorario = AsignacionDetalle.iIdHorario)) AS Horario," +
                        "(SELECT cNombre FROM Curso WHERE Curso.iIdCurso = AsignacionDetalle.iIdCurso) AS Curso, " +
                        "(SELECT cDescripcion FROM Seccion WHERE Seccion.iIdSeccion = AsignacionDetalle.iIdSeccion) AS Seccion," +
                        "(SELECT cDescripcion FROM Laboratorio WHERE Laboratorio.iIdLaboratorio = AsignacionDetalle.iIdLaboratorio) AS Lab," +
                        "(SELECT cDescripcion FROM Semestre WHERE Semestre.iIdSemestre = AsignacionDetalle.iIdSemestre) AS Semestre " +
                        "FROM AsignacionDetalle WHERE AsignacionDetalle.iIdSemestre = ?semestree " +
                        "AND AsignacionDetalle.iIdAsignacion = (SELECT Asignacion.idAsignacion FROM Asignacion WHERE Asignacion.iIdEstudiantes = ?carneet)";

                    command.CommandType = CommandType.Text;
                    command.Connection = conexion.Conectar();
                    command.Parameters.AddWithValue("?carneet", mCarnet.Text);
                    command.Parameters.AddWithValue("?semestree", 1);
                    dataAdapter = new MySqlDataAdapter(command);
                    dataSet = new DataSet();
                    dataAdapter.Fill(dataSet, "AsignacionDetalle");
                    DgvHorario.DataSource = dataSet;
                    DgvHorario.DataMember = "AsignacionDetalle";
                    conexion.Desconectar();
                    mCarnet.Text = null;
                }
                else
                {
                    MessageBox.Show("No se encontraro coincidencias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Campo Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
