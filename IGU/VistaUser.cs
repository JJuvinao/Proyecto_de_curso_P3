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
    public partial class VistaUser : Form
    {
        public VistaUser()
        {
            InitializeComponent();
        }

        private void Btvisi_Click(object sender, EventArgs e)
        {
            if(Btop.Visible == true)
            {
                Btop.Visible = false;
            }
            else
            {
                Btop.Visible = true;
            }
        }

        private void BtVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Inicio().ShowDialog();
            this.Close();
        }
    }
}
