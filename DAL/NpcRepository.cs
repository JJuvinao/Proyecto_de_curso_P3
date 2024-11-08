using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NpcRepository : BaseRepository<Npc>
    {
        public NpcRepository()
        {
        }

        public override List<Npc> GetList()
        {
            return null;
        }
    }
}
