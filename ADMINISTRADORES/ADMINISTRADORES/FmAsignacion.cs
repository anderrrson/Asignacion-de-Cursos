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
    public partial class FmAsignacion : Form
    {
        public FmAsignacion()
        {
            InitializeComponent();
        }

        private void PicHorario_Click(object sender, EventArgs e)
        {
            FmDire o = new FmDire();
            o.Show();
        }

        private void FmAsignacion_Load(object sender, EventArgs e)
        {

        }
    }
}
