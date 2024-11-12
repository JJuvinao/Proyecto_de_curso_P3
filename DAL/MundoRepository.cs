using Entity;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MundoRepository : BaseRepository<Mundo>
    {
        public MundoRepository() { }

        public DataTable Listado_Mundos()
        {
            OracleDataReader dataReader;
            DataTable tabla = new DataTable();
            OracleConnection sqlconnec = new OracleConnection();
            try
            {
                sqlconnec = DBConnection.Getinstancia().GetConnection();
                sqlconnec.Open();
                using (OracleCommand command = new OracleCommand("FX_CONSULTAR_MUNDO", sqlconnec))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("resultadoCursor", OracleDbType.RefCursor).Direction = ParameterDirection.ReturnValue;
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

        public override List<Mundo> GetList()
        {
            DataTable tableuser = Listado_Mundos();
            List<Mundo> mundos = new List<Mundo>();

            foreach (DataRow row in tableuser.Rows)
            {
                Mundo elemento = new Mundo
                {
                    Id = Convert.ToInt32(row["id_mundo"]),
                    Nombre = row["nombre"].ToString(),
                    Fondo = row["fondo"].ToString(),
                    Piso = row["piso"].ToString()
                };
                mundos.Add(elemento);
            }

            return mundos;
        }

        public Mundo GetById(int id)
        {
            return GetList().FirstOrDefault<Mundo>(x => x.Id == id);
        }
    }
}
