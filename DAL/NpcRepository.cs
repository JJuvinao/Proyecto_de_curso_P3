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
        public NpcRepository(string filename) : base(filename)
        {
        }

        public override List<Npc> GetAll()
        {
            List<Npc> npc = new List<Npc>();

            if (File.Exists(_fileName))
            {
                using (StreamReader reader = new StreamReader(_fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        npc.Add(Map(line));
                    }
                }
            }

            return npc;
        }

        private Npc Map(string line)
        {
            string[] columns = line.Split(';');
            int Id = int.Parse(columns[0]), vida = int.Parse(columns[3]),
                fuerza = int.Parse(columns[4]),defensa = int.Parse(columns[5]), 
                arma = int.Parse(columns[6]);
            string clase = columns[1], Name = columns[2];

            return new Npc(Id,clase,Name,vida,fuerza,defensa,arma);
        }
    }
}
