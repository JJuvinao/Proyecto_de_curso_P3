using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animaciones
{
    public class AnimacionVarias
    {
        string sangreperso = "sangrepersonaje.png";
        string sangrenpc = "sangrenpc.png";
        string piso = "pisomontaña.png";
        string Rutadirec = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
        string Ruta1 = "imagenes";
        string Ruta2 = "Varios";
        string Ruta3 = "Fondos";
        string Predeterminado = "fondopredeterminado.png";

        private string ValidarExistencia(string Image)
        {
            string combi = Path.Combine(Rutadirec, Ruta1, Ruta2, Image);
            if (File.Exists(combi))
            {
                return combi;
            }
            else
            {
                return Path.Combine(Rutadirec, Ruta1, Ruta3, Predeterminado);
            }
        }

        public string MostrarsangrePersonaje()
        {
            return ValidarExistencia(sangreperso);
        }

        public string MostrarsangreNpc()
        {
            return ValidarExistencia(sangrenpc);
        }

        public string MostrarsPiso()
        {
            return ValidarExistencia(piso);
        }

    }
}
