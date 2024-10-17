using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface ICRUD<T>
    {
        List<T> GetAll();
        String SaveData(T entity);
        T GetId(int id);
        String Delete(int id);
    }
}
