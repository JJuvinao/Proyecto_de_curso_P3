using Entity;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PuntajeRepository
    {

        public PuntajeRepository() { }

        public DataTable Listado_Puntaje(int ID)
        {
            OracleDataReader dataReader;
            DataTable tabla = new DataTable();
            OracleConnection sqlconnec = new OracleConnection();
            try
            {
                sqlconnec = DBConnection.Getinstancia().GetConnection();
                sqlconnec.Open();
                using (OracleCommand command = new OracleCommand("FX_CONSULTARPUNTAJES", sqlconnec))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("resultadoCursor", OracleDbType.RefCursor).Direction = ParameterDirection.ReturnValue;
                    command.Parameters.Add("id_usuario", OracleDbType.Int32).Value = ID;
                    dataReader = command.ExecuteReader();
                    tabla.Load(dataReader);
                }
                return tabla;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (sqlconnec.State == ConnectionState.Open)
                {
                    sqlconnec.Close();
                }
            }
        }

        public string RegistrarPuntaje(Puntajes puntaje)
        {
            OracleConnection connection = new OracleConnection();
            try
            {
                connection = DBConnection.Getinstancia().GetConnection();
                connection.Open();
                using (OracleCommand command = new OracleCommand("PKG_INSERT.PR_INSERT_PUNTAJE", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("id_user", OracleDbType.Int32).Value = puntaje.Id_user;
                    command.Parameters.Add(":id_mundo", OracleDbType.Varchar2).Value = puntaje.Id_mundo;
                    command.Parameters.Add(":", OracleDbType.Varchar2).Value = puntaje.Puntaje;

                    command.ExecuteNonQuery();
                }

                return "Registro exitoso";
            }
            catch (Exception ex)
            {
                return "Error al registrar el puntaje: " + ex.Message;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
