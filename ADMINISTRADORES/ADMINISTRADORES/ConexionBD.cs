using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMINISTRADORES
{
    class ConexionBD
    {
        /*private String Servidor = "192.168.1.150";
        private String BaseDatos = "AsignacionCursos";
        private String Usuario = "diegoS2";
<<<<<<< HEAD
        private String Pass = "Diego123#";
        
=======
        private String Pass = "Diego123#";*/

        private String Servidor = "sql241.main-hosting.eu";
        private String BaseDatos = "u983210075_asign";
        private String Usuario = "u983210075_user";
        private String Pass = "AsignacionCursos123";

>>>>>>> master
        private MySqlConnection mySqlConnection;
        private String Conexion = null;

        public ConexionBD()
        {
       
        }

        public MySqlConnection Conectar()
        {
            Conexion = "Data Source=" + Servidor + ";"
                + "Initial Catalog=" + BaseDatos + ";"
                + "UserID=" + Usuario + ";"
                + "Password=" + Pass + ";";

            mySqlConnection = new MySqlConnection(Conexion);
            try
            {
                mySqlConnection.Open();
                MessageBox.Show("Conectado", "MYSQL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch
            {
                MessageBox.Show("Error", "MYSQL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return mySqlConnection;
        }

        public MySqlConnection Desconectar()
        {
            try
            {
                mySqlConnection.Close();
                MessageBox.Show("Desconectado", "MYSQL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch
            {
                MessageBox.Show("Error", "MYSQL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return mySqlConnection;
        }
    }
}
