using Animaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Personaje
    {
        PersoAcciones Presonajes { get; set; }
        PersoAnimacion Animacion { get; set; }
        Habilidades Habili { get; set; }

        public Personaje(PersoAcciones perso, PersoAnimacion ani, Habilidades habili)
        {
            Presonajes = perso;
            Animacion = ani;
            Habili = habili;
        }
    }
}
