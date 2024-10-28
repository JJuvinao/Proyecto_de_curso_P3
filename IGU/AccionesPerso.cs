using BLL;
using Entity;
using System;
using System.Windows.Forms;

namespace IGU
{
    public partial class AccionesPerso : Form
    {
        OpcionesPerso opcion;
        Plantilla gerrero = new Plantilla(1, "gerrero", "hola", 2000, 5, 250, 100, 12);
        Npc npc = new Npc(2, "mago", "npc", 2000, 250, 70, 5);
        GestorAcciones gestorAcciones;

        public AccionesPerso()
        {
            InitializeComponent();
            Estadisticas();
            gestorAcciones = new GestorAcciones(gerrero, npc);
            ValidarSitieneMana();
        }

        private void ValidarSitieneMana()
        {
            if(gestorAcciones.ValidarMana())
            {
                Btataque.Enabled = true;
            }
            else
            {
                Btataque.Enabled = false;
            }
        }

        private void Estadisticas()
        {
            //personaje
            labelperso.Text = gerrero.nombre;
            labelvida.Text = gerrero.vida.ToString();
            labelmana.Text = gerrero.mana.ToString();
            labelfuerza.Text = gerrero.fuerza.ToString();
            labeldefensa.Text = gerrero.defensa.ToString();
            //npc
            lbnpcnom.Text = npc.nombre;
            lbnpcvida.Text = npc.vida.ToString();
            lbnpcfuerza.Text = npc.fuerza.ToString();
            lbnpcdefensa.Text = npc.defensa.ToString();
        }
        private void Btataque_Click(object sender, EventArgs e)
        {
            int opc,danio=0;
            opcion = new OpcionesPerso(gerrero, npc);
            opcion.ShowDialog();
            opc = opcion.Prueba();
            txtopcion.Text = opc.ToString();
            if (opc != 0) 
            {
                danio = gestorAcciones.Atacar(opc);
                txtdanio.Text = gestorAcciones.RecibirDanio(danio);
                Estadisticas();
            }
        }

        private void Btsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
