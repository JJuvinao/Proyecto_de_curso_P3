using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animaciones
{
    public class AniNpcs
    {
        string PosicionInicial = "Idle.gif";
        string Atacar1 = "Attack_1.gif";
        string Atacar3 = "Attack_3.gif";
        string Atacar2 = "Attack_2.gif";
        string Defensa = "Hurt.gif";
        string morir = "Dead.gif";
        string Rutadirec = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
        string Ruta1 = "imagenes";
        string Ruta2 = "NpcLobo";
        string Ruta3 = "Fondos";
        string Predeterminado = "fondopredeterminado.png";

        public AniNpcs() { }

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

        public string GetPosicionInicial()
        {
            return ValidarExistencia(PosicionInicial);
        }

        public string GetAtacar1()
        {
            return ValidarExistencia(Atacar1);
        }

        public string GetAtacar2()
        {
            return ValidarExistencia(Atacar3);
        }

        public string GetAtacar3()
        {
            return ValidarExistencia(Atacar2);
        }

        public string GetPosicionDefender()
        {
            return ValidarExistencia(Defensa);
        }

        public string GetMorir()
        {
            return ValidarExistencia(morir);
        }
    }
}
