using Entity;
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
        User user;
         AccionesPerso accionesPerso = new AccionesPerso();
        public VistaMundo()
        {
            InitializeComponent();
        }

        public void RecibirUser(User usuario)
        {
            user = usuario;
        }
        private void Btfondo1_Click(object sender, EventArgs e)
        {
            //string imagePath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName, "imagenes", "fondo1.jfif");

            //if (File.Exists(imagePath))
            //{
            //    Picture.Image = Image.FromFile(imagePath);
            //}
            //else
            //{
            //    MessageBox.Show("La imagen no se encuentra");
            //}
            this.Hide();
            new AccionesPerso("D:\\Users\\lpove\\Desktop\\P3proyect\\Carpeta Diseños\\fondo1.jfif", "D:\\Users\\lpove\\Desktop\\P3proyect\\Carpeta Diseños\\piso02.png").ShowDialog();
            this.Close();
        }

        private void Btfondo2_Click(object sender, EventArgs e)
        {
            //string imagePath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName, "imagenes", "fondo2.jfif");

            //if (File.Exists(imagePath))
            //{
            //    Picture.Image = Image.FromFile(imagePath);
            //}
            //else
            //{
            //    MessageBox.Show("La imagen no se encuentra");
            //}
            this.Hide();
            new AccionesPerso("D:\\Users\\lpove\\Desktop\\P3proyect\\Carpeta Diseños\\fondo2.jfif", "D:\\Users\\lpove\\Desktop\\P3proyect\\Carpeta Diseños\\piso02.png").ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AccionesPerso("D:\\Users\\lpove\\Desktop\\P3proyect\\Carpeta Diseños\\fondo03.png", "D:\\Users\\lpove\\Desktop\\P3proyect\\Carpeta Diseños\\piso02.png").ShowDialog();
            accionesPerso.RecibirUser(user);
            this.Close();
        }
    }
}
