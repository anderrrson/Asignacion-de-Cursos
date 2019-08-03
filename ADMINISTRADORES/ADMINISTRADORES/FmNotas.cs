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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ConsultarNotasEstudiante consultarNotasEstudiante = new ConsultarNotasEstudiante(DgvNotas, TxtCarnet);
            consultarNotasEstudiante.ObtenerNotas();
        }

        private void FmNotas_Load(object sender, EventArgs e)
        {

        }
    }
}
