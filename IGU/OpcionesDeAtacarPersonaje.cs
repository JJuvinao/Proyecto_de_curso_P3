using Entity;
using System;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace IGU
{
    public partial class OpcionesDeAtacarPersonaje : Form
    {
        int opcion = 0;
        Gerrero gerrero;
        Mago mago;
        Npc npc;
        Arquero arquero;
        Plantilla personaje;
        SeleccionPrreyRes seleccionpreyres;

        public OpcionesDeAtacarPersonaje(Plantilla plantilla, Npc npc1)
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
                case "GERRERO": { gerrero = new Gerrero(plantilla.id, plantilla.clase, plantilla.nombre, plantilla.vida, plantilla.mana, plantilla.fuerza, plantilla.defensa, plantilla.armaid); } break;
                case "MAGO": { mago = new Mago(plantilla.id, plantilla.clase, plantilla.nombre, plantilla.vida, plantilla.mana, plantilla.fuerza, plantilla.defensa, plantilla.armaid); } break;
                case "ARQUERO": { arquero = new Arquero(plantilla.id, plantilla.clase, plantilla.nombre, plantilla.vida, plantilla.mana, plantilla.fuerza, plantilla.defensa, plantilla.armaid); } break;
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
                case "GERRERO": { MostrarInfoGerrero(); } break;
                case "MAGO": { MostrarInfoMago(); } break;
                case "ARQUERO": { MostrarInfoArquero(); } break;
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

        private void MostrarInfoArquero()
        {
            labelbasico.Text = arquero.Basico(npc.defensa);
            labelhab1.Text = arquero.Hab1(npc.defensa);
            labelhab2.Text = arquero.Hab2(npc.defensa);
            labelcancelar.Text = "Cancelar el ataque";
        }

        private void ValidarElMana()
        {
            if (personaje.mana >= 25)
            {
                Bthabilidad02.Enabled = true;
            }
            else
            {
                Bthabilidad02.Enabled = false;
            }

            if (personaje.mana >= 15)
            {
                Bthabilidad01.Enabled = true;
            }
            else
            {
                Bthabilidad01.Enabled = false;
            }

            if (personaje.mana >= 5)
            {
                Btbasico.Enabled = true;
            }
            else
            {
                Btbasico.Enabled = false;
            }
        }

        private void Abrirvista()
        {
            seleccionpreyres = new SeleccionPrreyRes();
            seleccionpreyres.ShowDialog();
        }

        private void Mostrarmsg()
        {
            MessageBox.Show("REPUESTA INCORECTA" + "\n"
                                + "RESPUESTA CORRECTA: " + seleccionpreyres.RepuestaCorrecto());
        }

        #endregion
        private void button4_Click(object sender, EventArgs e)
        {
            opcion = 0;
            this.Close();
        }

        private void Btbasico_Click(object sender, EventArgs e)
        {
            Abrirvista();
            if (seleccionpreyres.Responder())
            {
                opcion = 1;
            }
            else
            {
                Mostrarmsg();
            }
            this.Close();
        }

        private void Bthabilidad01_Click(object sender, EventArgs e)
        {
            Abrirvista();
            if (seleccionpreyres.Responder())
            {
                opcion = 2;
            }
            else
            {
                Mostrarmsg();
            }
            this.Close();
        }

        private void Bthabilidad02_Click(object sender, EventArgs e)
        {
            Abrirvista();
            if (seleccionpreyres.Responder())
            {
                opcion = 3;
            }
            else
            {
                Mostrarmsg();
            }
            this.Close();
        }
    }
}
