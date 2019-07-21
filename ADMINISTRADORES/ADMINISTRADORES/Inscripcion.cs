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
    public partial class Inscripcion : Form
    {
        public Inscripcion()
        {
      
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            BoletaIns A = new BoletaIns();
            A.Show();
        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
