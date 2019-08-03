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
    public partial class FmCursosCatedratico : Form
    {
        public FmCursosCatedratico()
        {
            InitializeComponent();
        }
        CLSCatedraticos CLSCatedraticos = new CLSCatedraticos();

        private void LblTituloCarnet_Click(object sender, EventArgs e)
        {

        }

        private void DgvCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            CLSCatedraticos.ConsultarNota(Convert.ToInt32(TxtCodigoCatedratico.Text),Convert.ToInt32(TxtAño.Text));
        }
    }
}
