using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Habilidades
    {
        public int Basico(int Fuerza, int defe)
        {
            return Math.Abs(Fuerza - defe);
        }

        public int Hab1(int Fuerza, int defe)
        {
            return Math.Abs((int)((Fuerza * 1.5) - defe));
        }

        public int Hab2(int Fuerza, int defe)
        {
            return Math.Abs((int)((Fuerza * 2) - defe));
        }
    }
}
