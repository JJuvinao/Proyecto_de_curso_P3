using Entity;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserPersonajeRepository
    {

        public UserPersonajeRepository() { }

        public DataTable Listado_User(int ID)
        {
            OracleDataReader dataReader;
            DataTable tabla = new DataTable();
            OracleConnection sqlconnec = new OracleConnection();
            try
            {
                sqlconnec = DBConnection.Getinstancia().GetConnection();
                sqlconnec.Open();
                using (OracleCommand command = new OracleCommand("FX_CONSULTARPERSONAJE_USER", sqlconnec))
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

        public List<int> GetList(int Id)
        {
            DataTable tableperso = Listado_User(Id);
            List<int> personajes = new List<int>();

            foreach (DataRow row in tableperso.Rows)
            {
                int elemento = Convert.ToInt32(row["ID_PERSONAJE"]);
                personajes.Add(elemento);
            }

            return personajes;
        }

    }
}
