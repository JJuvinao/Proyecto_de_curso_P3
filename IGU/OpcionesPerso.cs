using Entity;
using System;
using System.Windows.Forms;

namespace IGU
{
    public partial class OpcionesPerso : Form
    {
        public int opcion = 0;
        Gerrero gerrero;
        Mago mago;
        Npc npc;
        Plantilla personaje;

        public OpcionesPerso(Plantilla plantilla, Npc npc1)
        {
            InitializeComponent();
            Cargar(plantilla);
            npc = npc1;
            personaje = plantilla;
            MostrarPorClase(plantilla.clase);
            ValidarElMana();
        }

        #region Metodos

        private void Cargar(Plantilla plantilla)
        {
            switch (plantilla.clase)
            {
                case "gerrero": { gerrero = new Gerrero(plantilla.id, plantilla.clase, plantilla.nombre, plantilla.vida, plantilla.mana, plantilla.fuerza, plantilla.defensa, plantilla.armaid); } break;
                case "mago": { mago = new Mago(plantilla.id, plantilla.clase, plantilla.nombre, plantilla.vida, plantilla.mana, plantilla.fuerza, plantilla.defensa, plantilla.armaid); } break;
            }
        }

        public int Prueba()
        {
            return opcion;
        }
        private void MostrarPorClase(string clase)
        {
            switch (clase)
            {
                case "gerrero": { MostrarInfoGerrero(); } break;
                case "mago": { MostrarInfoMago(); } break;
            }
        }

        private void MostrarInfoGerrero()
        {
            labelbasico.Text = gerrero.Basico(npc.defensa);
            labelhab1.Text = gerrero.Hab1(npc.defensa);
            labelhab2.Text = gerrero.Hab2(npc.defensa);
            labelcancelar.Text = "Cancelar el ataque";
        }

        private void MostrarInfoMago()
        {
            labelbasico.Text = mago.Basico(mago.defensa);
            labelhab1.Text = mago.Hab1(mago.defensa);
            labelhab2.Text = mago.Hab2(mago.defensa);
            labelcancelar.Text = "Cancelar el ataque";
        }

        private void ValidarElMana()
        {
            if (personaje.mana >= 5)
            {
                Btbasico.Enabled = true;
            }
            else
            {
                Btbasico.Enabled = false;
                if(personaje.mana >= 15)
                {
                    Bthabilidad01.Enabled = true;
                }
                else
                {
                    Bthabilidad01.Enabled = false;
                    if( personaje.mana >= 25)
                    {
                        Bthabilidad02.Enabled = true;
                    }
                    else
                    {
                        Bthabilidad02.Enabled = false;
                    }
                }
            }
        }

        #endregion
        private void button4_Click(object sender, EventArgs e)
        {
            opcion = 0;
            this.Close();
        }

        private void Btbasico_Click(object sender, EventArgs e)
        {
            opcion = 1;
            this.Close();
        }

        private void Bthabilidad01_Click(object sender, EventArgs e)
        {
            opcion = 2;
            this.Close();
        }

        private void Bthabilidad02_Click(object sender, EventArgs e)
        {
            opcion = 3;
            this.Close();
        }
    }
}
