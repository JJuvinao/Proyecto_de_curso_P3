using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class BaseRepository<T>
    {
        protected string _fileName;

        protected BaseRepository(string filename)
        {
            _fileName = filename;
        }

        public abstract List<T> GetAll();

        public string SaveData(T entity)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(_fileName, true))
                {
                    writer.WriteLine(entity.ToString());
                }
                return "Información Guardada Correctamente";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
    }
}
