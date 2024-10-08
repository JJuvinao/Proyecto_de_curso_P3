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
            return Fuerza - defe;
        }

        public int Hab1()
        {
            return 10;
        }

        public int Hab2(int Fuerza, int defe)
        {
            return (int)((Fuerza * 1.5) - defe);
        }

        public int Hab3(int Fuerza, int defe)
        {
            return (int)((Fuerza * 2) - defe);
        }
    }
}
