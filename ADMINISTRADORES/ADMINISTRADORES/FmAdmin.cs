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
    public partial class InicioAdmin : Form
    {
        public InicioAdmin()
        {
          
            InitializeComponent();
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void InicioAdmin_Load(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            FmInscripcion i = new FmInscripcion();
            i.Show();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FmAsignacion o = new FmAsignacion();
            o.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            FmHorario horario = new FmHorario();
            horario.Show();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            FmNotas notas = new FmNotas();
            notas.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
            FmLogin login = new FmLogin();
            login.Show();
        }
    }
}
