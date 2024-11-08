using DAL;
using System.Collections.Generic;

namespace BLL
{
    public class UserPersonajeService
    {
        UserPersonajeRepository userpersonajeRepository;
        List<int> id_personajes;
        public UserPersonajeService(int id_user)
        {
            userpersonajeRepository = new UserPersonajeRepository();
            id_personajes = userpersonajeRepository.GetList(id_user);
        }

        public List<int> Getlis()
        {
            return id_personajes;
        }

    }
}
