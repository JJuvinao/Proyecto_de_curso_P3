using System;
using System.IO;

namespace Animaciones
{
    public class AniSamurai : IcrudAnimacion
    {
        string PosicionInicial = "Idle.gif";
        string Atacar1 = "Attack_1.gif";
        string Atacar3 = "Attack_3.gif";
        string Atacar2 = "Attack_2.gif";
        string PosicionDefender = "SamuraiProtection.gif";
        string AccionMejora = "SamuraiHurt.gif";
        string morir = "SamuraiDead.gif";
        string Rutadirec = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
        string Ruta1 = "imagenes";
        string Ruta2 = "PersonajesSamurai";
        string Ruta3 = "Fondos";
        string Predeterminado = "fondopredeterminado.png";

        public AniSamurai() { }

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

        public string[] GetAtacar1()
        {
            string[] atacar = { ValidarExistencia(Atacar1) };
            return atacar;
        }

        public string[] GetAtacar2()
        {
            string[] atacar = { ValidarExistencia(Atacar3) };
            return atacar;
        }

        public string[] GetAtacar3()
        {
            string[] atacar = { ValidarExistencia(Atacar2) };
            return atacar;
        }

        public string GetPosicionDefender()
        {
            return ValidarExistencia(PosicionDefender);
        }

        public string GetAccionMejora()
        {
            return ValidarExistencia(AccionMejora);
        }


        public string GetMorir()
        {
            return ValidarExistencia(morir);
        }
    }
}
