using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Puntajes
    {
        public int Id_user { get; set; }
        public int Id_mundo {  get; set; }
        public int Puntaje { get; set; }

        public Puntajes() { }
        public Puntajes(int id_user,int id_mundo,int puntaje) 
        {
            Id_user = id_user;
            Id_mundo = id_mundo;
            Puntaje = puntaje;
        }
    }
}
