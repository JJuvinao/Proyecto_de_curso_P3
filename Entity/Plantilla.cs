using System;

namespace Entity
{
    public class Plantilla
    {
        public int id { get; set; }
        public string clase { get; set; }
        public string nombre { get; set; }
        public int vida { get; set; }
        public int fuerza { get; set; }
        public int defensa { get; set; }
        public int mana { get; set; }
        public int armaid { get; set; }
        public Plantilla() { }
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

        public void RecibirDanio(int danio)
        {
            this.vida -= danio;
        }
        public bool TieneMana()
        {
            return this.mana > 0;
        }

        public void RecargarMana()
        {
            this.mana += 100;
        }

        public void ReducionMana(int mana)
        {
            this.mana -= mana;
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
        public string Basico(int def)
        {
            throw new NotImplementedException();
        }

        public string Hab1(int def)
        {
            throw new NotImplementedException();
        }

        public string Hab2(int def)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"{id},{clase},{nombre},{vida},{mana},{fuerza},{defensa},{armaid}";
        }
    }
}
