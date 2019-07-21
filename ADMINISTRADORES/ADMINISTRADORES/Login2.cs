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
    public partial class Login2 : Form
    {
        public Login2()
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
            Login o = new Login();
            o.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InicioAdmin abrir = new InicioAdmin();
            Form2 catedratico = new Form2();

            string usuario;
            usuario = txtbxUser.Text;

            if (usuario == "1")
            {
                
                abrir.Show();
                this.Close();
            } else if (usuario == "2")
            {
                catedratico.Show();
                this.Close();
            }else if (usuario == "3")
            {

            }
        }
    }
}
