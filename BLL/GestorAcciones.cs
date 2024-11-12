using Entity;
using System;

namespace BLL
{
    public class GestorAcciones
    {
        Plantilla personaje;
        Npc npc;
        Habilidades habilidades = new Habilidades();
        Random ramd = new Random();

        public GestorAcciones(Plantilla per, Npc npc1)
        {
            personaje = per;
            npc = npc1;
        }

        public int Atacar(int opcion, bool turno)
        {
            int danio = 0;
            if (turno)
            {
                switch (opcion)
                {
                    case 1: { danio = habilidades.Basico(personaje.fuerza, npc.defensa); } break;
                    case 2: { danio = habilidades.Hab1(personaje.fuerza, npc.defensa); } break;
                    case 3: { danio = habilidades.Hab2(personaje.fuerza, npc.defensa); } break;
                }
                ReducirMana(opcion);
                return danio;
            }
            else
            {
                switch (opcion)
                {
                    case 1: { danio = habilidades.Basico(npc.fuerza, personaje.defensa); } break;
                    case 2: { danio = habilidades.Hab1(npc.fuerza, personaje.defensa); } break;
                    case 3: { danio = habilidades.Hab2(npc.fuerza, personaje.defensa); } break;
                }
                return danio;
            }
        }

        public string RecibirDanio(int danio,bool turno)
        {
            if (turno)
            {
                npc.RecibirDanio(danio);
            }
            else
            {
                personaje.RecibirDanio(danio);
            }
            return "Daño recibido";
        }

        public string Beffer(int opcion)
        {
            string msg = "";
            switch (opcion)
            {
                case 1:
                    {
                        personaje.AumentarDanio();
                        msg = "Dañio aumentado";
                    }
                    break;
                case 2:
                    {
                        personaje.RecargarMana();
                        msg = "Mana recuperado";
                    }
                    break;
            }
            return msg;
        }

        private void ReducirMana(int opc)
        {
            switch (opc)
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

        public int GeneradorOpcion()
        {
            int opcion = ramd.Next(1, 5);
            if (opcion == 5)
            {
                opcion = 1;
            }
            return opcion;
        }
    }
}