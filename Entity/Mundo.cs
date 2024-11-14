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
        public string Nombre { get; set; }
        public string Fondo { get; set; }
        public string Piso { get; set; }
        public string Id_Categoria { get; set; }

        public Mundo() { }
        public Mundo(int id, string fondo, string piso, string nombre, string id_Categoria)
        {
            Id = id;
            Fondo = fondo;
            Piso = piso;
            Nombre = nombre;
            Id_Categoria = id_Categoria;
        }

        public override string ToString()
        {
            return $"{Id};{Nombre};{Fondo};{Piso};{Id_Categoria}";
        }
    }
}
