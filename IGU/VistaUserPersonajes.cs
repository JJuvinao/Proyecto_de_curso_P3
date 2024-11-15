using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IGU
{
    public partial class VistaUserPersonajes : Form
    {

        User usuario;
        PersonajeService personajeService;
        UserPersonajeService userPersonajeservice;
        PuntajeService puntajeService;
        List<Plantilla> personajes = new List<Plantilla>();
        Plantilla persocontrol = new Plantilla();
        bool bt1validar, bt2validar, bt3validar;


        public VistaUserPersonajes(User user)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            personajeService = new PersonajeService();
            usuario = user;
            MostrarUsuario(user);
            userPersonajeservice = new UserPersonajeService(user.Id);
            CargarPersonajes();
            puntajeService = new PuntajeService(user.Id);
            MostraPuntaje();
            ValidarRol();
        }

        private void Btpersonaje1_Click(object sender, EventArgs e)
        {
            if (personajes.Count >= 1)
            {
                PasarVista(bt1validar, personajes[0]);
            }
            else
            {
                PasarVista(bt2validar, persocontrol);
            }
        }

        private void Btpersonaje2_Click(object sender, EventArgs e)
        {
            if (personajes.Count >= 2)
            {
                PasarVista(bt2validar, personajes[1]);
            }
            else
            {
                PasarVista(bt2validar, persocontrol);
            }
        }

        private void Btpersonaje3_Click(object sender, EventArgs e)
        {
            if (personajes.Count >= 3)
            {
                PasarVista(bt3validar, personajes[2]);
            }
            else
            {
                PasarVista(bt3validar, persocontrol);
            }
        }

        private void BtVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PasarVista(bool Btvalidar, Plantilla plantilla)
        {
            if (Btvalidar == false)
            {
                this.Hide();
                new VistaEscojerPersonaje(usuario).ShowDialog();
            }
            else
            {
                this.Hide();
                new VistaMundo(usuario, plantilla).ShowDialog();
                this.Close();
            }
        }

        private void ValidarRol()
        {
            if (usuario.Rol == "Profesor")
            {
                BtPreguntas.Enabled = true;
                BtPreguntas.Visible = true;
            }
        }

        private void MostrarUsuario(User usuario)
        {
            if (usuario == null)
            {
                MessageBox.Show("No hay un usuario");
            }
            else
            {
                txtnombre.Text = usuario.Name;
                txtrol.Text = usuario.Rol;
            }
        }

        private void MostraPuntaje()
        {
            tablapuntaje.DataSource = puntajeService.GetTabla();
        }

        private void BtCONFIGURACION_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FUNCIONES EN DASARROLLO");
        }

        private void BtPreguntas_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaConsultaPreguntasYRespestas(usuario).ShowDialog();
            this.Close();
        }

        private void CargarPersonajes()
        {
            List<int> id_personajes = userPersonajeservice.Getlis();
            if (id_personajes.Count == 0)
            {
                CargarBotonesPersonajes(0, 0, 0, personajes);
            }
            else
            {
                for (int i = 0; i < id_personajes.Count; i++)
                {
                    Plantilla perso = personajeService.GetId(id_personajes[i]);
                    if (perso != null)
                    {
                        personajes.Add(perso);
                    }
                    else
                    {
                        MessageBox.Show("Ocurruio un error en cargar lista de personajes.No existe el personaje");
                    }
                }

                switch (id_personajes.Count)
                {
                    case 1: { CargarBotonesPersonajes(1, 0, 0, personajes); }; break;
                    case 2: { CargarBotonesPersonajes(1, 2, 0, personajes); }; break;
                    case 3: { CargarBotonesPersonajes(1, 2, 3, personajes); }; break;
                }
            }

        }

        private void CargarBotonesPersonajes(int indx1, int indx2, int indx3, List<Plantilla> personajes)
        {
            if (indx1 == 0)
            {
                Btpersonaje1.Text = "NEW ...";
                bt1validar = false;
            }
            else
            {
                bt1validar = true;
                Btpersonaje1.Text = personajes[0].nombre + "\n" + personajes[0].clase;
            }
            if (indx2 == 0)
            {
                Btpersonaje2.Text = "NEW ...";
                bt2validar = false;
            }
            else
            {
                bt2validar = true;
                Btpersonaje2.Text = personajes[1].nombre + "\n" + personajes[1].clase;
            }
            if (indx3 == 0)
            {
                Btpersonaje3.Text = "NEW ...";
                bt3validar = false;
            }
            else
            {
                bt3validar = true;
                Btpersonaje3.Text = personajes[2].nombre + "\n" + personajes[2].clase;
            }
        }
    }
}
