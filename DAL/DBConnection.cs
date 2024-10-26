using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnection
    {
        private static DBConnection Conexion = null;

        private static string connectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
                                                 "(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=xepdb1)))" +
                                                 "User Id=admin;Password=1234;";

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
