using MySql.Data.MySqlClient;
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
           
                //VALIDACION CAMPOS VACIOS
                if (TxtUsuario.Text != "Usuario")
                {
                    if (TxtContraseña.Text != "Contraseña")
                    {
                        if (CboTiposUsuarios.Text != "Seleccione una opción...")
                        {
                        }
                        else msgError("Seleccione un tipo de usuario");
                    }
                    else msgError("Ingrese su Contraseña");
                }
                else msgError("Ingrese su Usuario ");


           
                //CONEXION BASE DE DATOS
                MySqlConnection Conexion;
                ConexionBD conexionBD = new ConexionBD();

                try
                {
                    Conexion = conexionBD.Conectar();// Se inica la conexion 

                    /*
                     * Entre estas dos funciones van los select para consultar
                     */

                    Conexion = conexionBD.Desconectar(); // Finaliza la conexion
                }
                catch
                {
                    MessageBox.Show("Error", "MYSQL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


                /*switch (CboTiposUsuarios.SelectedIndex)
                {
                    case 0:
                        this.Hide();
                        FmPrincipal fmPrincipal = new FmPrincipal(0);
                        fmPrincipal.Show();
                        break;

                    case 1:
                        this.Hide();
                        FmPrincipal fmPrincipal1 = new FmPrincipal(1);
                        fmPrincipal1.Show();
                        break;

                    case 2:
                        this.Hide();
                        FmPrincipal fmPrincipal2 = new FmPrincipal(2);
                        fmPrincipal2.Show();
                        break;

                    default:
                        break;
                }*/
           
        }


        //MENSAJE DE ERROR
        private void msgError(string msg)
        {
            LblErrorUsuario.Text = " " + msg;
            LblErrorUsuario.Visible = true;
        }


        private void TxtUserName_Enter(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "Usuario")
            {
                TxtUsuario.Text = "";
                TxtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void TxtUserName_Leave(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "")
            {
                TxtUsuario.Text = "Usuario";
                TxtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void TxtContraseña_Enter(object sender, EventArgs e)
        {
            if (TxtContraseña.Text == "Contraseña")
            {
                TxtContraseña.Text = "";
                TxtContraseña.ForeColor = Color.LightGray;
                TxtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void TxtContraseña_Leave(object sender, EventArgs e)
        {
            if (TxtContraseña.Text == "")
            {
                TxtContraseña.Text = "Contraseña";
                TxtContraseña.ForeColor = Color.LightGray;
                TxtContraseña.UseSystemPasswordChar = false;
            }
        }
    }
}
