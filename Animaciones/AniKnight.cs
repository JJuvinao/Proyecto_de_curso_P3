using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animaciones
{
    public class AniKnight:IcrudAnimacion
    {
        string PosicionInicial = "Idle.gif";
        string Caminar = "Run.gif";
        string Atacar1 = "Attack_1.gif";
        string Atacar2 = "Magic_sphere.gif";
        string Atacar3 = "Attack_2.gif";
        string PosicionDefender = "Defend.gif";
        string AccionMejora = "Hurt.gif";
        string morir = "Dead.gif";
        string Rutadirec = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
        string Ruta1 = "imagenes";
        string Ruta2 = "PersonajesGerrero";
        string Ruta3 = "Fondos";
        string Predeterminado = "fondopredeterminado.png";

        public AniKnight() { }

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

        public string GetAccionMejora()
        {
            return ValidarExistencia(AccionMejora);
        }

        public string[] GetAtacar1()
        {
            string[] atacar = { ValidarExistencia(Atacar1)};
            return atacar;
        }

        public string[] GetAtacar2()
        {
            string[] atacar = { ValidarExistencia(Atacar3)};
            return atacar;
        }

        public string[] GetAtacar3()
        {
            string[] atacar = { ValidarExistencia(Atacar2)};
            return atacar;
        }

        public string GetMorir()
        {
            return ValidarExistencia(morir);
        }

        public string GetPosicionDefender()
        {
            return ValidarExistencia(PosicionDefender);
        }

        public string GetPosicionInicial()
        {
            return ValidarExistencia(PosicionInicial);
        }
    }
}
