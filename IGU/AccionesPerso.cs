using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGU
{
    public partial class AccionesPerso : Form
    {
        OpcionesPerso opcion = new OpcionesPerso();
        Gerrero gerrero = new Gerrero(1, "gerrero", "hola", 200, 30, 250, 100, 12);
        public AccionesPerso()
        {
            InitializeComponent();
            Estadisticas();
        }

        private void Estadisticas()
        {
            labelperso.Text = gerrero.nombre;
            labelvida.Text = gerrero.vida.ToString();
            labelmana.Text = gerrero.mana.ToString();
            labelfuerza.Text = gerrero.fuerza.ToString();
            labeldefensa.Text = gerrero.defensa.ToString();
        }
        private void Btataque_Click(object sender, EventArgs e)
        {
            opcion.ShowDialog();
            txtopcion.Text = opcion.Prueba().ToString();
        }

        private void Btsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
