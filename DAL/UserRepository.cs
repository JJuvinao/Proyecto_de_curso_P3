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
        public UserRepository(string filename) : base(filename) { }

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

        public List<User> GetList()
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

        public override List<User> GetAll()
        {
            List<User> user = new List<User>();

            if (File.Exists(_fileName))
            {
                using (StreamReader reader = new StreamReader(_fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        user.Add(Map(line));
                    }
                }
            }

            return user;
        }

        private User Map(string line)
        {
            string[] columns = line.Split(';');
            int Id = int.Parse(columns[0]);
            string Name = columns[1], Contra = columns[2], rol = columns[3];
            return new User(Id, Name, Contra, rol);
        }

        private void SaveAll(List<User> pregs)
        {
            using (StreamWriter writer = new StreamWriter(_fileName, false))
            {
                foreach (var users in pregs)
                {
                    writer.WriteLine(users.ToString());
                }
            }
        }

        public string Delete(int id)
        {
            try
            {
                List<User> users = GetAll();

                User usuarioToDelete = users.Find(g => g.Id == id);

                if (usuarioToDelete != null)
                {
                    users.Remove(usuarioToDelete);

                    SaveAll(users);

                    return "usuario eliminado correctamente.";
                }
                else
                {
                    return "usuario no encontrado.";
                }
            }
            catch (Exception ex)
            {
                return $"Error al eliminar al usuario: {ex.Message}";
            }
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
            return GetAll().FirstOrDefault<User>(x => x.Id == id);
        }

        public User GetByName(string name)
        {
            return GetList().FirstOrDefault<User>(x => x.Name == name);
        }
    }
}
