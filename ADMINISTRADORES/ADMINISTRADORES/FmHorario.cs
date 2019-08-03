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
            ConsultarHorarioEstudiante consultarHorarioEstudiante = new ConsultarHorarioEstudiante(DgvHorario, TxtCarnet);
            consultarHorarioEstudiante.ObtenerHorario();
            /*
             *SELECT iIdAsignacion AS ID, 
                cDescripcion AS Descripcion, 
        (SELECT cNombre FROM Curso WHERE Curso.iIdCurso = AsignacionDetalle.iIdCurso) AS Curso,
        concat((SELECT cHoraInicio FROM Horario WHERE Horario.iIdHorario = AsignacionDetalle.iIdHorario),"-",(SELECT cHoraFinal FROM Horario WHERE Horario.iIdHorario = AsignacionDetalle.iIdHorario)) AS Horario,
        (SELECT cDescripcion FROM Seccion WHERE Seccion.iIdSeccion = AsignacionDetalle.iIdSeccion) AS Seccion,
        (SELECT cDescripcion FROM Laboratorio WHERE Laboratorio.iIdLaboratorio = AsignacionDetalle.iIdLaboratorio) AS Lab,
        (SELECT cDescripcion FROM Semestre WHERE Semestre.iIdSemestre = AsignacionDetalle.iIdSemestre) AS Semestre
        FROM AsignacionDetalle WHERE AsignacionDetalle.iIdAsignacion = 
        (SELECT Asignacion.idAsignacion FROM Asignacion WHERE Asignacion.iIdEstudiantes = 1);
             */

        }

        private void TxtCarnet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
