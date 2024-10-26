using Entity;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(string filename) : base(filename){}

        public DataTable Listado_User()
        {
            OracleDataReader dataReader;
            DataTable tabla = new DataTable();
            OracleConnection sqlconnec = new OracleConnection();
            try
            {
                sqlconnec = DBConnection.Getinstancia().GetConnection();
                OracleCommand command = new OracleCommand("",sqlconnec);
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
                if(sqlconnec.State == ConnectionState.Open)
                {
                    sqlconnec.Close();
                }
            }
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
            string Name = columns[1],Contra = columns[2],rol = columns[3];
            return new User (Id,Name,Contra,rol);
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

        public string Update(User entity)
        {
            try
            {
                List<User> user = GetAll();

                User updauser = user.Find(g => g.Id == entity.Id);

                if (updauser != null)
                {
                    updauser.Id = entity.Id;
                    updauser.Name = entity.Name;
                    updauser.Contra = entity.Contra;
                    updauser.Rol = entity.Rol;

                    SaveAll(user);

                    return "informacion actualizada";
                }
                else
                {
                    return "Usuario no emcontrado";
                }
            }
            catch (Exception ex)
            {
                return $"Error al actuarilzar usuario:  {ex.Message}";
            }
        }

        public User GetById(int id)
        {
            return GetAll().FirstOrDefault<User>(x => x.Id == id);
        }
    }
}
