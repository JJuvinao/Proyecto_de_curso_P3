using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Preg_Y_Resp
    {
        public int Id { get; set; }
        public string Pregunta { get; set; }
        public string Repuesta { get; set; }

        public Preg_Y_Resp() { }
        public Preg_Y_Resp(int id,string pregu,string respu)
        {
            Id = id;
            this.Pregunta = pregu;
            this.Repuesta = respu;
        }

        public override string ToString()
        {
            return $"{Id};{Pregunta};{Repuesta}";
        }
    }
}
