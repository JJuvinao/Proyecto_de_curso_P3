using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IGU
{
    public partial class VistaEscojerPersonaje : Form
    {
        User Usser;
        Guerrero gerrero;
        Mago mago;
        Arquero arquero;
        Plantilla perso;
        List<Plantilla> personajes;
        Npc npc;
        PersonajeService personajeService;
        UserServices userServices;
        NPCservice npcservice;
        int indice = 0;

        public VistaEscojerPersonaje(User user)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Usser = user;
            personajeService = new PersonajeService();
            userServices = new UserServices();
            npcservice = new NPCservice();
            CargarPersonajes();
            AsignarNpc();
            Cargar(personajes[indice]);
            perso = personajes[indice];
            MostrarPorClase(personajes[indice].clase);
            MostrarEstadistico();
            ValidarAntarior();
            ValidarSiguente();
        }

        private void CargarPersonajes()
        {
            personajes = personajeService.GetAll();
        }

        private void AsignarNpc()
        {
            npc = npcservice.GetId("01_LOBO");
        }

        private void RecargarInfo()
        {
            ValidarAntarior();
            ValidarSiguente();
            Cargar(personajes[indice]);
            perso = personajes[indice];
            MostrarPorClase(personajes[indice].clase);
            MostrarEstadistico();
        }

        private void Cargar(Plantilla plantilla)
        {
            switch (plantilla.clase)
            {
                case "GERRERO": { gerrero = new Guerrero(plantilla.id, plantilla.clase, plantilla.nombre, plantilla.vida, plantilla.mana, plantilla.fuerza, plantilla.defensa, plantilla.armaid); } break;
                case "MAGO": { mago = new Mago(plantilla.id, plantilla.clase, plantilla.nombre, plantilla.vida, plantilla.mana, plantilla.fuerza, plantilla.defensa, plantilla.armaid); } break;
                case "ARQUERO": { arquero = new Arquero(plantilla.id, plantilla.clase, plantilla.nombre, plantilla.vida, plantilla.mana, plantilla.fuerza, plantilla.defensa, plantilla.armaid); } break;
            }
        }
        private void MostrarPorClase(string clase)
        {
            switch (clase)
            {
                case "GERRERO": { MostrarInfoGerrero(); } break;
                case "MAGO": { MostrarInfoMago(); } break;
                case "ARQUERO": { MostrarInfoArquero(); } break;
            }
        }

        private void MostrarInfoGerrero()
        {
            labelbasico.Text = gerrero.Basico(npc.defensa);
            labelhabi1.Text = gerrero.Hab1(npc.defensa);
            labelhabi2.Text = gerrero.Hab2(npc.defensa);
        }

        private void MostrarInfoMago()
        {
            labelbasico.Text = mago.Basico(npc.defensa);
            labelhabi1.Text = mago.Hab1(npc.defensa);
            labelhabi2.Text = mago.Hab2(npc.defensa);
        }

        private void MostrarInfoArquero()
        {
            labelbasico.Text = arquero.Basico(npc.defensa);
            labelhabi1.Text = arquero.Hab1(npc.defensa);
            labelhabi2.Text = arquero.Hab2(npc.defensa);
        }

        private void MostrarEstadistico()
        {
            labelperso.Text = personajes[indice].nombre;
            labelclase.Text = personajes[indice].clase;
            labelvida.Text = personajes[indice].vida.ToString();
            labelmana.Text = personajes[indice].mana.ToString();
            labelfuerza.Text = personajes[indice].fuerza.ToString();
            labeldefensa.Text = personajes[indice].defensa.ToString();
        }

        private void ValidarAntarior()
        {
            if (indice <= 0)
            {
                Btante.Enabled = false;
                return;
            }
            else
            {
                Btante.Enabled = true;
            }
        }

        private void ValidarSiguente()
        {
            if (indice >= personajes.Count - 1)
            {
                Btsigui.Enabled = false;
                return;
            }
            else
            {
                Btsigui.Enabled = true;
            }
        }

        private void BtCANCELAR_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaUserPersonajes(Usser).ShowDialog();
            this.Close();
        }

        private void Btante_Click(object sender, EventArgs e)
        {
            indice--;
            RecargarInfo();
        }

        private void Btsigui_Click(object sender, EventArgs e)
        {
            indice++;
            RecargarInfo();
        }

        private void Btescojer_Click(object sender, EventArgs e)
        {
            DialogResult corfimacion = MessageBox.Show("¿Estás seguro de que deseas continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(corfimacion == DialogResult.Yes)
            {
                var mgs = userServices.EscojerPersonaje(Usser.Id,perso.id);
                MessageBox.Show(mgs);
                this.Hide();
                new VistaUserPersonajes(Usser).ShowDialog();
                this.Close();
            }
        }
    }
}
