using BLL;
using Entity;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace IGU
{
    public partial class AccionesPerso : Form
    {
        OpcionesPerso opcion;
        Plantilla gerrero = new Plantilla(1, "gerrero", "hola", 2000, 5, 250, 100, 12);
        Npc npc = new Npc(2, "mago", "npc", 2000, 250, 70, 5);
        GestorAcciones gestorAcciones;
        string Rutafondo,Rutapiso;

        public AccionesPerso(string fondo,string piso)
        {
            InitializeComponent();
            Estadisticas();
            gestorAcciones = new GestorAcciones(gerrero, npc);
            ValidarSitieneMana();
            Rutafondo = fondo;
            Rutapiso = piso;
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

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Paint += new PaintEventHandler(panel1_Paint);
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;

            pictureBox2.Image = Image.FromFile("D:\\Users\\lpove\\Desktop\\P3proyect\\Carpeta Diseños\\inicial1.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.BringToFront();

            pictureBox3.Image = Image.FromFile("D:\\Users\\lpove\\Desktop\\P3proyect\\Carpeta Diseños\\smile.gif");
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.BringToFront();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Image fondo = Image.FromFile(Rutafondo);
            Image frente = Image.FromFile(Rutapiso);

            Bitmap combinado = new Bitmap(fondo.Width, frente.Height);
            using (Graphics g = Graphics.FromImage(combinado))
            {
                g.DrawImage(fondo, 0, 0);
                g.DrawImage(frente, 0, 0);
            }
            e.Graphics.DrawImage(combinado, new Rectangle(0,0,panel1.Width,panel1.Height));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaUserPersonajes().ShowDialog();
            this.Close();
        }

        private void Btpruebaant_Click(object sender, EventArgs e)
        {
            Rutafondo = "D:\\Users\\lpove\\Desktop\\P3proyect\\Carpeta Diseños\\fondo2.jfif";
            Rutafondo = "D:\\Users\\lpove\\Desktop\\P3proyect\\Carpeta Diseños\\piso02.png";
            panel1.Paint += new PaintEventHandler(panel1_Paint);
        }

        private void Btpruebasig_Click(object sender, EventArgs e)
        {
            Rutafondo = "D:\\Users\\lpove\\Desktop\\P3proyect\\Carpeta Diseños\\fondo1.jfif";
            Rutafondo = "D:\\Users\\lpove\\Desktop\\P3proyect\\Carpeta Diseños\\piso02.png";
            panel1.Paint += new PaintEventHandler(panel1_Paint);
        }
    }
}
