using Entity;

namespace BLL
{
    public class GestorAcciones
    {
        Plantilla personaje;
        Npc npc;
        Habilidades habilidades = new Habilidades();
        public GestorAcciones(Plantilla per, Npc npc1)
        {
            personaje = per;
            npc = npc1;
        }

        public int Atacar(int opcion)
        {
            int danio = 0;
            switch (opcion)
            {
                case 1: { danio = habilidades.Basico(personaje.fuerza,npc.defensa); } break;
                case 2: { danio = habilidades.Hab1(personaje.fuerza, npc.defensa); } break;
                case 3: { danio = habilidades.Hab2(personaje.fuerza, npc.defensa); } break;
            }
            return danio;
        }

        public string RecibirDanio(int danio)
        {
            npc.RecibirDanio(danio);
            return "Daño recibido";
        }

        public void Beffer(int opcion,bool turno)
        {
            switch (opcion)
            {
                case 1: { personaje.Defender(turno); } break;
                case 2: { personaje.AumentarDanio(); } break;
                case 3: { personaje.RecargarMana(); } break;
            }
        }

        public bool ValidarMana()
        {
            return personaje.TieneMana();
        }
    }
}