using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }

        public List<Mundo> Getid()
        {
            return mundos = MundoRepository.GetList();
        }

        public Mundo GetId(int id)
        {
            var mundo = MundoRepository.GetById(id);
            return mundo;
        }
    }
}
