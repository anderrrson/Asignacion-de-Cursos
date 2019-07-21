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
    public partial class Asignacion : Form
    {
        public Asignacion()
        {
            InitializeComponent();
        }

        private void PicHorario_Click(object sender, EventArgs e)
        {
            DIRE o = new DIRE();
            o.Show();
        }
    }
}
