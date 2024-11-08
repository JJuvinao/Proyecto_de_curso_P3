using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PRE_Y_RESRepository : BaseRepository<Preg_Y_Resp>
    {
        public PRE_Y_RESRepository()
        {
        }

        public override List<Preg_Y_Resp> GetList()
        {
            return null;
        }

        private void SaveAll(List<Preg_Y_Resp> pregs)
        {
           
        }

        public string Delete(int id)
        {
            try
            {
                List<Preg_Y_Resp> preg = GetList();

                Preg_Y_Resp pregToDelete = preg.Find(g => g.Id == id);

                if (pregToDelete != null)
                {
                    preg.Remove(pregToDelete);

                    SaveAll(preg);

                    return "pregutas y respuesta eliminadas correctamente.";
                }
                else
                {
                    return "pregutas y respuesta no encontradas.";
                }
            }
            catch (Exception ex)
            {
                return $"Error al eliminar las pregutas y respuesta: {ex.Message}";
            }
        }

        public string Update(Preg_Y_Resp entity)
        {
            try
            {
                List<Preg_Y_Resp> pres = GetList();

                Preg_Y_Resp updaP_Y_R = pres.Find(g => g.Id == entity.Id);

                if (updaP_Y_R != null)
                {
                    updaP_Y_R.Id = entity.Id;
                    updaP_Y_R.Pregunta = entity.Pregunta;
                    updaP_Y_R.Repuesta = entity.Repuesta;

                    SaveAll(pres);

                    return "informacion actualizada";
                }
                else
                {
                    return "pregutas y respuesta no encontradas.";
                }
            }
            catch (Exception ex)
            {
                return $"Error al actualizar las pregutas y respuesta:  {ex.Message}";
            }
        }

        public Preg_Y_Resp GetById(int id)
        {
            return GetList().FirstOrDefault<Preg_Y_Resp>(x => x.Id == id);
        }
    }
}
