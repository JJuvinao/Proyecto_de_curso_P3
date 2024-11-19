using System;
using System.IO;

namespace Animaciones
{
    public class AniMago : IcrudAnimacion
    {
        string PosicionInicial = "Idle.gif";
        string Caminar = "Run.gif";
        string Atacar1 = "Attack_1.gif";
        string Atacar2 = "Magic_sphere.gif";
        string Atacar3 = "Attack_2.gif";
        string PosicionDefender = "Hurt.gif";
        string AccionMejora = "Hurt.gif";
        string morir1 = "Dead1.gif";
        string morir2 = "Dead2.png";
        string Carga1 = "Charge_1.gif";
        string Carga2 = "Charge_2.gif";
        string Rutadirec = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
        string Ruta1 = "imagenes";
        string Ruta2 = "PersonajesMago";
        string Ruta3 = "Fondos";
        string Predeterminado = "fondopredeterminado.png";

        public AniMago() { }

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
            string[] atacar = { ValidarExistencia(Atacar1), ValidarExistencia(Carga1) };
            return atacar;
        }

        public string[] GetAtacar2()
        {
            string[] atacar = { ValidarExistencia(Atacar2), ValidarExistencia(Carga2) };
            return atacar;
        }

        public string[] GetAtacar3()
        {
            string[] atacar = { ValidarExistencia(Atacar3), ValidarExistencia(Carga1) };
            return atacar;
        }

        public string GetMorir1()
        {
            return ValidarExistencia(morir1);
        }

        public string GetMorir2()
        {
            return ValidarExistencia(morir2);
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
