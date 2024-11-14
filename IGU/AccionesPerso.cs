using Animaciones;
using BLL;
using Entity;
using System;
using System.Drawing;
using System.Threading.Tasks;
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
        IcrudAnimacion animacion;
        string Rutafondo;
        bool turno = true;

        public AccionesPerso() { }
        public AccionesPerso(string fondo, User usser, Plantilla plantilla)
        {
            InitializeComponent();
            personaje_actual = plantilla;
            Estadisticas();
            gestorAcciones = new GestorAcciones(personaje_actual, npc);
            Rutafondo = fondo;
            user = usser;
            AsignacionAnimacion(plantilla.clase);
            GestionarBotones();
            PicturePersonaje2.BackColor = Color.Transparent;
            PicturePersonaje.BackColor = Color.Transparent;
            PictureNpc.BackColor = Color.Transparent;
            MostrarIncial();
        }

        private void ValidarVidaPersonaje()
        {
            if (personaje_actual.vida <= 0)
            {
                Btataque.Enabled = false;
                Btbeffer.Enabled = false;
                Btdefender.Enabled = false;
                personaje_actual.Morir();
                Estadisticas();
                MessageBox.Show("murio el personaje");
                AnimacionMorir();
            }
        }

        private void ValidarVidaNpc()
        {
            if (npc.vida <= 0)
            {
                Btataque.Enabled = false;
                Btbeffer.Enabled = false;
                Btdefender.Enabled = false;
                npc.Morir();
                Estadisticas();
                MessageBox.Show("murio el npc");
            }
        }

        private void GestionarBotones()
        {
            if (turno)
            {
                Btataque.Enabled = true;
                Btbeffer.Enabled = true;
                Btdefender.Enabled = true;
            }
            else
            {
                Btataque.Enabled = false;
                Btbeffer.Enabled = false;
                Btdefender.Enabled = false;
            }
        }

        private void Estadisticas()
        {
            //personaje
            labelperso.Text = personaje_actual.nombre;
            labelclase.Text = personaje_actual.clase;
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

        private void AsignacionAnimacion(string clase)
        {
            switch (clase)
            {
                case "GERRERO": { animacion = new AniSamurai(); } break;
                case "MAGO": { animacion = new AniMago(); } break;
                case "ARQUERO": { animacion = new AniKnight(); } break;
            }
        }

        private void Atacar(int opc, bool turn)
        {
            string quienpega = (turn) ? "PERSONAJE" : "NPC";
            if (turn == false && opc == 4)
            {
                labelMensaje.Text = "NPC USO DEFENDER";
            }
            else
            {
                int danio = 0;
                danio = gestorAcciones.Atacar(opc, turno);
                labelMensaje.Text = quienpega + "\n" + gestorAcciones.RecibirDanio(danio, turno) + "\n" + danio;
            }
        }
        private void Btataque_Click(object sender, EventArgs e)
        {
            if (personaje_actual.mana >= 5)
            {
                int opc;
                opcion = new OpcionesDeAtacarPersonaje(personaje_actual, npc);
                opcion.ShowDialog();
                opc = opcion.Prueba();
                txtopcion.Text = opc.ToString();
                if (opc != 0)
                {
                    GestionarBotones();
                    switch (opc)
                    {
                        case 1: { AnimacionAtaque1(personaje_actual.clase); }; break;
                        case 2: { AnimacionAtaque2(personaje_actual.clase); }; break;
                        case 3: { AnimacionAtaque3(personaje_actual.clase); }; break;
                    }
                    Atacar(opc, turno);
                    Estadisticas();
                    ValidarVidaPersonaje();
                    ValidarVidaNpc();
                    turno = false;
                    AccionNpc();
                }
            }
            else
            {
                labelMensaje.Text = "NO TIENE SUFICIENTE MANA PARA ATACAR";
            }
        }

        private void AccionNpc()
        {
            int opcnpc = gestorAcciones.GeneradorOpcion();
            //switch (opcnpc)
            //{
            //    case 1: { AnimacionAtaque(); }; break;
            //    case 2: { } break;
            //}
            Atacar(opcnpc, turno);
            Estadisticas();
            ValidarVidaPersonaje();
            ValidarVidaNpc();
            turno = true;
            GestionarBotones();
        }

        private async void MostraPerso(string posicion1, string[] posicion2)
        {
            PicturePersonaje.Visible = false;
            await Task.Delay(300);
            PicturePersonaje2.Visible = true;
            PicturePersonaje2.Image = Image.FromFile(posicion2[0]);
            PicturePersonaje2.SizeMode = PictureBoxSizeMode.StretchImage;
            PicturePersonaje2.Location = new Point(190, 50);
            await Task.Delay(2000);
            PicturePersonaje2.Visible = false;
            PicturePersonaje.Visible = true;
            PicturePersonaje.Image = Image.FromFile(posicion1);
            PicturePersonaje.SizeMode = PictureBoxSizeMode.StretchImage;
            PicturePersonaje.Location = new Point(35, 50);
            await Task.Delay(2000);
        }


        private async void MostraPersoMago(string posicion1, string[] posicion2)
        {
            PicturePersonaje.Image = Image.FromFile(posicion2[0]);
            PicturePersonaje.SizeMode = PictureBoxSizeMode.StretchImage;
            PicturePersonaje.Location = new Point(35, 50);
            await Task.Delay(800);
            PicturePersonaje2.Visible = true;
            PicturePersonaje2.Image = Image.FromFile(posicion2[1]);
            PicturePersonaje2.SizeMode = PictureBoxSizeMode.StretchImage;
            PicturePersonaje2.BringToFront();
            PicturePersonaje2.Location = new Point(245, 50);
            await Task.Delay(1500);
            PicturePersonaje2.Visible = false;
            await Task.Delay(700);
            PicturePersonaje.Image = Image.FromFile(animacion.GetPosicionInicial());
            PicturePersonaje.SizeMode = PictureBoxSizeMode.StretchImage;
            PicturePersonaje.Location = new Point(35, 50);
            await Task.Delay(2000);
        }

        private void AnimacionAtaque1(string clase)
        {
            if (clase == "MAGO")
            {
                MostraPersoMago(animacion.GetPosicionInicial(), animacion.GetAtacar1());
            }
            else
            {
                MostraPerso(animacion.GetPosicionInicial(), animacion.GetAtacar1());
            }
        }

        private void AnimacionAtaque2(string clase)
        {
            if (clase == "MAGO")
            {
                MostraPersoMago(animacion.GetPosicionInicial(), animacion.GetAtacar2());
            }
            else
            {
                MostraPerso(animacion.GetPosicionInicial(), animacion.GetAtacar2());
            }
        }

        private void AnimacionAtaque3(string clase)
        {
            if (clase == "MAGO")
            {
                MostraPersoMago(animacion.GetPosicionInicial(), animacion.GetAtacar3());
            }
            else
            {
                MostraPerso(animacion.GetPosicionInicial(), animacion.GetAtacar3());
            }
        }

        private void AnimacionMorir()
        {
            PicturePersonaje.Image = Image.FromFile(animacion.GetMorir());
            PicturePersonaje.SizeMode = PictureBoxSizeMode.StretchImage;
            PicturePersonaje.Location = new Point(35, 50);
        }

        private void AnimacionInicial()
        {
            PicturePersonaje.Image = Image.FromFile(animacion.GetPosicionInicial());
            PicturePersonaje.SizeMode = PictureBoxSizeMode.StretchImage;
            PicturePersonaje.BringToFront();
            PicturePersonaje.Location = new Point(35, 50);
        }

        private void AnimacionDefender()
        {
            PicturePersonaje.Image = Image.FromFile(animacion.GetPosicionDefender());
            PicturePersonaje.SizeMode = PictureBoxSizeMode.StretchImage;
            PicturePersonaje.BringToFront();
            PicturePersonaje.Location = new Point(35, 50);
        }

        private void AnimacionBuffer()
        {
            PicturePersonaje.Image = Image.FromFile(animacion.GetAccionMejora());
            PicturePersonaje.SizeMode = PictureBoxSizeMode.StretchImage;
            PicturePersonaje.BringToFront();
            PicturePersonaje.Location = new Point(35, 50);
        }

        private void Btsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaUserPersonajes(user).ShowDialog();
            this.Close();
        }

        private void MostrarIncial()
        {
            PanelFondo.Paint += new PaintEventHandler(panel1_Paint);
            AnimacionInicial();
            PictureNpc.Image = Image.FromFile("D:\\Users\\lpove\\Desktop\\P3proyect\\Carpeta Diseños\\Personajes\\smile.gif");
            PictureNpc.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureNpc.BringToFront();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Image fondo = Image.FromFile(Rutafondo);

            Bitmap combinado = new Bitmap(fondo.Width, fondo.Height);
            using (Graphics g = Graphics.FromImage(combinado))
            {
                g.DrawImage(fondo, 0, 0);
                g.DrawImage(fondo, 0, 0);
            }
            e.Graphics.DrawImage(combinado, new Rectangle(0, 0, PanelFondo.Width, PanelFondo.Height));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaUserPersonajes(user).ShowDialog();
            this.Close();
        }

        private async void Btbeffer_Click(object sender, EventArgs e)
        {
            int opc;
            opcionBuffer = new OpcionDeBuffer();
            opcionBuffer.ShowDialog();
            opc = opcionBuffer.Ocpcion();
            if (opc != 0)
            {
                AnimacionBuffer();
                await Task.Delay(1500);
                string msg = gestorAcciones.Beffer(opc);
                labelMensaje.Text = msg;
                Estadisticas();
            }
        }

        private async void Btdefender_Click(object sender, EventArgs e)
        {
            AnimacionDefender();
            personaje_actual.Defender(turno);
            Estadisticas();
            ValidarVidaPersonaje();
            ValidarVidaNpc();
            if (Btataque.Enabled != false)
            {
                turno = false;
                GestionarBotones();
                AccionNpc();
            }
            await Task.Delay(1500);
            AnimacionInicial();
        }
    }
}
