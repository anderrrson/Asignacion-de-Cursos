using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ADMINISTRADORES
{
    public class Bitacora
    {
        private int bitacora, idUsuarioLogin, conteo;
        private string nombrepc, localIp, sMacAddres, fecha_ingreso, fecha_cierre;
        //CONEXION A LA BASE DE DATOS
        private MySqlConnection Conexion;
        private ConexionBD conexionBD = new ConexionBD();
        private MySqlCommand mySqlCommand = new MySqlCommand();

        public Bitacora(String fechaIn, String fechaC, int idUsuario)
        {
            fecha_ingreso = fechaIn;
            fecha_cierre = fechaC;
            idUsuarioLogin = idUsuario;
        }

        public void EjecutarBitacora()
        {
            mySqlCommand.CommandText = "SELECT COUNT(*)+1 AS id FROM Bitacora";
            mySqlCommand.Connection = conexionBD.Conectar();

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                conteo = Convert.ToInt32(row["id"]);
            }

            //INSERT INTO Bitacora (idBitacora,fecha_ingreso,fecho_cierre,ip,mac,nombrePC,iIdUsuarios) VALUES (((SELECT COUNT(*))+1),'10/10/10','10/10/10','1','gc','ed',1);
            //mySqlCommand.CommandText = "INSERT INTO Bitacora (idBitacora,fecha_ingreso,fecho_cierre,ip,mac,nombrePC,iIdUsuarios) VALUES ((SELECT IFNULL(COUNT(*),0) FROM Bitacora)+1), ?fecha_ingreso,?fecha_cierre,?ip,?mac,?nombrePC,?iIdUsuarios);";
            mySqlCommand.CommandText = "INSERT INTO Bitacora (idBitacora,fecha_ingreso,fecho_cierre,ip,mac,nombrePC,iIdUsuarios) VALUES (?id,?fecha_ingreso,?fecha_cierre,?ip,?mac,?nombrePC,?iIdUsuarios)";
            mySqlCommand.Parameters.AddWithValue("?id", conteo);
            mySqlCommand.Parameters.AddWithValue("?fecha_ingreso", fecha_ingreso);
            mySqlCommand.Parameters.AddWithValue("?fecha_cierre", fecha_cierre);
            mySqlCommand.Parameters.AddWithValue("?ip", ObtenerIp());
            mySqlCommand.Parameters.AddWithValue("?mac", ObtenerMac());
            mySqlCommand.Parameters.AddWithValue("?nombrePC", ObtenerNombrePc());
            mySqlCommand.Parameters.AddWithValue("?iIdUsuarios", idUsuarioLogin);
            mySqlCommand.ExecuteNonQuery();
            conexionBD.Desconectar();
        }

        // -----Obtener Nombre PC------------
        public String ObtenerNombrePc()
        {
            String nombrepc = System.Environment.MachineName;
            return nombrepc;
        }

        //-----Obtener IP------
        public String ObtenerIp()
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }
            return localIP;
        }

        //------Obtener MAC Address-----
        public String ObtenerMac()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                //adapter.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || 
                if (adapter.NetworkInterfaceType == NetworkInterfaceType.Ethernet && adapter.OperationalStatus == OperationalStatus.Up)
                {
                    //Console.WriteLine(adapter.Name);
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            return sMacAddress;
        }
    }
}
