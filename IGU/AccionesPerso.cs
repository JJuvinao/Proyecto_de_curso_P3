using BLL;
using Entity;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace IGU
{
    public partial class AccionesPerso : Form
    {
        OpcionesDeAtacarPersonaje opcion;
        OpcionDeBuffer opcionBuffer;
        User user;
        Plantilla personaje_actual;
        Npc npc = new Npc(2, "mago", "npc", 2000, 250, 40, 5);
        GestorAcciones gestorAcciones;
        string Rutafondo, Rutapiso;

        public AccionesPerso() { }
        public AccionesPerso(string fondo, string piso, User usser, Plantilla plantilla)
        {
            InitializeComponent();
            personaje_actual = plantilla;
            Estadisticas();
            gestorAcciones = new GestorAcciones(personaje_actual, npc);
            Rutafondo = fondo;
            Rutapiso = piso;
            user = usser;
        }

        private void ValidarVidaPersonaje()
        {
            if (personaje_actual.SigueVivo())
            {
                Btataque.Enabled = true;
            }
            else
            {
                Btataque.Enabled = false;
                personaje_actual.Morir();
            }
        }

        private void ValidarVidaNpc()
        {
            if (npc.SigueVivo())
            {
                Btataque.Enabled = true;
            }
            else
            {
                Btataque.Enabled = false;
                npc.Morir();
            }
        }

        private void Estadisticas()
        {
            //personaje
            labelperso.Text = personaje_actual.nombre;
            labelvida.Text = personaje_actual.vida.ToString();
            labelmana.Text = personaje_actual.mana.ToString();
            labelfuerza.Text = personaje_actual.fuerza.ToString();
            labeldefensa.Text = personaje_actual.defensa.ToString();
            //npc
            lbnpcnom.Text = npc.nombre;
            lbnpcvida.Text = npc.vida.ToString();
            lbnpcfuerza.Text = npc.fuerza.ToString();
            lbnpcdefensa.Text = npc.defensa.ToString();
        }

        private void Btataque_Click(object sender, EventArgs e)
        {
            if (personaje_actual.mana >= 5)
            {
                int opc, danio = 0;
                opcion = new OpcionesDeAtacarPersonaje(personaje_actual, npc);
                opcion.ShowDialog();
                opc = opcion.Prueba();
                txtopcion.Text = opc.ToString();
                if (opc != 0)
                {
                    danio = gestorAcciones.Atacar(opc);
                    txtdanio.Text = gestorAcciones.RecibirDanio(danio);
                    Estadisticas();
                    ValidarVidaPersonaje();
                    ValidarVidaNpc();
                }
            }
            else
            {
                labelMensaje.Text = "NO TIENE SUFICIENTE MANA PARA ATACAR";
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
            e.Graphics.DrawImage(combinado, new Rectangle(0, 0, panel1.Width, panel1.Height));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaUserPersonajes(user).ShowDialog();
            this.Close();
        }

        private void Btpruebaant_Click(object sender, EventArgs e)
        {
            Rutafondo = "D:\\Users\\lpove\\Desktop\\P3proyect\\Carpeta Diseños\\fondo2.jfif";
            Rutafondo = "D:\\Users\\lpove\\Desktop\\P3proyect\\Carpeta Diseños\\piso02.png";
            panel1.Paint += new PaintEventHandler(panel1_Paint);
        }

        private void Btbeffer_Click(object sender, EventArgs e)
        {
            int opc;
            opcionBuffer = new OpcionDeBuffer();
            opcionBuffer.ShowDialog();
            opc = opcionBuffer.Ocpcion();
            if (opc != 0)
            {
                string msg = gestorAcciones.Beffer(opc);
                labelMensaje.Text = msg;
                Estadisticas();
            }
        }

        private void Btpruebasig_Click(object sender, EventArgs e)
        {
            Rutafondo = "D:\\Users\\lpove\\Desktop\\P3proyect\\Carpeta Diseños\\fondo1.jfif";
            Rutafondo = "D:\\Users\\lpove\\Desktop\\P3proyect\\Carpeta Diseños\\piso02.png";
            panel1.Paint += new PaintEventHandler(panel1_Paint);
        }
    }
}
