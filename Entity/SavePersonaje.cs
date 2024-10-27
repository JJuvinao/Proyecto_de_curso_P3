using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class SavePersonaje : Plantilla
    {
        public SavePersonaje(int id, string clase, string nombre, int vida, int mana, int fuerza, int defensa, int armaid) : base(id, clase, nombre, vida, mana, fuerza, defensa, armaid)
        {
        }
    }
}
