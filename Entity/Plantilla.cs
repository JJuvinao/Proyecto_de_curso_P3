﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class Plantilla
    {
        public int id { get; set; }
        public string clase { get; set; }
        public string nombre { get; set; }
        public int vida { get; set; }
        public int fuerza { get; set; }
        public int defensa { get; set; }
        public int mana { get; set; }
        public int armaid { get; set; }

        public abstract int Atacar();
        public Plantilla(int id, string clase, string nombre, int vida, int mana, int fuerza, int defensa, int armaid)
        {
            this.id = id;
            this.clase = clase;
            this.nombre = nombre;
            this.vida = vida;
            this.mana = mana;
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
        public bool TieneMana()
        {
            return this.mana > 0;
        }

        public void RecargarMana()
        {
            this.mana = 50;
        }

        public void AumentarDanio() 
        {
            this.fuerza += 10;
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
            return $"{id},{clase},{nombre},{vida},{mana},{fuerza},{defensa},{armaid}";
        }
    }
}
