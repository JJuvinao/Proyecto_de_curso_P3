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
            ReducirMana(opcion);
            return danio;
        }

        public string RecibirDanio(int danio)
        {
            npc.RecibirDanio(danio);
            return "Daño recibido";
        }

        public string Beffer(int opcion)
        {
            string msg="";
            switch (opcion)
            {
                case 1: { personaje.AumentarDanio();
                          msg = "Dañio aumentado";
                    } break;
                case 2: { personaje.RecargarMana();
                        msg = "Mana recuperado";
                    } break;
            }
            return msg;
        }

        private void ReducirMana(int opc)
        {
            switch(opc)
            {
                case 1: { personaje.ReducionMana(5); } break;
                case 2: { personaje.ReducionMana(15); } break;
                case 3: { personaje.ReducionMana(25); } break;
            }
        }

        public bool ValidarMana()
        {
            return personaje.TieneMana();
        }

        public bool ValidarVida()
        {
            return personaje.SigueVivo();
        }
    }
}