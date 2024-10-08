using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Preg_Y_Resp
    {
        public string Pregunta { get; set; }
        public string Repuesta { get; set; }

        public Preg_Y_Resp(string pregu,string respu)
        {
            this.Pregunta = pregu;
            this.Repuesta = respu;
        }

        public override string ToString()
        {
            return $"{Pregunta};{Repuesta}";
        }
    }
}
