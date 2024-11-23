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
    public class PRE_Y_RESRepository
    {
        public PRE_Y_RESRepository()
        {
        }

        public List<Preg_Y_Resp> GetList()
        {
            DataTable tablepreyres = Listado_PreYRes();
            List<Preg_Y_Resp> presyresps = new List<Preg_Y_Resp>();

            foreach (DataRow row in tablepreyres.Rows)
            {
                Preg_Y_Resp elemento = new Preg_Y_Resp
                {
                    Id = Convert.ToInt32(row["ID_PREYRES"]),
                    Pregunta = row["PREGUNTAS"].ToString(),
                    Repuesta = row["RESPUESTAS"].ToString(),
                    Id_Categoria = row["ID_CATEGORIA"].ToString()
                };
                presyresps.Add(elemento);
            }

            return presyresps;
        }

        public List<Respuestas_falsas> GetList_falsasBY_Pregunta(int id_pregunta)
        {
            DataTable tablepreyres = Listado_Respuesta_falsasBY_Pregunta(id_pregunta);
            List<Respuestas_falsas> resps_falsas = new List<Respuestas_falsas>();

            foreach (DataRow row in tablepreyres.Rows)
            {
                Respuestas_falsas elemento = new Respuestas_falsas
                {
                    Respesta_f = row["RESPUESTA_FALSA"].ToString(),
                    Respesta_id = Convert.ToInt32(row["ID_FALSA"]),
                    Id_Categoria = row["ID_CATEGORIA"].ToString(),
                    Id_Pregunta = Convert.ToInt32(row["ID_PREGUNTA"])
                };
                resps_falsas.Add(elemento);
            }

            return resps_falsas;
        }

        public List<Respuestas_falsas> GetList_falsas()
        {
            DataTable tablepreyres = Listado_Respuesta_falsas();
            List<Respuestas_falsas> resps_falsas = new List<Respuestas_falsas>();

            foreach (DataRow row in tablepreyres.Rows)
            {
                Respuestas_falsas elemento = new Respuestas_falsas
                {
                    Respesta_f = row["RESPUESTA_FALSA"].ToString(),
                    Respesta_id = Convert.ToInt32(row["ID_FALSA"]),
                    Id_Categoria = row["ID_CATEGORIA"].ToString(),
                    Id_Pregunta = Convert.ToInt32(row["ID_PREGUNTA"])
                };
                resps_falsas.Add(elemento);
            }

            return resps_falsas;
        }

        public DataTable Listado_PreYRes()
        {
            OracleDataReader dataReader;
            DataTable tabla = new DataTable();
            OracleConnection sqlconnec = new OracleConnection();
            try
            {
                sqlconnec = DBConnection.Getinstancia().GetConnection();
                sqlconnec.Open();
                using (OracleCommand command = new OracleCommand("FX_CONSULTAR_PREGUNTASYRESPUESTAS", sqlconnec))
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

        public DataTable Listado_Respuesta_falsasBY_Pregunta(int id_pregunta)
        {
            OracleDataReader dataReader;
            DataTable tabla = new DataTable();
            OracleConnection sqlconnec = new OracleConnection();
            try
            {
                sqlconnec = DBConnection.Getinstancia().GetConnection();
                sqlconnec.Open();
                using (OracleCommand command = new OracleCommand("FX_CONSULTAR_RESPUESTAS_FALSAS", sqlconnec))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("resultadoCursor", OracleDbType.RefCursor).Direction = ParameterDirection.ReturnValue;
                    command.Parameters.Add("id_preg", OracleDbType.Int32).Value = id_pregunta;
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

        public DataTable Listado_Respuesta_falsas()
        {
            OracleDataReader dataReader;
            DataTable tabla = new DataTable();
            OracleConnection sqlconnec = new OracleConnection();
            try
            {
                sqlconnec = DBConnection.Getinstancia().GetConnection();
                sqlconnec.Open();
                using (OracleCommand command = new OracleCommand("FX_CONSULTAR_TODAS_RESPUESTAS_FALSAS", sqlconnec))
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

        public string RegistrarPresYResp(Preg_Y_Resp preg_Y_Resp)
        {
            OracleConnection connection = new OracleConnection();
            try
            {
                connection = DBConnection.Getinstancia().GetConnection();
                connection.Open();
                using (OracleCommand command = new OracleCommand("PKG_INSERT.PR_INSERT_PREGUNTA_Y_RESPUESTA", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("id_pyr", OracleDbType.Int32).Value = preg_Y_Resp.Id;
                    command.Parameters.Add(":pregunta", OracleDbType.Varchar2).Value = preg_Y_Resp.Pregunta;
                    command.Parameters.Add(":repuesta", OracleDbType.Varchar2).Value = preg_Y_Resp.Repuesta;
                    command.Parameters.Add(":categoria", OracleDbType.Varchar2).Value = preg_Y_Resp.Id_Categoria;

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

        public string RegistrarRespuestaFalsa(Respuestas_falsas respuesta)
        {
            OracleConnection connection = new OracleConnection();
            try
            {
                connection = DBConnection.Getinstancia().GetConnection();
                connection.Open();
                using (OracleCommand command = new OracleCommand("PKG_INSERT.PR_INSERT_RESPUESTAS_FALSAS", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("id_falsa", OracleDbType.Int32).Value = respuesta.Respesta_id;
                    command.Parameters.Add(":repuesta", OracleDbType.Varchar2).Value = respuesta.Respesta_f;
                    command.Parameters.Add(":id_catedoria", OracleDbType.Varchar2).Value = respuesta.Id_Categoria;
                    command.Parameters.Add(":id_pregunta", OracleDbType.Int32).Value = respuesta.Id_Pregunta;

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

        public string Delete(int id)
        {
            try
            {
                List<Preg_Y_Resp> preg = GetList();

                Preg_Y_Resp pregToDelete = preg.Find(g => g.Id == id);

                if (pregToDelete != null)
                {
                    preg.Remove(pregToDelete);


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
                    updaP_Y_R.Id_Categoria = entity.Id_Categoria;

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

        public Preg_Y_Resp GetByIdPregunta(int id)
        {
            return GetList().FirstOrDefault<Preg_Y_Resp>(x => x.Id == id);
        }

        public Respuestas_falsas GetByIdRespuesta(int id,int id_pregunta)
        {
            return GetList_falsasBY_Pregunta(id_pregunta).FirstOrDefault<Respuestas_falsas>(x => x.Respesta_id == id);
        }
    }
}
