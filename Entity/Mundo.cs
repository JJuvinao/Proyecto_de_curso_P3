using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Mundo
    {
        public int Id {  get; set; }
        public bool Estado { get; set; }
        public int Idnpc { get; set; }
        public int Nescenario { get; set; }

        public Mundo(int id,bool estado,int idnpc, int nescenario) 
        {
            Id = id;
            Estado = estado;
            Idnpc = idnpc;
            Nescenario = nescenario;
        }

        public override string ToString()
        {
            return $"{Id};{Estado};{Idnpc};{Nescenario}";
        }
    }
}
