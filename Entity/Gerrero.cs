using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Gerrero : Plantilla, PersoAcciones
    {
        public Gerrero(int id, string clase, string nombre, int vida, int mana, int fuerza, int defensa, int armaid) : base(id, clase, nombre, vida, mana, fuerza, defensa, armaid)
        {
        }

        public override int Atacar()
        {
            int opc = 0;
            string confi="si";
            bool selec = false;

            do
            {
                Console.WriteLine("Escoja el ataque: (el numero)" + "\n"
                                 + "1. Basico" + "\n"
                                 + "2. Hab: Daño aumetado en 10" + "\n"
                                 + "3. Hab: Aturdir" + "\n"
                                 + "4. Hab: Golpe fuerte" + "\n"
                                 + "5. Volver" + "\n");
                string inp = Console.ReadLine();

                bool v = int.TryParse(inp, out opc);
                if (!v)
                {

                    Console.WriteLine("Error al ingresar el numero");
                }
                else
                {
                    switch (opc)
                    {
                        case 1:
                            {
                                Console.WriteLine("Confirmar ataque" + "\n" + $"Un ataque basico, hace {this.fuerza} de daño" + "\n" + "Usa 10 de mana" + "\n" + "Desea atacar? [si/no]");
                                confi = Console.ReadLine();
                                selec = confi.ToLower() == "si";
                            }
                            break;

                        case 2:
                            {
                                Console.WriteLine("Confirmar ataque" + "\n" + "Se aumenta el daño en 10" + "\n" + "Usa 5 de mana" + "\n" + "Desea atacar? [si/no]");
                                confi = Console.ReadLine();
                                selec = confi.ToLower() == "si";
                            }
                            break;

                        case 3:
                            {
                                Console.WriteLine("Confirmar ataque" + "\n" + $"Tiene la probabilidad de aturdir al oponente y hace {(int)(this.fuerza * 1.5)} de daño" + "\n" + "Usa 15 de mana" + "\n" + "Desea atacar? [si/no]");
                                confi = Console.ReadLine();
                                selec = confi.ToLower() == "si";
                            }
                            break;

                        case 4:
                            {
                                Console.WriteLine("Confirmar ataque" + "\n" + $"Hace {this.fuerza*2} de daño" + "\n" + "Usa 20 de mana" + "\n" + "Desea atacar? [si/no]");
                                confi = Console.ReadLine();
                                selec = confi.ToLower() == "si";
                            }
                            break;
                        case 5: 
                            {
                                selec = true;
                            }; 
                            break;
                    }
                }

            } while (selec == false);

            return opc;
        }
    }
}
