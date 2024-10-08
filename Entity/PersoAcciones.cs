using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public interface PersoAcciones
    {
        int Atacar();
        bool SigueVivo();
        int Danio(int def);
        void RecibirDanio(int danio);
        bool TieneMana();
        void RecargarMana();
        void AumentarDanio();
        void Defender(bool turno);
        void Morir();
    }
}
