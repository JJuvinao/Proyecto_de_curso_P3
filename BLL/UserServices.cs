using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class UserServices
    {
        List<User> users;
        UserRepository UserRepository;

        public UserServices()
        {
            UserRepository = new UserRepository(Config.FILENAME_User);
            RefrescarLista();
        }

        private void RefrescarLista()
        {
            users = UserRepository.GetAll();
        }

        public DataTable getall()
        {
            return UserRepository.Listado_User();
        }
        public List<User> GetAll()
        {
            return users;
        }

        public User GetId(int id)
        {
            User user = UserRepository.GetById(id);
            return user;
        }

        public string SaveData(User entity)
        {
            User user = UserRepository.GetById(entity.Id);
            if (user != null)
            {
                return "No pueden repetir el id del usuario";
            }
            var msg = UserRepository.SaveData(entity);
            RefrescarLista();
            return msg;
        }
        public string Delete(int id)
        {
            User user = UserRepository.GetById(id);
            if (user == null)
            {
                return null;
            }
            var msg = UserRepository.Delete(id);
            RefrescarLista();
            return msg;
        }
        public string Update(User entity)
        {
            User user = GetId(entity.Id);
            if (user == null)
            {
                return "Preguntas y repuestas no existentes";
            }
            var mgs = UserRepository.Update(entity);
            RefrescarLista();
            return mgs;
        }

        public bool ValidarNombre(string nom)
        {
            var use = users.FirstOrDefault<User>(x=>x.Name==nom);
            if(use == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Number()
        {
            if (users.Count != 0)
            {
                var last = users.Last<User>();
                return last.Id + 1;
            }
            else { return 0; }
        }
    }
}
