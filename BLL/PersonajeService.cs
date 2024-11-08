using DAL;
using Entity;
using System.Collections.Generic;

namespace BLL
{
    public class PersonajeService
    {
        PersoRepository persorepository;
        List<Plantilla> personajes;
        public PersonajeService()
        {
            persorepository = new PersoRepository();
            RecargarLista();
        }

        private void RecargarLista()
        {
            personajes = persorepository.GetList();
        }

        public List<Plantilla> GetAll()
        {
            return personajes;
        }

        public Plantilla GetId(int id)
        {
            Plantilla personaje = persorepository.GetById(id);
            return personaje;
        }
        public Plantilla GetClase(string clase)
        {
            Plantilla personaje = persorepository.GetByName(clase);
            return personaje;
        }
    }
}
