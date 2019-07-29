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
        private Panel PnlEscritorioPrincipal;
        private int Opcion = 0;
        public FmEstudiante(Panel PnlEscritorio)
        {
            PnlEscritorioPrincipal = PnlEscritorio;
            InitializeComponent();
            IniciarPanel();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            /*FmHorario horario = new FmHorario();
            horario.Show();*/
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void BtnHorario_Click(object sender, EventArgs e)
        {
            if (Opcion != 1)
            {
                if (this.PnlEscritorioEstudiante.Controls.Count > 0)
                    this.PnlEscritorioEstudiante.Controls.RemoveAt(0);

                Form formulario = new FmHorario() as Form; //Convierte Formulario a Formulario Interno
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                this.PnlEscritorioEstudiante.Controls.Add(formulario);
                this.PnlEscritorioEstudiante.Tag = formulario;
                formulario.Show();
                Opcion = 1;
            }
        }

        private void BtnNotas_Click(object sender, EventArgs e)
        {
            if (Opcion != 2)
            {
                if (this.PnlEscritorioEstudiante.Controls.Count > 0)
                    this.PnlEscritorioEstudiante.Controls.RemoveAt(0);

                Form formulario = new FmNotas() as Form; //Convierte Formulario a Formulario Interno
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                this.PnlEscritorioEstudiante.Controls.Add(formulario);
                this.PnlEscritorioEstudiante.Tag = formulario;
                formulario.Show();
                Opcion = 2;
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            /*if (PnlEscritorioPrincipal.Controls.Count > 0)
                this.PnlEscritorioPrincipal.Controls.RemoveAt(0);

            Form formulario1 = new FmHorario() as Form; //Convierte Formulario a Formulario Interno
            formulario1.TopLevel = false;
            formulario1.Dock = DockStyle.Fill;
            this.PnlEscritorioPrincipal.Controls.Add(formulario1);
            this.PnlEscritorioPrincipal.Tag = formulario1;
            formulario1.Show();*/
            //LblTitulo.Text = "Estudiante";

            this.Close();

            FmLogin fmLogin = new FmLogin();
            fmLogin.Show();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void IniciarPanel()
        {
            if (Opcion != 1)
            {
                if (this.PnlEscritorioEstudiante.Controls.Count > 0)
                    this.PnlEscritorioEstudiante.Controls.RemoveAt(0);

                Form formulario = new FmHorario() as Form; //Convierte Formulario a Formulario Interno
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                this.PnlEscritorioEstudiante.Controls.Add(formulario);
                this.PnlEscritorioEstudiante.Tag = formulario;
                formulario.Show();
                Opcion = 1;
            }
        }
    }
}
