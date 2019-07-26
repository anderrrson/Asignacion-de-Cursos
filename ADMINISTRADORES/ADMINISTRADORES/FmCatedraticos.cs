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
    public partial class FmCatedraticos : Form
    {
        public FmCatedraticos()
        {
            InitializeComponent();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable tablaDatos = new DataTable();
            tablaDatos.Columns.Add("Codigo de Curso");
            tablaDatos.Columns.Add("Nombre de Curso");
            tablaDatos.Columns.Add("Carrera");
            tablaDatos.Columns.Add("Seccion");
            tablaDatos.Columns.Add("Salon");
            tablaDatos.Columns.Add("Horario");
            tablaDatos.Columns.Add("Dia");


            tablaDatos.Rows.Add("038", "Desarrollo Web","Ingenieria en Sistemas","A", "T-410" , "08:35-10:05", "Martes y Jueves");
            tablaDatos.Rows.Add("010", "Ecuaciones Diferenciales", "Ingenieria Industrial", "A", "CC-15", "08:35-10:05", "Lunes y Miercoles");

            tbcwvCursos.DataSource = tablaDatos;
            tbcwvCursos.Columns[0].Width = 100;
            tbcwvCursos.Columns[1].Width = 150;
            tbcwvCursos.Columns[2].Width = 200;
            tbcwvCursos.Columns[3].Width = 100;
            tbcwvCursos.Columns[4].Width = 100;
            tbcwvCursos.Columns[5].Width = 100;
            tbcwvCursos.Columns[6].Width = 150;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable tablaasis = new DataTable();
            tablaasis.Columns.Add("No. de Carnet");
            tablaasis.Columns.Add("Nombre del Alumno");
            tablaasis.Columns.Add("Inasistencias");
            tablaasis.Columns.Add("Asistencias");


            tablaasis.Rows.Add("0901-16-7899", "Anderson Sandoval", "2", "15");
            tablaasis.Rows.Add("0901-16-10058", "Diego Torres", "0", "20");

            tbcvwListado.DataSource = tablaasis;

            tbcvwListado.Columns[0].Width = 100;
            tbcvwListado.Columns[1].Width = 150;
            tbcvwListado.Columns[2].Width = 200;
            tbcvwListado.Columns[3].Width = 100;
        }

        private void button12_Click(object sender, EventArgs e)
        {
          

        }
    }
}
