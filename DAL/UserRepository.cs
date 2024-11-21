using Entity;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace DAL
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(){ }

        public DataTable Listado_User()
        {
            OracleDataReader dataReader;
            DataTable tabla = new DataTable();
            OracleConnection sqlconnec = new OracleConnection();
            try
            {
                sqlconnec = DBConnection.Getinstancia().GetConnection();
                sqlconnec.Open();
                using (OracleCommand command = new OracleCommand("FX_CONSULTAR_USUARIOS", sqlconnec))
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

        public string RegistrarUsuario(User usuario)
        {
            OracleConnection connection = new OracleConnection();
            try
            {
                connection = DBConnection.Getinstancia().GetConnection();
                connection.Open();
                using (OracleCommand command = new OracleCommand("PKG_INSERT.PR_INSERT_USUARIO", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("id_user", OracleDbType.Int32).Value = usuario.Id;
                    command.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = usuario.Name;
                    command.Parameters.Add(":contra", OracleDbType.Varchar2).Value = usuario.Contra; 
                    command.Parameters.Add(":rol", OracleDbType.Varchar2).Value = usuario.Rol; 

                    command.ExecuteNonQuery();
                }

                return "Registro exitoso";
            }
            catch (Exception ex)
            {
                return "Error al registrar el la seleccion de personaje: " + ex.Message;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public override List<User> GetList()
        {
            DataTable tableuser = Listado_User();
            List<User> usuarios = new List<User>();

            foreach (DataRow row in tableuser.Rows)
            {
                User elemento = new User
                {
                    Id = Convert.ToInt32(row["id_user"]),
                    Name = row["nombre_user"].ToString(),
                    Contra = row["contra_user"].ToString(),
                    Rol = row["rol"].ToString()
                };
                usuarios.Add(elemento);
            }

            return usuarios;
        }

        public string SaveSeleccion(int id_user,int id_perso)
        {
            OracleDataReader dataReader;
            OracleConnection sqlconnec = new OracleConnection();
            try
            {
                sqlconnec = DBConnection.Getinstancia().GetConnection();
                sqlconnec.Open();
                using (OracleCommand command = new OracleCommand("PKG_INSERT.PR_ASIGNARPERSONAJE", sqlconnec))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("id_user", OracleDbType.Int32).Value = id_user;
                    command.Parameters.Add("id_personaje", OracleDbType.Int32).Value = id_perso;
                    dataReader = command.ExecuteReader();
                }
                return "Registro exitoso";
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

        public string Delete(int id)
        {
            return null;
        }

        public string Update(User usuario)
        {
            OracleConnection connection = new OracleConnection();
            try
            {
                connection = DBConnection.Getinstancia().GetConnection();
                connection.Open();
                using (OracleCommand command = new OracleCommand("PR_ACTUALIZAR_USER", connection))
                {
                    command.Parameters.Add("id_user", usuario.Id);
                    command.Parameters.Add("nombre_use", usuario.Name);
                    command.Parameters.Add("contra", usuario.Contra);
                    command.Parameters.Add("rol", usuario.Rol);
                    command.ExecuteNonQuery();
                }

                return "Registro exitoso";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el usuario: " + ex.Message;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public User GetById(int id)
        {
            return GetList().FirstOrDefault<User>(x => x.Id == id);
        }

        public User GetByName(string name)
        {
            return GetList().FirstOrDefault<User>(x => x.Name == name);
        }

    }
}
