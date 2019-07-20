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
            int i;
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
            Inscripcion i = new Inscripcion();
            i.Show();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Asignacion o = new Asignacion();
            o.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Login o = new Login();
            o.Show();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Horario horario = new Horario();
            horario.Show();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            Notas notas = new Notas();
            notas.Show();
        }
    }
}
