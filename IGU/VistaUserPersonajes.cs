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
    public partial class VistaUserPersonajes : Form
    {
        public VistaUserPersonajes()
        {
            InitializeComponent();
        }

        private void Btpersonaje1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaMundo().ShowDialog();
            this.Close();
        }

        private void Btpersonaje2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaMundo().ShowDialog();
            this.Close();
        }

        private void Btpersonaje3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaMundo().ShowDialog();
            this.Close();
        }

        private void BtVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
            this.Close();
        }
    }
}
