using Entity;
using System;
using System.Windows.Forms;

namespace IGU
{
    public partial class VistaMundo : Form
    {
        User user;
        Plantilla personaje;
        AccionesPerso accionesPerso = new AccionesPerso();
        public VistaMundo(User usuario, Plantilla plantilla)
        {
            InitializeComponent();
            user = usuario;
            personaje = plantilla;
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
            new AccionesPerso("D:\\Users\\lpove\\Desktop\\P3proyect\\Carpeta Diseños\\fondo1.jfif", "D:\\Users\\lpove\\Desktop\\P3proyect\\Carpeta Diseños\\piso02.png", user, personaje).ShowDialog();
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
            new AccionesPerso("D:\\Users\\lpove\\Desktop\\P3proyect\\Carpeta Diseños\\fondo2.jfif", "D:\\Users\\lpove\\Desktop\\P3proyect\\Carpeta Diseños\\piso02.png", user, personaje).ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AccionesPerso("D:\\Users\\lpove\\Desktop\\P3proyect\\Carpeta Diseños\\fondo03.png", "D:\\Users\\lpove\\Desktop\\P3proyect\\Carpeta Diseños\\piso02.png", user, personaje).ShowDialog();
            this.Close();
        }
    }
}
