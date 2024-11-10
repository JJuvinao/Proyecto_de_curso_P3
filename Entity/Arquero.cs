using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Arquero : Plantilla
    {
        public Arquero(int id, string clase, string nombre, int vida, int mana, int fuerza, int defensa, int armaid) : base(id, clase, nombre, vida, mana, fuerza, defensa, armaid)
        {
        }

        public Arquero() { }

        public new string Basico(int def)
        {
            string basi = "Un ataque basico que" + "\n"
                          + $"hace {fuerza - def} de daño," + "\n"
                          + "consumira 5 de mana";
            return basi;
        }

        public new string Hab1(int def)
        {
            string habi1 = "Una flecha perforante que" + "\n"
                          + $"hace {(int)((fuerza * 1.5) - def)} de daño," + "\n"
                          + "consumira 15 de mana";
            return habi1;
        }

        public new string Hab2(int def)
        {
            string habi2 = "Probabilidad de aturdir al oponente y" + "\n"
                          + $"que hace {(int)((fuerza * 2) - def)} de daño," + "\n"
                          + "consumira 25 de mana";
            return habi2;
        }
    }
}
