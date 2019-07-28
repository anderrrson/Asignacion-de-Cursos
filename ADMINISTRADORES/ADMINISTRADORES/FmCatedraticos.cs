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
    public partial class FmCatedraticos : Form
    {
        private Panel PnlEscritorioPrincipal;
        private int Opcion = 0;
        public FmCatedraticos(Panel PnlEscritorio)
        {
            PnlEscritorioPrincipal = PnlEscritorio;
            InitializeComponent();
            IniciarPanel();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
          

        }


        private void BtnCursos_Click(object sender, EventArgs e)
        {
            if (Opcion != 1)
            {
                if (this.PnlEscritorioCatedratico.Controls.Count > 0)
                    this.PnlEscritorioCatedratico.Controls.RemoveAt(0);

                Form formulario = new FmCursosCatedratico() as Form; //Convierte Formulario a Formulario Interno
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                this.PnlEscritorioCatedratico.Controls.Add(formulario);
                this.PnlEscritorioCatedratico.Tag = formulario;
                formulario.Show();
                Opcion = 1;
            }
        }

        public void IniciarPanel()
        {
            if (Opcion != 1)
            {
                if (this.PnlEscritorioCatedratico.Controls.Count > 0)
                    this.PnlEscritorioCatedratico.Controls.RemoveAt(0);

                Form formulario = new FmCursosCatedratico() as Form; //Convierte Formulario a Formulario Interno
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                this.PnlEscritorioCatedratico.Controls.Add(formulario);
                this.PnlEscritorioCatedratico.Tag = formulario;
                formulario.Show();
                Opcion = 1;
            }
        }

        private void BtnNotas_Click(object sender, EventArgs e)
        {
            if (Opcion != 2)
            {
                if (this.PnlEscritorioCatedratico.Controls.Count > 0)
                    this.PnlEscritorioCatedratico.Controls.RemoveAt(0);

                Form formulario = new FmNotasCatedratico() as Form; //Convierte Formulario a Formulario Interno
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                this.PnlEscritorioCatedratico.Controls.Add(formulario);
                this.PnlEscritorioCatedratico.Tag = formulario;
                formulario.Show();
                Opcion = 2;
            }
        }
    }
}
