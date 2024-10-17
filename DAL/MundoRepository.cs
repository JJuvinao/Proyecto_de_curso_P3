using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MundoRepository
    {
        protected string _fileName;
        public MundoRepository(string filename) 
        {
            _fileName = filename;
        }
    }
}
