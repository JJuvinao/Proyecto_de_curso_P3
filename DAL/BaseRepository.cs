using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class BaseRepository<T>
    {

        protected BaseRepository()
        {
        }

        public abstract List<T> GetList();
    }
}
