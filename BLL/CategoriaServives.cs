using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoriaServives
    {
        CategoriaRepository categoriaRepository;
        List<Categorias> listcategorias;

        public CategoriaServives()
        {
            categoriaRepository = new CategoriaRepository();
            RefrescarLista();
        }

        private void RefrescarLista()
        {
            listcategorias = categoriaRepository.GetList();
        }

        public List<Categorias> GetAll()
        {
            return listcategorias;
        }
    }
}
