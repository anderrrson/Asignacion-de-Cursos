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
    public partial class FmEdificio : Form
    {
        public FmEdificio()
        {
            InitializeComponent();
        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void FmEdificio_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FmEdificio i = new FmEdificio();
            i.ShowDialog();
        }
    }
}
