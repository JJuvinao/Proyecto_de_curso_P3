using DAL;
using Entity;
using System.Data;

namespace BLL
{
    public class PuntajeService
    {
        PuntajeRepository puntajeRepository;
        UserServices userPersonaje;
        MundoService mundoservice;
        DataTable tablaPuntaje;

        public PuntajeService(int ID)
        {
            puntajeRepository = new PuntajeRepository();
            userPersonaje = new UserServices();
            mundoservice = new MundoService();
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

        public string Registrar(Puntajes puntaje)
        {
            var user = userPersonaje.GetId(puntaje.Id_user);
            if (user != null)
            {
                var mundo = mundoservice.GetId(puntaje.Id_mundo);
                if (mundo != null)
                {
                    return puntajeRepository.RegistrarPuntaje(puntaje);
                }
                else
                {
                    return "MUNDO NO EXISTE";
                }
            }
            else
            {
                return "USUARIO NO EXISTE";
            }
        }

    }
}
