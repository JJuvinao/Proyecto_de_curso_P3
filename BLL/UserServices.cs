using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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
            UserRepository = new UserRepository();
            RefrescarLista();
        }

        private void RefrescarLista()
        {
            users = UserRepository.GetList();
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
        public User GetName(string name)
        {
            User user = UserRepository.GetByName(name);
            return user;
        }

        public string EscojerPersonaje(int id_user,int id_perso)
        {
            var mgs = UserRepository.SaveSeleccion(id_user,id_perso);
            return mgs;
        }

        public string SaveData(User entity)
        {
            User user = UserRepository.GetById(entity.Id);
            if (user != null)
            {
                return "No pueden repetir el id del usuario";
            }
            var msg = UserRepository.RegistrarUsuario(entity);
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
        public string Update(int id_u, string contra)
        {
            User user = GetId(id_u);
            if (user == null)
            {
                return "ususario no existe";
            }
            var mgs = UserRepository.Update(id_u,contra);
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
