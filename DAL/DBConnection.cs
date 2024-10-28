using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnection
    {
        private static DBConnection Conexion = null;

        private static string connectionString = "User Id=usuario01;Password=admin123;Data Source=(DESCRIPTION =(" +
            "ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(" +
            "SERVER = DEDICATED)(SERVICE_NAME = XE)))";

        public DBConnection() { }

        public OracleConnection GetConnection()
        {
            OracleConnection connection = new OracleConnection();
            try
            { 
                connection.ConnectionString= connectionString;

            } catch(Exception ex)
            {
                connection = null;
                throw ex;
            }
            return connection;
        }

        public static DBConnection Getinstancia()
        {
            if (Conexion == null)
            {
                Conexion = new DBConnection();
            }
            return Conexion;
        }
    }
}
