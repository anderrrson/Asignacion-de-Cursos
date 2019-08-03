using System;
using System.Drawing;
using System.Windows.Forms;

namespace ADMINISTRADORES
{
    public partial class FmPrincipal : Form
    {
        private Timer timer;
        private string idUsuario, idUsuarioLogin;
        private string fechaIn, fecha_ingreso;
        public FmPrincipal(int mOpcion, string texto, string fechaIn, string idUsuario)
        {
            fecha_ingreso = fechaIn;
            idUsuarioLogin = idUsuario;
            timer = new Timer();
            timer.Tick += new EventHandler(Reloj);
            InitializeComponent();
            LblUsuario.Text = texto;

            timer.Enabled = true;
            switch (mOpcion)
            {
                case 0:
                    if (this.PnlEscritorio.Controls.Count > 0)
                        this.PnlEscritorio.Controls.RemoveAt(0);
                    Form formulario = new FmAdmin(PnlEscritorio) as Form; //Convierte Formulario a Formulario Interno
                    formulario.TopLevel = false;
                    formulario.Dock = DockStyle.Fill;
                    this.PnlEscritorio.Controls.Add(formulario);
                    this.PnlEscritorio.Tag = formulario;
                    formulario.Show();
                    LblTitulo.Text = "Administracion";
                    break;

                case 1:
                    if (this.PnlEscritorio.Controls.Count > 0)
                        this.PnlEscritorio.Controls.RemoveAt(0);
                    Form formulario2 = new FmCatedraticos(PnlEscritorio) as Form; //Convierte Formulario a Formulario Interno
                    formulario2.TopLevel = false;
                    formulario2.Dock = DockStyle.Fill;
                    this.PnlEscritorio.Controls.Add(formulario2);
                    this.PnlEscritorio.Tag = formulario2;
                    formulario2.Show();
                    LblTitulo.Text = "Catedrático";
                    break;

                case 2:
                    if (this.PnlEscritorio.Controls.Count > 0)
                        this.PnlEscritorio.Controls.RemoveAt(0);
                    Form formulario1 = new FmEstudiante(PnlEscritorio) as Form; //Convierte Formulario a Formulario Interno
                    formulario1.TopLevel = false;
                    formulario1.Dock = DockStyle.Fill;
                    this.PnlEscritorio.Controls.Add(formulario1);
                    this.PnlEscritorio.Tag = formulario1;
                    formulario1.Show();
                    LblTitulo.Text = "Estudiante";
                    break;
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void PnlEscritorio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(220, 0, 0);
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(14, 18, 34);
        }

        private void PictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(23, 31, 58);
        }

        private void PictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(14, 18, 34);
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            Bitacora bitacora = new Bitacora(fecha_ingreso, LblHora.Text, Int32.Parse(idUsuarioLogin));
            bitacora.EjecutarBitacora();

            if (this.PnlEscritorio.Controls.Count > 0)
                this.PnlEscritorio.Controls.RemoveAt(0);

            this.Close();

            FmLogin fmLogin = new FmLogin();
            fmLogin.Show();

        }

        private void Reloj(object ob, EventArgs evt)
        {
            DateTime dateTime = DateTime.Now;
            LblHora.Text = dateTime.ToString("hh:mm tt");
            LblFecha.Text = dateTime.ToShortDateString();
        }

        private void LblUsuario_Click(object sender, EventArgs e)
        {


        }



        private void TxtUsuario1_TextChanged(object sender, EventArgs e)
        {


        }

        private void LblFecha_Click(object sender, EventArgs e)
        {

        }
    }
}