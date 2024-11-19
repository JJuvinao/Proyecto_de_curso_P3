using DAL;
using Entity;
using System.Collections.Generic;

namespace BLL
{
    public class MundoService
    {
        List<Mundo> mundos;
        MundoRepository MundoRepository;
        public MundoService()
        {
            MundoRepository = new MundoRepository();
            Resfrescarlista();
        }

        private void Resfrescarlista()
        {
            mundos = MundoRepository.GetList();
        }

        public List<Mundo> GetAll()
        {
            return mundos;
        }

        public Mundo GetId(int id)
        {
            var mundo = MundoRepository.GetById(id);
            return mundo;
        }

        public Mundo GetByName(string fondo)
        {
            var mundo = MundoRepository.GetByName(fondo);
            return mundo;
        }

    }
}
