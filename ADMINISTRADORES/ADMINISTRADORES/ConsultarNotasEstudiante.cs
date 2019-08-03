using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ADMINISTRADORES
{
    public class ConsultarNotasEstudiante
    {
        private TextBox mCarnet;
        private DataGridView DgvNotas;
        public ConsultarNotasEstudiante(DataGridView tablaNotas, TextBox carnet)
        {
            DgvNotas = tablaNotas;
            mCarnet = carnet;
        }

        public void ObtenerNotas()
        {
            if (!mCarnet.Text.Equals(""))
            {
                MySqlDataAdapter dataAdapter;
                DataSet dataSet;
                ConexionBD conexion = new ConexionBD();
                MySqlCommand command = new MySqlCommand();

                command.CommandText = "SELECT COUNT(*) AS conteo " +
                    "FROM AsignacionListaDetalle WHERE AsignacionListaDetalle.iIdAlumnos = ?carnet " +
                    "AND AsignacionListaDetalle.iIdAsignacionLista IN" +
                    "(SELECT AsignacionLista.iIdAsignacionLista FROM AsignacionLista " +
                    "WHERE AsignacionLista.iIdSemestre = ?semestre AND AsignacionLista.iIdCurso IN " +
                    "(SELECT AsignacionDetalle.iIdCurso FROM AsignacionDetalle WHERE AsignacionDetalle.iIdSemestre = ?semestre " +
                    "AND AsignacionDetalle.iIdAsignacion IN (SELECT Asignacion.idAsignacion FROM Asignacion WHERE Asignacion.iIdEstudiantes = ?carnet)))";

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
                    command.CommandText = "SELECT (SELECT Curso.cNombre FROM Curso WHERE Curso.iIdCurso = " +
                        "(SELECT AsignacionLista.iIdCurso FROM AsignacionLista " +
                        "WHERE AsignacionLista.iIdAsignacionLista = AsignacionListaDetalle.iIdAsignacionLista)) AS Curso," +
                        "AsignacionListaDetalle.cNota, AsignacionListaDetalle.cStatus " +
                        "FROM AsignacionListaDetalle WHERE AsignacionListaDetalle.iIdAlumnos = ?alumno " +
                        "AND AsignacionListaDetalle.iIdAsignacionLista IN" +
                        "(SELECT AsignacionLista.iIdAsignacionLista FROM AsignacionLista " +
                        "WHERE AsignacionLista.iIdSemestre = ?semestree AND AsignacionLista.iIdCurso IN " +
                        "(SELECT AsignacionDetalle.iIdCurso FROM AsignacionDetalle WHERE AsignacionDetalle.iIdSemestre = ?semestree " +
                        "AND AsignacionDetalle.iIdAsignacion IN (SELECT Asignacion.idAsignacion FROM Asignacion WHERE Asignacion.iIdEstudiantes = ?alumno)))";

                    command.CommandType = CommandType.Text;
                    command.Connection = conexion.Conectar();
                    command.Parameters.AddWithValue("?alumno", mCarnet.Text);
                    command.Parameters.AddWithValue("?semestree", 1);
                    dataAdapter = new MySqlDataAdapter(command);
                    dataSet = new DataSet();
                    dataAdapter.Fill(dataSet, "AsignacionDetalle");
                    DgvNotas.DataSource = dataSet;
                    DgvNotas.DataMember = "AsignacionDetalle";
                    command.Connection = conexion.Desconectar();
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
