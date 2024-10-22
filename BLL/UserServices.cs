using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class UserServices : ICRUD<User>
    {
        List<User> users;
        UserRepository UserRepository;

        public UserServices()
        {
            UserRepository = new UserRepository(Config.FILENAME_User);
            ResfrescarLista();
        }

        private void ResfrescarLista()
        {
            users = UserRepository.GetAll();
        }

        public List<User> GetAll()
        {
            return users;
        }

        public User GetId(int id)
        {
            throw new NotImplementedException();
        }

        public string SaveData(User entity)
        {
            throw new NotImplementedException();
        }
        public string Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
