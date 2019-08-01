using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ADMINISTRADORES
{
    public class Login
    {
        
        ConexionBD ConexionLogin = new ConexionBD();
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dr;

        public int validacionLogin(string usuario)
        {
            con = ConexionLogin.Conectar();
            int contador = 0;
            try
            {
                cmd.CommandText = "SELECT * FROM usuarios WHERE bUsuario= " + usuario + "";
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("No existe el Usuario", "MYSQL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return contador;
        }

    }
}
