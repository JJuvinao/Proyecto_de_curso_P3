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
    public class PRE_Y_RESRepository : BaseRepository<Preg_Y_Resp>
    {
        public PRE_Y_RESRepository()
        {
        }

        public override List<Preg_Y_Resp> GetList()
        {
            return null;
        }

        public DataTable Listado_User()
        {
            OracleDataReader dataReader;
            DataTable tabla = new DataTable();
            OracleConnection sqlconnec = new OracleConnection();
            try
            {
                sqlconnec = DBConnection.Getinstancia().GetConnection();
                OracleCommand command = new OracleCommand("SELECT preguntas,respuestas FROM preguntas_y_respuestas", sqlconnec);
                command.CommandType = CommandType.Text;
                sqlconnec.Open();
                dataReader = command.ExecuteReader();
                tabla.Load(dataReader);
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

        public string RegistrarUsuario(Preg_Y_Resp preg_Y_Resp)
        {
            OracleConnection connection = new OracleConnection();
            try
            {
                connection = DBConnection.Getinstancia().GetConnection();
                connection.Open();
                string query = "INSERT INTO preguntas_y_respuestas(id_preyres,preguntas,respuestas) " +
                    "VALUES(:id_preyres,:pregunta,:repuesta)";

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(":id_preyres", preg_Y_Resp.Id);
                    command.Parameters.Add(":pregunta", preg_Y_Resp.Pregunta);
                    command.Parameters.Add(":repuesta", preg_Y_Resp.Repuesta);

                    command.ExecuteNonQuery();
                }

                return "Registro exitoso";
            }
            catch (Exception ex)
            {
                return "Error al registrar la pregunta y repuesta: " + ex.Message;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void SaveAll(List<Preg_Y_Resp> pregs)
        {
           
        }


        public string Delete(int id)
        {
            try
            {
                List<Preg_Y_Resp> preg = GetList();

                Preg_Y_Resp pregToDelete = preg.Find(g => g.Id == id);

                if (pregToDelete != null)
                {
                    preg.Remove(pregToDelete);

                    SaveAll(preg);

                    return "pregutas y respuesta eliminadas correctamente.";
                }
                else
                {
                    return "pregutas y respuesta no encontradas.";
                }
            }
            catch (Exception ex)
            {
                return $"Error al eliminar las pregutas y respuesta: {ex.Message}";
            }
        }

        public string Update(Preg_Y_Resp entity)
        {
            try
            {
                List<Preg_Y_Resp> pres = GetList();

                Preg_Y_Resp updaP_Y_R = pres.Find(g => g.Id == entity.Id);

                if (updaP_Y_R != null)
                {
                    updaP_Y_R.Id = entity.Id;
                    updaP_Y_R.Pregunta = entity.Pregunta;
                    updaP_Y_R.Repuesta = entity.Repuesta;

                    SaveAll(pres);

                    return "informacion actualizada";
                }
                else
                {
                    return "pregutas y respuesta no encontradas.";
                }
            }
            catch (Exception ex)
            {
                return $"Error al actualizar las pregutas y respuesta:  {ex.Message}";
            }
        }

        public Preg_Y_Resp GetById(int id)
        {
            return GetList().FirstOrDefault<Preg_Y_Resp>(x => x.Id == id);
        }
    }
}
