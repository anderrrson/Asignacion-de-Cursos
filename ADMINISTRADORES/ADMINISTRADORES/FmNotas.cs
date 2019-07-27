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
    public partial class FmNotas : Form
    {
        public FmNotas()
        {
            InitializeComponent();
        }

        private void TablaHorario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        public void llenar()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Codigo");
            tabla.Columns.Add("Curso");
            tabla.Columns.Add("P. Parcial");
            tabla.Columns.Add("S. Parcial");
            tabla.Columns.Add("Actividades");
            tabla.Columns.Add("Final");

            tabla.Rows.Add("001", "Analisis de Sistemas II", "20", "25", "25", "30");
            tabla.Rows.Add("002", "Etica Profesional", "20", "25", "25", "30");
            tabla.Rows.Add("003", "Redes I", "20", "25", "25", "30");
            tabla.Rows.Add("004", "Desarrollo Web", "20", "25", "25", "30");
            tabla.Rows.Add("005", "Arquitectura de Computadoras II", "20", "25", "25", "30");

            DgvNotas.DataSource = tabla;
            DgvNotas.Columns[0].Width = 100;
            DgvNotas.Columns[1].Width = 258;
            DgvNotas.Columns[2].Width = 75;
            DgvNotas.Columns[3].Width = 75;
            DgvNotas.Columns[4].Width = 75;
            DgvNotas.Columns[5].Width = 75;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            llenar();
        }
    }
}
