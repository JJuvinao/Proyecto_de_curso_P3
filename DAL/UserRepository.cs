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
                OracleCommand command = new OracleCommand("select id_user,nombre_user,contra_user,rol from usuarios", sqlconnec);
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

        public string RegistrarUsuario(User usuario)
        {
            OracleConnection connection = new OracleConnection();
            try
            {
                connection = DBConnection.Getinstancia().GetConnection();
                connection.Open();
                string query = "INSERT INTO usuarios (id_user, nombre_user, contra_user, Rol) " +
                               "VALUES (:Id, :Nombre, :Contra, :Rol)";

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(":Id", usuario.Id);
                    command.Parameters.Add(":Nombre", usuario.Name);
                    command.Parameters.Add(":Contra", usuario.Contra);
                    command.Parameters.Add(":Rol", usuario.Rol);

                    command.ExecuteNonQuery();
                }

                return "Registro exitoso";
            }
            catch (Exception ex)
            {
                return "Error al registrar el usuario: " + ex.Message;
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
                string query = "UPDATE usuarios SET NOMBRE_USER = :Nane, ROL = :Rol, CONTRA_USER = :Contra " +
                               "WHERE ID_USER = :Id";

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(":Nombre", usuario.Name);
                    command.Parameters.Add(":Contra", usuario.Contra);
                    command.Parameters.Add(":Rol", usuario.Rol);
                    command.Parameters.Add(":Id", usuario.Id);
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
