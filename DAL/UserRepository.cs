using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(string filename) : base(filename)
        {
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
            int Id = int.Parse(columns[0]), perso1 = int.Parse(columns[3]), 
                perso2 = int.Parse(columns[4]), pers3 = int.Parse(columns[5]);
            string Name = columns[1],Contra = columns[2],rol = columns[6];
            return new User  (Id,Name,Contra,perso1,perso2,pers3,rol);
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
                    updauser.PersoId1 = entity.PersoId1;
                    updauser.PersoId2 = entity.PersoId2;
                    updauser.PersoId3 = entity.PersoId3;
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
