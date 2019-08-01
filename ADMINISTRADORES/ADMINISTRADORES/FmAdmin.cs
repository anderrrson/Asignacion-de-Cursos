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
    public partial class FmAdmin : Form
    {
        private Panel PnlEscritorioPrincipal;
        private int Opcion = 0;
        public FmAdmin(Panel PnlEscritorio)
        {
            PnlEscritorioPrincipal = PnlEscritorioAdmon;
            InitializeComponent();
            IniciarPanel();
        }

 
        private void BtnAsignaciones_Click(object sender, EventArgs e)
        {
            if (Opcion != 1)
            {
                if (this.PnlEscritorioAdmon2.Controls.Count > 0)
                    this.PnlEscritorioAdmon2.Controls.RemoveAt(0);

                Form formulario = new FmAsignacion(PnlEscritorioAdmon2) as Form; //Convierte Formulario a Formulario Interno
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                this.PnlEscritorioAdmon2.Controls.Add(formulario);
                this.PnlEscritorioAdmon2.Tag = formulario;
                formulario.Show();
                Opcion = 1;
            }
        }

        private void BtnInscripcion_Click(object sender, EventArgs e)
        {
            if (Opcion != 2)
            {
                if (this.PnlEscritorioAdmon2.Controls.Count > 0)
                    this.PnlEscritorioAdmon2.Controls.RemoveAt(0);

                Form formulario = new FmInscripcion(PnlEscritorioAdmon2) as Form; //Convierte Formulario a Formulario Interno
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                this.PnlEscritorioAdmon2.Controls.Add(formulario);
                this.PnlEscritorioAdmon2.Tag = formulario;
                formulario.Show();
                Opcion = 2;
            }
        }

        private void BtnEdificios_Click(object sender, EventArgs e)
        {
            if (Opcion != 3)
            {
                if (this.PnlEscritorioAdmon2.Controls.Count > 0)
                    this.PnlEscritorioAdmon2.Controls.RemoveAt(0);

                Form formulario = new FmEdificio() as Form; //Convierte Formulario a Formulario Interno
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                this.PnlEscritorioAdmon2.Controls.Add(formulario);
                this.PnlEscritorioAdmon2.Tag = formulario;
                formulario.Show();
                Opcion = 3;
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();

            FmLogin fmLogin = new FmLogin();
            fmLogin.Show();
        }

        public void IniciarPanel()
        {
            if (Opcion != 1)
            {
                if (this.PnlEscritorioAdmon2.Controls.Count > 0)
                    this.PnlEscritorioAdmon2.Controls.RemoveAt(0);

                Form formulario = new FmInscripcion(PnlEscritorioAdmon2) as Form; //Convierte Formulario a Formulario Interno
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                this.PnlEscritorioAdmon2.Controls.Add(formulario);
                this.PnlEscritorioAdmon2.Tag = formulario;
                formulario.Show();
                Opcion = 1;
            }
        }

        private void FmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void BtnAsignacionCat_Click(object sender, EventArgs e)
        {
            if (Opcion != 4)
            {
                if (this.PnlEscritorioAdmon2.Controls.Count > 0)
                    this.PnlEscritorioAdmon2.Controls.RemoveAt(0);

                Form formulario = new FmAsignacionCat() as Form; //Convierte Formulario a Formulario Interno
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                this.PnlEscritorioAdmon2.Controls.Add(formulario);
                this.PnlEscritorioAdmon2.Tag = formulario;
                formulario.Show();
                Opcion = 4;
            }
        }
    }
}
