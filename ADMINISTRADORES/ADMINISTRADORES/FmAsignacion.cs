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
        private Panel PnlEscritorioPrincipal;
        public FmAsignacion(Panel PnlEscritorio)
        {
            PnlEscritorioPrincipal = PnlEscritorio;
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

        private void GpnIngresocursos_Enter(object sender, EventArgs e)
        {

        }

        private void GpbCursosadicionales_Enter(object sender, EventArgs e)
        {

        }

        private void LblRevisar_Click(object sender, EventArgs e)
        {

        }

        private void PnlLinea1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtNcarnet_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblNcarnet_Click(object sender, EventArgs e)
        {

        }

        private void LblAsignaciones_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (this.PnlEscritorioPrincipal.Controls.Count > 0)
                this.PnlEscritorioPrincipal.Controls.RemoveAt(0);

            Form formulario = new FmDire() as Form; //Convierte Formulario a Formulario Interno
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            this.PnlEscritorioPrincipal.Controls.Add(formulario);
            this.PnlEscritorioPrincipal.Tag = formulario;
            formulario.Show();

            //FmDire i = new FmDire();
            //i.ShowDialog();
        }
    }
}
