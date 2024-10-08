using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PersoRepository : BaseRepository<SavePersonaje>
    {
        public PersoRepository(string filename) : base(filename)
        {
        }

        public override List<SavePersonaje> GetAll()
        {
            List<SavePersonaje> Perso = new List<SavePersonaje>();

            if (File.Exists(_fileName))
            {
                using (StreamReader reader = new StreamReader(_fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Perso.Add(Map(line));
                    }
                }
            }

            return Perso;
        }

        private SavePersonaje Map(string line)
        {
            string[] columns = line.Split(';');
            int Id = int.Parse(columns[0]), vida = int.Parse(columns[3]),
                mana = int.Parse(columns[4]), fuerza = int.Parse(columns[5]),
                defensa = int.Parse(columns[6]), arma = int.Parse(columns[7]);
            string clase = columns[1],Name = columns[2];
            return new SavePersonaje(Id,clase,Name,vida,mana,fuerza,defensa,arma);
        }
    }
}
