using BLL;
using Entity;
using MaterialSkin;
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
    public partial class VistaUserPersonajes : MaterialForm
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

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.LightBlue200,
                TextShade.WHITE
            );
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

        private void materialBtnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeDprb().ShowDialog();
            this.Close();
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

        private void Btpreguntas_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaConsulPrgRp(usuario).ShowDialog();
            this.Close();
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar el usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Hide();
                new VistaEliminarUsuarios(usuario).ShowDialog();
                this.Close();
            }
        }

        #region METODOS

        private void ValidarRol()
        {
            if (usuario.Rol == "Profesor")
            {
                BtPreguntas.Enabled = true;
                BtPreguntas.Visible = true;
            }
        }

        private void VistaUserPersonajes_Load(object sender, EventArgs e)
        {
            tablapuntaje.ForeColor = Color.Black;
        }

        private void MostraPuntaje()
        {
            tablapuntaje.DataSource = puntajeService.GetTabla();
        }

        private void PasarVista(bool Btvalidar, Plantilla plantilla)
        {
            if (Btvalidar == false)
            {
                this.Hide();
                new VistaEscogerPersonajes(usuario).ShowDialog();
            }
            else
            {
                this.Hide();
                new VistaMundos(usuario, plantilla).ShowDialog();
                this.Close();
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

        #endregion


    }
}
