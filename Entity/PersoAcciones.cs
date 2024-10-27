using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public interface PersoAcciones
    {
        bool SigueVivo();
        void RecibirDanio(int danio);
        bool TieneMana();
        void RecargarMana();
        void ReducionMana(int mana);
        void AumentarDanio();
        void Defender(bool turno);
        void Morir();
        string Basico(int def);
        string Hab1(int def);
        string Hab2(int def);
    }
}
