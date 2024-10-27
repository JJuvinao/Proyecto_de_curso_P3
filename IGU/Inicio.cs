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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaPreg_Y_Resp().ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaUser().ShowDialog();
            this.Close();
        }

        private void Btsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void Btmundos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaMundo().ShowDialog();
            this.Close();
        }

        private void Btacciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AccionesPerso().ShowDialog();
            this.Close();
        }
    }
}
