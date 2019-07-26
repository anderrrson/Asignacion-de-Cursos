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
    public partial class FmEstudiante : Form
    {
        public FmEstudiante()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FmHorario horario = new FmHorario();
            horario.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void BtnHorario_Click(object sender, EventArgs e)
        {
            FmHorario horario = new FmHorario();
            horario.Show();
        }

        private void BtnNotas_Click(object sender, EventArgs e)
        {
            FmNotas notas = new FmNotas();
            notas.Show();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
           
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
