using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PuntajeService
    {
        PuntajeRepository puntajeRepository;
        DataTable tablaPuntaje;

        public PuntajeService(int ID)
        {
            puntajeRepository = new PuntajeRepository();
            CargarTabla(ID);
        }

        private void CargarTabla(int ID)
        {
            tablaPuntaje = puntajeRepository.Listado_Puntaje(ID);
        }

        public DataTable GetTabla()
        {
            return tablaPuntaje;
        }
    }
}
