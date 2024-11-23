using DAL;
using Entity;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BLL
{
    public class Preg_Y_RespService
    {
        List<Preg_Y_Resp> listaPreYRes;
        List<Respuestas_falsas> respuestas_Falsas_BY_Pregunta;
        List<Respuestas_falsas> respuestas_Falsas;
        PRE_Y_RESRepository PRE_Y_RESRepository;

        public Preg_Y_RespService()
        {
            PRE_Y_RESRepository = new PRE_Y_RESRepository();
            RefrescarLista();
        }

        private void RefrescarLista()
        {
            listaPreYRes = PRE_Y_RESRepository.GetList();
            respuestas_Falsas = PRE_Y_RESRepository.GetList_falsas();
        }

        public DataTable Gettabla()
        {
            return PRE_Y_RESRepository.Listado_PreYRes();
        }

        public List<Preg_Y_Resp> GetAll()
        {
            return listaPreYRes;
        }

        public List<Respuestas_falsas> Getlis_falsas(int id_pregunta)
        {
            return respuestas_Falsas_BY_Pregunta = PRE_Y_RESRepository.GetList_falsasBY_Pregunta(id_pregunta);
        }

        public Preg_Y_Resp GetId(int id)
        {
            Preg_Y_Resp pres = PRE_Y_RESRepository.GetByIdPregunta(id);
            return pres;
        }

        public string SaveData(Preg_Y_Resp entity)
        {
            Preg_Y_Resp pre = PRE_Y_RESRepository.GetByIdPregunta(entity.Id);
            if (pre != null)
            {
                return "No pueden repetir las preguntas o cambiar el id";
            }
            var msg = PRE_Y_RESRepository.RegistrarPresYResp(entity);
            RefrescarLista();
            return msg;
        }

        public string SaveRespuestas(Respuestas_falsas respuesta)
        {
            Respuestas_falsas pre = PRE_Y_RESRepository.GetByIdRespuesta(respuesta.Respesta_id,respuesta.Id_Pregunta);
            if (pre != null)
            {
                return "No pueden repetir el id";
            }
            var msg = PRE_Y_RESRepository.RegistrarRespuestaFalsa(respuesta);
            RefrescarLista();
            return msg;
        }

        public string Delete(int id)
        {
            Preg_Y_Resp pres = PRE_Y_RESRepository.GetByIdPregunta(id);
            if (pres == null)
            {
                return null;
            }
            var msg = PRE_Y_RESRepository.Delete(id);
            RefrescarLista();
            return msg;
        }

        public string Update(Preg_Y_Resp entity)
        {
            Preg_Y_Resp PreYRes = GetId(entity.Id);
            if (PreYRes == null)
            {
                return "Preguntas y repuestas no existentes";
            }
            var mgs = PRE_Y_RESRepository.Update(entity);
            RefrescarLista();
            return mgs;
        }
        public int Number()
        {
            if (listaPreYRes.Count != 0)
            {
                var last = listaPreYRes.Last<Preg_Y_Resp>();
                return last.Id + 1;
            }
            else { return 0; }
        }

        public int Number_Falsa()
        {
            if (respuestas_Falsas_BY_Pregunta.Count != 0)
            {
                var last = respuestas_Falsas_BY_Pregunta.Last<Respuestas_falsas>();
                return last.Respesta_id + 1;
            }
            else { return 0; }
        }
    }
}
