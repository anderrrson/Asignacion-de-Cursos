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
    public partial class FmLogin : Form
    {
        public FmLogin()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LabelIngreso_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            switch (CboTiposUsuarios.SelectedIndex)
            {
                case 0:
                    this.Hide();
                    FmAdmin1 fmAdmin1 = new FmAdmin1();
                    fmAdmin1.Show();
                    break;

                case 1:
                    this.Hide();
                    FmEstudiante fmEstudiante = new FmEstudiante();
                    fmEstudiante.Show();
                    break;

                default:
                    break;
            }
        }
    }
}
