using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Npc : NpcAcciones 
    {
        public int id { get; set; }
        public string clase { get; set; }
        public string nombre { get; set; }
        public int vida { get; set; }
        public int fuerza { get; set; }
        public int defensa { get; set; }
        public int armaid { get; set; }

        public Npc(int id, string clase, string nombre, int vida, int fuerza, int defensa, int armaid)
        {
            this.id = id;
            this.clase = clase;
            this.nombre = nombre;
            this.vida = vida;
            this.fuerza = fuerza;
            this.defensa = defensa;
            this.armaid = armaid;
        }

        public bool SigueVivo()
        {
            return this.vida > 0;
        }

        public int Danio(int def)
        {
            int o = Math.Abs(this.fuerza - def);
            return o;
        }

        public void RecibirDanio(int danio)
        {
            this.vida = -danio;
        }

        public void Defender(bool turno)
        {
            if (turno)
            {
                this.defensa += 30;
            }
            else
            {
                this.defensa -= 30;
            }
        }

        public void Morir()
        {
            this.vida = 0;
        }

        public override string ToString()
        {
            return $"{id},{clase},{nombre},{vida},{fuerza},{defensa},{armaid}";
        }
    }
}
