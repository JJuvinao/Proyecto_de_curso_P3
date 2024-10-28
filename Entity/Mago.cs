namespace Entity
{
    public class Mago : Plantilla
    {
        public Mago(int id, string clase, string nombre, int vida, int mana, int fuerza, int defensa, int armaid) : base(id, clase, nombre, vida, mana, fuerza, defensa, armaid)
        {
        }
        public Mago() { }

        public string Basico(int def)
        {
            string basi = "Un ataque basico que" + "\n"
                          + $"hara {fuerza - def} de daño" + "\n"
                          + "consumira 5 de mana";
            return basi;
        }

        public string Hab1(int def)
        {
            string habi1 = "Una bola de fuego que" + "\n"
                          + $"hara {(int)((fuerza * 1.5) - def)} de daño," + "\n"
                          + "consumira 15 de mana";
            return habi1;
        }

        public string Hab2(int def)
        {
            string habi2 = "Probabilidad de congelar y que" + "\n"
                          + $"hace {(int)((fuerza * 2) - def)} de daño," + "\n"
                          + "\n" + "consumira 25 de mana";
            return habi2;
        }
    }
}
