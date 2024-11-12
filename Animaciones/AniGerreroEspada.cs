using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animaciones
{
    public class AniGerreroEspada : IcrudAnimacion
    {
        string PosicionInicial = "\\Idle.gif";
        string Caminar = "\\Run.gif";
        string Atacar1 = "\\Attack_1.gif";
        string Atacar2 = "\\Attack_3.gif";
        string Atacar3 = "\\Attack_2.gif";
        string PosicionDefender;
        string Ruta = "D:\\Users\\lpove\\Desktop\\P3proyect\\Carpeta Diseños\\Personajes";
        string Predeterminado = "D:\\Users\\lpove\\Desktop\\P3proyect\\Carpeta Diseños\\Fondos\\fondopredeterminado.png";

        public AniGerreroEspada() { }

        private string ValidarExistencia(string Image)
        {
            string combi = Ruta + Image;
            if (File.Exists(combi))
            {
                return combi;
            }
            else
            {
                return Predeterminado;
            }
        }

        public string GetPosicionInicial()
        {
            return ValidarExistencia(PosicionInicial);
        }

        public string GetCaminar()
        {
            return ValidarExistencia(Caminar);
        }

        public string GetAtacar1()
        {
            return ValidarExistencia(Atacar1);
        }

        public string GetAtacar2()
        {
            return ValidarExistencia(Atacar2);
        }

        public string GetAtacar3()
        {
            return ValidarExistencia(Atacar3);
        }

        public string GetPosicionDefender()
        {
            return ValidarExistencia(PosicionDefender);
        }
    }
}
