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
        public string Nombre { get; set; }
        public string Fondo { get; set; }
        public string Piso { get; set; }

        public Mundo() { }
        public Mundo(int id,bool estado, string fondo, string piso, string nombre)
        {
            Id = id;
            Estado = estado;
            Fondo = fondo;
            Piso = piso;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return $"{Id};{Estado};{Fondo};{Piso}";
        }
    }
}
