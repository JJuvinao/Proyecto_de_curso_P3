using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NPCservice
    {
        NpcRepository npcRepository;
        List<Npc> npcs;

        public NPCservice()
        {
            npcRepository = new NpcRepository();
            RecargarLista();
        }

        private void RecargarLista()
        {
            npcs = npcRepository.GetList();
        }

        public List<Npc> GetAll()
        {
            return npcs;
        }

        public Npc GetId(string id)
        {
            Npc personaje = npcRepository.GetById(id);
            return personaje;
        }
    }
}
