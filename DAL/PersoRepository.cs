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
    public class PersoRepository : BaseRepository<Plantilla>
    {
        public PersoRepository(){}

        public DataTable Listado_Personaje()
        {
            OracleDataReader dataReader;
            DataTable tabla = new DataTable();
            OracleConnection sqlconnec = new OracleConnection();
            try
            {

                sqlconnec = DBConnection.Getinstancia().GetConnection();
                sqlconnec.Open();
                using (OracleCommand command = new OracleCommand("FX_CONSULTAR_PERSONAJES", sqlconnec))
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

        public override List<Plantilla> GetList()
        {
            DataTable tableperso = Listado_Personaje();
            List<Plantilla> personajes = new List<Plantilla>();

            foreach (DataRow row in tableperso.Rows)
            {
                Plantilla elemento = new Plantilla
                {
                    id = Convert.ToInt32(row["ID_PERSONAJE"]),
                    clase = row["CLASE"].ToString(),
                    nombre = row["NOMBRE"].ToString(),
                    vida = Convert.ToInt32(row["VIDA"]),
                    mana = Convert.ToInt32(row["MANA"]),
                    fuerza = Convert.ToInt32(row["FUERZA"]),
                    defensa = Convert.ToInt32(row["DEFENSA"]),
                    armaid = Convert.ToInt32(row["ID_ARMA"])
                };
                personajes.Add(elemento);
            }

            return personajes;
        }

        public Plantilla GetById(int id)
        {
            return GetList().FirstOrDefault<Plantilla>(x => x.id == id);
        }

        public Plantilla GetByName(string clase)
        {
            return GetList().FirstOrDefault<Plantilla>(x => x.clase == clase);
        }
    }
}
