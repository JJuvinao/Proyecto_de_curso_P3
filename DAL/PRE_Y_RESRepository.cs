using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PRE_Y_RESRepository : BaseRepository<Preg_Y_Resp>
    {
        public PRE_Y_RESRepository(string filename) : base(filename)
        {
        }

        public override List<Preg_Y_Resp> GetAll()
        {
            List<Preg_Y_Resp> pre = new List<Preg_Y_Resp>();
           
            if (File.Exists(_fileName))
            {
                using (StreamReader reader = new StreamReader(_fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        pre.Add(Map(line));
                    }
                }
            }

            return pre;
        }

        private Preg_Y_Resp Map(string line)
        {
            string[] columns = line.Split(';');
            string preg = columns[0],res = columns[1];

            return new Preg_Y_Resp(preg,res);
        }
    }
}
