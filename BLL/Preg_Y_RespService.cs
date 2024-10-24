using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Preg_Y_RespService
    {
        List<Preg_Y_Resp> listaPreYRes;
        PRE_Y_RESRepository PRE_Y_RESRepository;

        public Preg_Y_RespService()
        {
            PRE_Y_RESRepository = new PRE_Y_RESRepository(Config.FILENAME_Preg_Y_Resp);
            RefrescarLista();
        }

        private void RefrescarLista()
        {
            listaPreYRes = PRE_Y_RESRepository.GetAll();
        }

        public List<Preg_Y_Resp> GetAll()
        {
            return listaPreYRes;
        }

        public Preg_Y_Resp GetId(int id)
        {
            Preg_Y_Resp pres = PRE_Y_RESRepository.GetById(id);
            return pres;
        }

        public string SaveData(Preg_Y_Resp entity)
        {
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
            Preg_Y_Resp pres = PRE_Y_RESRepository.GetById(id);
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
            var last = listaPreYRes.Last<Preg_Y_Resp>();
            if(last != null) 
            {
                return last.Id + 1; 
            }else { return 0;}
        }

    }
}
