using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public interface NpcAcciones
    {
        bool SigueVivo();

        int Danio(int def);

        void RecibirDanio(int danio);

        void Morir();

    }
}
