namespace Entity
{
    public class Npc
    {
        public string id { get; set; }
        public string nombre { get; set; }
        public int vida { get; set; }
        public int fuerza { get; set; }
        public int defensa { get; set; }

        public Npc() { }
        public Npc(string id, string nombre, int vida, int fuerza, int defensa)
        {
            this.id = id;
            this.nombre = nombre;
            this.vida = vida;
            this.fuerza = fuerza;
            this.defensa = defensa;
        }

        public bool SigueVivo()
        {
            return this.vida > 0;
        }

        public void RecibirDanio(int danio)
        {
            this.vida -= danio;
        }

        public void Defender()
        {
            this.defensa += 30;
        }

        public void Morir()
        {
            this.vida = 0;
        }

        public override string ToString()
        {
            return $"{id},{nombre},{vida},{fuerza},{defensa}";
        }
    }
}
