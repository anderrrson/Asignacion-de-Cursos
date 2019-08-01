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
using MySql.Data;

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

            

            //Validacion Campos Vacios 
            if ((TxtUsuario.Text == "Usuario") || (TxtContraseña.Text == "Contraseña") || (CboTiposUsuarios.Text == "Seleccione una opción..."))
            {

                msgError("Existe un campo vacio ");

            }
            else
            {
                
                msgAceptacion("");
                

                //CONEXION BASE DE DATOS
                MySqlConnection Conexion;
                ConexionBD conexionBD = new ConexionBD();
                MySqlCommand command = new MySqlCommand();

                command.CommandText = "SELECT * FROM Usuarios WHERE bUsuario ='"+TxtUsuario.Text+"' AND bPassword='"+TxtContraseña.Text+"' AND iIdTipo='"+CboTiposUsuarios.SelectedIndex+"'";
                command.Connection = conexionBD.Conectar();

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    MessageBox.Show(Convert.ToString(row["bUsuario"]));
                    MessageBox.Show(Convert.ToString(row["bPassword"]));
                    MessageBox.Show(Convert.ToString(row["iIdTipo"]));

                    if (TxtUsuario.Text == (Convert.ToString(row["bUsuario"])))
                    {
                        MessageBox.Show("Usuario Correcto");

                        if (TxtContraseña.Text == (Convert.ToString(row["bPassword"])))
                        {
                            MessageBox.Show("Password Correcto");

                            if (CboTiposUsuarios.SelectedIndex == (Convert.ToInt32(row["iIdTipo"])))
                            {
                                
                                switch (CboTiposUsuarios.SelectedIndex)
                                {
                                    case 0:
                                        MessageBox.Show("Debe seleccionar un tipo de usuario...");
                                        break;
                                    case 1:
                                        
                                        this.Hide();
                                        String texto = TxtUsuario.Text;
                                        FmPrincipal fmPrincipal = new FmPrincipal(0,texto);
                                        fmPrincipal.Show();
                                        break;

                                    case 2:
                                        this.Hide();
                                        String texto2 = TxtUsuario.Text;
                                        FmPrincipal fmPrincipal1 = new FmPrincipal(1,texto2);
                                        fmPrincipal1.Show();
                                        break;

                                    case 3:
                                        this.Hide();
                                        String texto3 = TxtUsuario.Text;
                                        FmPrincipal fmPrincipal2 = new FmPrincipal(2,texto3);
                                        fmPrincipal2.Show();
                                        break;

                                    default:
                                        break;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Tipo de Usuario Incorrecto");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password Incorrecto");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario Incorrecto");
                    }


                    //Finaliza Conexion
                    conexionBD.Desconectar();



                }
            }
        }


        //MENSAJE DE ERROR
        private void msgError(string msg)
        {
            LblErrorUsuario.Text = " " + msg;
            LblErrorUsuario.Visible = true;
        }

        //QUITA MENSAJE DE ERROR
        private void msgAceptacion(string msg)
        {
            LblErrorUsuario.Text = " " + msg;
            LblErrorUsuario.Visible = false;
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
