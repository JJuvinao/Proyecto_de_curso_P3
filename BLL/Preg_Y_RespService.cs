using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Preg_Y_RespService : ICRUD<Preg_Y_Resp>
    {
        List<Preg_Y_Resp> list;
        PRE_Y_RESRepository PRE_Y_RESRepository;

        public Preg_Y_RespService()
        {
            PRE_Y_RESRepository = new PRE_Y_RESRepository(Config.FILENAME_Preg_Y_Resp);
            RefrescarLista();
        }

        private void RefrescarLista()
        {
            list = PRE_Y_RESRepository.GetAll();
        }

        public List<Preg_Y_Resp> GetAll()
        {
            return list;
        }

        public Preg_Y_Resp GetId(int id)
        {
            string di = id.ToString();
            if (string.IsNullOrEmpty(di))
            {
                return null;
            }
            Preg_Y_Resp pres = PRE_Y_RESRepository.GetById(id);
            if(pres != null)
            {
                return pres;
            }
            else
            {
                return null;
            }
        }

        public string SaveData(Preg_Y_Resp entity)
        {
            if(entity == null)
            {
                return "Los datos no pueden estar vacios";
            }
            if(string.IsNullOrEmpty(entity.Id.ToString()) || string.IsNullOrEmpty(entity.Repuesta) || string.IsNullOrEmpty(entity.Repuesta))
            {
                return "el id,pregunta y respuestas no pueden estar vacios";
            }
            Preg_Y_Resp pre = PRE_Y_RESRepository.GetById(entity.Id);
            if(pre != null)
            {
                return "No pueden repetir las preguntas o cambiar el id";
            }

            var msg = PRE_Y_RESRepository.SaveData(entity);
            RefrescarLista();
            return msg;
        }

        public string Delete(int id)
        {
            string di = id.ToString();
            if (string.IsNullOrEmpty(di))
            {
                return "el id no puede estar vacio";
            }
            Preg_Y_Resp pres = PRE_Y_RESRepository.GetById(id);
            if (pres == null)
            {
                return null;
            }

            var msg = PRE_Y_RESRepository.Delete(id);
            RefrescarLista();
            return msg;

        }
        public int Number()
        {
            return list.Count;
        }

    }
}
