using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
namespace ADMINISTRADORES
{
    public class CLSCatedraticos
    {
        ConexionBD conexionCatedratico = new ConexionBD();
        DataTable dtCatedratico;
        MySqlDataAdapter daCatedratico;
        
    
        public void ConsultarNota(int IidCatedratico, int Ianio)
        {
             
            MySqlConnection conexionCat;
            conexionCat = conexionCatedratico.Conectar();
            DataGridView dvgCatedraticos =new DataGridView();
            try
            {
        
                daCatedratico= new MySqlDataAdapter("Select * From AsignacionCurso Where iIdCatedratico=" + IidCatedratico + "",conexionCat);
                dtCatedratico = new DataTable();
                daCatedratico.Fill(dtCatedratico);
                
                dvgCatedraticos.DataSource = dtCatedratico;

                MessageBox.Show("Consulta Exitosa");

            }catch(Exception ex)
            {
                MessageBox.Show("no se pudo llenar el data grid" + ex.Data);

            }
        }

    }
}
