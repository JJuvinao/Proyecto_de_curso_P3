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
        public string Id_Categoria { get; set; }

        public Preg_Y_Resp() { }
        public Preg_Y_Resp(int id,string pregu,string respu, string id_Categoria)
        {
            Id = id;
            Pregunta = pregu;
            Repuesta = respu;
            Id_Categoria = id_Categoria;
        }

        public override string ToString()
        {
            return $"{Id};{Pregunta};{Repuesta}";
        }
    }
}
