using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGU
{
    public partial class VistaMundo : Form
    {
        public VistaMundo()
        {
            InitializeComponent();
        }

        private void Btfondo1_Click(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(Environment.CurrentDirectory, "Resources", "fondo1.jfif");

            if (File.Exists(imagePath))
            {
                Picture.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show("La imagen no se encuentra");
            }
        }

        private void Btfondo2_Click(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(Environment.CurrentDirectory, "Resources", "fondo2.jfif");

            if (File.Exists(imagePath))
            {
                Picture.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show(imagePath);
                MessageBox.Show("La imagen no se encuentra");
            }
        }
    }
}
