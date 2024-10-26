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
        public MundoRepository(string filename) : base(filename){}
        public override List<Mundo> GetAll()
        {
            List<Mundo> mundo = new List<Mundo>();

            if (File.Exists(_fileName))
            {
                using (StreamReader reader = new StreamReader(_fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        mundo.Add(Map(line));
                    }
                }
            }

            return mundo;
        }

        private Mundo Map(string line)
        {
            string[] columns = line.Split(';');
            int Id = int.Parse(columns[0]);
            string Nombre = columns[2], Fondo = columns[3], Piso = columns[4];
            bool Estado = bool.Parse(columns[1]);
            return new Mundo(Id,Estado,Nombre,Fondo,Piso);
        }

        public Mundo GetById(int id)
        {
            return GetAll().FirstOrDefault<Mundo>(x => x.Id == id);
        }
    }
}
