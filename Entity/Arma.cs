using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Arma
    {
        public int id { get; set; }
        public int fuerza { get; set; }

        public Arma(int id, int fuerza)
        {
            this.id = id;
            this.fuerza = fuerza;
        }

        public override string ToString()
        {
            return $"{id};{fuerza}";
        }
        
    }
}
