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
    public partial class OpcionesPerso : Form
    {
        public int opcion = 0;
        Gerrero gerrero = new Gerrero(1, "gerrero", "hola", 200, 30, 250, 100, 12);
        public OpcionesPerso()
        {
            InitializeComponent();
            MostrarInfomacion();
        }

        #region Metodos

        public int Prueba()
        {
            return opcion;
        }

        private void MostrarInfomacion()
        {
            labelbasico.Text = gerrero.Basico(gerrero.defensa);
            labelhab1.Text = gerrero.Hab1(gerrero.defensa);
            labelhab2.Text = gerrero.Hab2(gerrero.defensa);
            labelcancelar.Text = "Cancelar el ataque";
        }

        #endregion
        private void button4_Click(object sender, EventArgs e)
        {
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
