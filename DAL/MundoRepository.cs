using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MundoRepository : BaseRepository<Mundo>
    {
        public MundoRepository() { }
        public override List<Mundo> GetList()
        {
            return null;
        }

        public Mundo GetById(int id)
        {
            return GetList().FirstOrDefault<Mundo>(x => x.Id == id);
        }
    }
}
