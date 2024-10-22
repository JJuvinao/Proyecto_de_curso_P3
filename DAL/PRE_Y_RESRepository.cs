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
        public PRE_Y_RESRepository(string filename) : base(filename)
        {
        }

        public override List<Preg_Y_Resp> GetAll()
        {
            List<Preg_Y_Resp> pre = new List<Preg_Y_Resp>();
           
            if (File.Exists(_fileName))
            {
                using (StreamReader reader = new StreamReader(_fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        pre.Add(Map(line));
                    }
                }
            }

            return pre;
        }

        private void SaveAll(List<Preg_Y_Resp> pregs)
        {
            // Sobrescribir el archivo con todos los huéspedes actualizados
            using (StreamWriter writer = new StreamWriter(_fileName, false)) // Sobrescribir archivo
            {
                foreach (var preg in pregs)
                {
                    writer.WriteLine(preg.ToString());
                }
            }
        }

        public string Delete(int id)
        {
            try
            {
                List<Preg_Y_Resp> preg = GetAll();

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

        private Preg_Y_Resp Map(string line)
        {
            string[] columns = line.Split(';');
            string preg = columns[1],res = columns[2];
            int id = int.Parse(columns[0]);

            return new Preg_Y_Resp(id,preg,res);
        }

        public Preg_Y_Resp GetById(int id)
        {
            return GetAll().FirstOrDefault<Preg_Y_Resp>(x => x.Id == id);
        }
    }
}
