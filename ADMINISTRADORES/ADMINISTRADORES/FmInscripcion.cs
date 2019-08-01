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
    public partial class FmInscripcion : Form
    {
        Panel PnlEscritorio;
        public FmInscripcion(Panel PnlPricipal)
        {
            PnlEscritorio = PnlPricipal;
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            FmBoletaInscripcion A = new FmBoletaInscripcion();
            A.Show();
        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (this.PnlEscritorio.Controls.Count > 0)
                this.PnlEscritorio.Controls.RemoveAt(0);

            Form formulario = new FmBoletaInscripcion() as Form; //Convierte Formulario a Formulario Interno
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            this.PnlEscritorio.Controls.Add(formulario);
            this.PnlEscritorio.Tag = formulario;
            formulario.Show();
        }
    }
}
