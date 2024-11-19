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
    public class NpcRepository : BaseRepository<Npc>
    {
        public NpcRepository()
        {
        }

        public override List<Npc> GetList()
        {
            DataTable tableperso = Listado_Personaje();
            List<Npc> personajes = new List<Npc>();

            foreach (DataRow row in tableperso.Rows)
            {
                Npc elemento = new Npc
                {
                    id = row["ID_NPC"].ToString(),
                    nombre = row["NOMBRE_NPC"].ToString(),
                    vida = Convert.ToInt32(row["VIDA"]),
                    fuerza = Convert.ToInt32(row["FUERZA"]),
                    defensa = Convert.ToInt32(row["DEFENSA"]),
                };
                personajes.Add(elemento);
            }

            return personajes;
        }

        public DataTable Listado_Personaje()
        {
            OracleDataReader dataReader;
            DataTable tabla = new DataTable();
            OracleConnection sqlconnec = new OracleConnection();
            try
            {

                sqlconnec = DBConnection.Getinstancia().GetConnection();
                sqlconnec.Open();
                using (OracleCommand command = new OracleCommand("FX_CONSULTAR_NPC", sqlconnec))
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


        public Npc GetById(string id)
        {
            return GetList().FirstOrDefault<Npc>(x => x.id == id);
        }
    }
}
