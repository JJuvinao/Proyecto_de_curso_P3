using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Respuestas_falsas
    {
        public int Respesta_id { get; set; }
        public string Respesta_f { get; set; }
        public string Id_Categoria { get; set; }
        public int Id_Pregunta {  get; set; }

        public Respuestas_falsas() { }

        public Respuestas_falsas(int respuesta_id,string respuesta, string cate, int id_pregunta)
        {
            Respesta_id = respuesta_id;
            Respesta_f = respuesta;
            Id_Categoria = cate;
            Id_Pregunta=id_pregunta;
        }

    }
}
