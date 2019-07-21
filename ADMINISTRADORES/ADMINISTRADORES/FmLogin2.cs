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
    public partial class FmLogin2 : Form
    {
        public FmLogin2()
        {
            InitializeComponent();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FmLogin o = new FmLogin();
            o.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InicioAdmin abrir = new InicioAdmin();
            FmCatedraticos catedratico = new FmCatedraticos();
            FmEstudiante estudiante = new FmEstudiante();

            string usuario;
            usuario = TxtUser.Text;

            if (usuario == "1")
            {
                abrir.Show();
                this.Close();
            }
            else if (usuario == "2")
            {
                catedratico.Show();
                this.Close();
            }
            else if (usuario == "3")
            {
                estudiante.Show();
                this.Close();
            }
        }
    }
}
