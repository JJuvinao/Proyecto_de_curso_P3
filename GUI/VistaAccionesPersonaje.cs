using Entity;
using IGU;
using BLL;
using Animaciones;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class VistaAccionesPersonaje : MaterialForm
    {

        OpcionesDeAtacarPersonaje opcion;
        PuntajeService puntajeService;
        OpcionDeBuffer opcionBuffer;
        User user;
        Mundo mundo;
        Puntajes puntaje;
        Plantilla personaje_actual;
        Npc npc;
        GestorAcciones gestorAcciones;
        IcrudAnimacion animacion;
        AnimacionVarias animacionVarias;
        AniNpcs aniNpcs;
        NPCservice npcservise;
        string Rutafondo;
        bool turno = true;
        int puntajejugar = 0;

        public VistaAccionesPersonaje(string fondo, User usser, Mundo mund, Plantilla plantilla)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Yellow800,
                MaterialSkin.Primary.Yellow900,
                MaterialSkin.Primary.Green600,
                MaterialSkin.Accent.LightGreen200,
                MaterialSkin.TextShade.WHITE
            );
            this.StartPosition = FormStartPosition.CenterScreen;
            personaje_actual = plantilla;
            npcservise = new NPCservice();
            AsignarNpc();
            user = usser;
            mundo = mund;
            gestorAcciones = new GestorAcciones(personaje_actual, npc);
            aniNpcs = new AniNpcs();
            animacionVarias = new AnimacionVarias();
            Rutafondo = fondo;
            AsignacionAnimacion(plantilla.clase);
            GestionarBotones(1);
            Estadisticas();
            puntajeService = new PuntajeService(user.Id);
            PicturePersonaje2.BackColor = Color.Transparent;
            PicturePersonaje.BackColor = Color.Transparent;
            PictureNpc1.BackColor = Color.Transparent;
            PictureNpc1.BringToFront();
            PictureNpc2.BackColor = Color.Transparent;
            sangrenpc.BackColor = Color.Transparent;
            sangrenpc.BringToFront();
            sangrepersonaje.BackColor = Color.Transparent;
            sangrepersonaje.BringToFront();
            MostrarIncial();
        }

        private async void materialBtnAtacar_Click(object sender, EventArgs e)
        {

            if (personaje_actual.mana >= 5)
            {
                int opc;
                opcion = new OpcionesDeAtacarPersonaje(personaje_actual, npc);
                opcion.ShowDialog();
                opc = opcion.Prueba();
                puntajejugar += 110;
                if (opc != 0)
                {
                    GestionarBotones(2);
                    switch (opc)
                    {
                        case 1: { AnimacionAtaque1(personaje_actual.clase); }; break;
                        case 2: { AnimacionAtaque2(personaje_actual.clase); }; break;
                        case 3: { AnimacionAtaque3(personaje_actual.clase); }; break;
                    }
                    Atacar(opc, turno);
                    turno = false;
                    await Task.Delay(2800);
                    AccionNpc();
                }
            }
            else
            {
                labelMensaje.Text = "NO TIENE SUFICIENTE MANA PARA ATACAR";
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
                GestionarBotones(2);
                AccionNpc();
            }
            await Task.Delay(1500);
            AnimacionInicial();
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
                await Task.Delay(1500);
                AnimacionInicial();
            }
        }

        private void Btrendirse_Click(object sender, EventArgs e)
        {

        }

        private void Btvolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaUserPersonajes(user).ShowDialog();
            this.Close();
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

        #region METODOS

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
                AnimacionMorirPersonaje();
                puntajejugar = 0;
                puntaje = new Puntajes(user.Id, mundo.Id, puntajejugar);
                RegistrarPuntaje();
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
                AnimacionMorirNpc();
                puntaje = new Puntajes(user.Id, mundo.Id, puntajejugar);
                RegistrarPuntaje();
            }
        }

        private void GestionarBotones(int turno)
        {
            if (turno == 1)
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

        private void RegistrarPuntaje()
        {
            var msg = puntajeService.Registrar(puntaje);
            MessageBox.Show(msg);
        }

        private void AsignarNpc()
        {
            npc = npcservise.GetId("01_LOBO");
        }

        private void AsignacionAnimacion(string clase)
        {
            switch (clase)
            {
                case "SAMURAI": { animacion = new AniSamurai(); } break;
                case "MAGO": { animacion = new AniMago(); } break;
                case "GUERRERO": { animacion = new AniKnight(); } break;
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
                Estadisticas();
                ValidarVidaPersonaje();
                ValidarVidaNpc();
            }
        }

        private async void AccionNpc()
        {
            int opcnpc = gestorAcciones.GeneradorOpcion();
            if (opcnpc == 4)
            {
                AnimaNpcDefender();
                npc.Defender(turno);
                await Task.Delay(1000);
            }
            else
            {
                AnimacionesNpc(opcnpc);
                Atacar(opcnpc, turno);
                await Task.Delay(2800);
            }
            turno = true;
            GestionarBotones(1);
        }

        private async void MostraPerso(string posicion1, string[] posicion2)
        {
            PicturePersonaje.Visible = false;
            await Task.Delay(300);
            PicturePersonaje2.Visible = true;
            PicturePersonaje2.Image = Image.FromFile(posicion2[0]);
            PicturePersonaje2.SizeMode = PictureBoxSizeMode.StretchImage;
            sangrenpc.Visible = true;
            sangrenpc.Image = Image.FromFile(animacionVarias.Mostrarsangre());
            sangrenpc.SizeMode = PictureBoxSizeMode.StretchImage;
            await Task.Delay(2000);
            sangrenpc.Visible = false;
            PicturePersonaje2.Visible = false;
            PicturePersonaje.Visible = true;
            PicturePersonaje.Image = Image.FromFile(posicion1);
            PicturePersonaje.SizeMode = PictureBoxSizeMode.StretchImage;
            await Task.Delay(2000);
        }


        private async void MostraPersoMago(string posicion1, string[] posicion2)
        {
            PicturePersonaje.Image = Image.FromFile(posicion2[0]);
            PicturePersonaje.SizeMode = PictureBoxSizeMode.StretchImage;
            await Task.Delay(800);
            PicturePersonaje2.Visible = true;
            PicturePersonaje2.Image = Image.FromFile(posicion2[1]);
            PicturePersonaje2.SizeMode = PictureBoxSizeMode.StretchImage;
            PicturePersonaje2.BringToFront();
            sangrenpc.Visible = true;
            sangrenpc.Image = Image.FromFile(animacionVarias.Mostrarsangre());
            sangrenpc.SizeMode = PictureBoxSizeMode.StretchImage;
            await Task.Delay(1500);
            sangrenpc.Visible = false;
            PicturePersonaje2.Visible = false;
            await Task.Delay(700);
            PicturePersonaje.Image = Image.FromFile(animacion.GetPosicionInicial());
            PicturePersonaje.SizeMode = PictureBoxSizeMode.StretchImage;
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

        private async void AnimacionMorirPersonaje()
        {
            PicturePersonaje.Image = Image.FromFile(animacion.GetMorir1());
            PicturePersonaje.SizeMode = PictureBoxSizeMode.StretchImage;
            await Task.Delay(500);
            PicturePersonaje.Image = Image.FromFile(animacion.GetMorir2());
            PicturePersonaje.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void AnimacionMorirNpc()
        {
            PictureNpc1.Image = Image.FromFile(aniNpcs.GetMorir());
            PictureNpc1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureNpc1.BringToFront();
        }

        private void AnimacionInicial()
        {
            PicturePersonaje.Image = Image.FromFile(animacion.GetPosicionInicial());
            PicturePersonaje.SizeMode = PictureBoxSizeMode.StretchImage;
            PicturePersonaje.BringToFront();
        }

        private void AnimacionDefender()
        {
            PicturePersonaje.Image = Image.FromFile(animacion.GetPosicionDefender());
            PicturePersonaje.SizeMode = PictureBoxSizeMode.StretchImage;
            PicturePersonaje.BringToFront();
        }

        private void AnimacionBuffer()
        {
            PicturePersonaje.Image = Image.FromFile(animacion.GetAccionMejora());
            PicturePersonaje.SizeMode = PictureBoxSizeMode.StretchImage;
            PicturePersonaje.BringToFront();
        }

        private void AnimacionesNpc(int opc)
        {
            switch (opc)
            {
                case 1: { MostrarAnimacionNpc(aniNpcs.GetAtacar1(), aniNpcs.GetPosicionInicial()); }; break;
                case 2: { MostrarAnimacionNpc(aniNpcs.GetAtacar2(), aniNpcs.GetPosicionInicial()); }; break;
                case 3: { MostrarAnimacionNpc(aniNpcs.GetAtacar3(), aniNpcs.GetPosicionInicial()); }; break;
            }
        }

        private async void MostrarAnimacionNpc(string posicion1, string posicion2)
        {
            PictureNpc1.Visible = false;
            await Task.Delay(300);
            PictureNpc2.Visible = true;
            PictureNpc2.Image = Image.FromFile(posicion1);
            PictureNpc2.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureNpc2.BringToFront();
            sangrepersonaje.Visible = true;
            sangrepersonaje.Image = Image.FromFile(animacionVarias.Mostrarsangre());
            sangrepersonaje.SizeMode = PictureBoxSizeMode.StretchImage;
            await Task.Delay(2000);
            sangrepersonaje.Visible = false;
            PictureNpc2.Visible = false;
            PictureNpc1.Visible = true;
            PictureNpc1.Image = Image.FromFile(posicion2);
            PictureNpc1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureNpc1.BringToFront();
            await Task.Delay(2000);
        }

        private void AnimaNpcDefender()
        {
            PictureNpc1.Image = Image.FromFile(aniNpcs.GetPosicionDefender());
            PictureNpc1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureNpc1.BringToFront();
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
            PictureNpc1.Image = Image.FromFile(aniNpcs.GetPosicionInicial());
            PictureNpc1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureNpc1.BringToFront();
        }

        #endregion
    }
}
