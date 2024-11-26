using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace GUI
{
    public partial class OpcionesDeAtacarPersonaje : MaterialForm
    {
        int opcion = 0;
        Guerrero gerrero;
        Mago mago;
        Npc npc;
        Arquero arquero;
        Plantilla personaje;
        SeleccionPrreyRes seleccionpreyres;

        public OpcionesDeAtacarPersonaje(Plantilla plantilla, Npc npc1)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.LightBlue200,
                TextShade.WHITE
            );

            this.StartPosition = FormStartPosition.CenterScreen;
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
                case "SAMURAI": { gerrero = new Guerrero(plantilla.id, plantilla.clase, plantilla.nombre, plantilla.vida, plantilla.mana, plantilla.fuerza, plantilla.defensa, plantilla.armaid); } break;
                case "MAGO": { mago = new Mago(plantilla.id, plantilla.clase, plantilla.nombre, plantilla.vida, plantilla.mana, plantilla.fuerza, plantilla.defensa, plantilla.armaid); } break;
                case "GUERRERO": { arquero = new Arquero(plantilla.id, plantilla.clase, plantilla.nombre, plantilla.vida, plantilla.mana, plantilla.fuerza, plantilla.defensa, plantilla.armaid); } break;
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
                case "SAMURAI": { MostrarInfoGerrero(); } break;
                case "MAGO": { MostrarInfoMago(); } break;
                case "GUERRERO": { MostrarInfoArquero(); } break;
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

        private void Cancelar_Click(object sender, EventArgs e)
        {
            opcion = 0;
            this.Close();
        }
    }
}
