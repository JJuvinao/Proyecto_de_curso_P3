using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace IGU
{
    public partial class VistaMundo : Form
    {
        User user;
        Plantilla personaje;
        AccionesPerso accionesPerso;
        MundoService mundoService;
        List<Mundo> mundos;
        string ruta = "D:\\Users\\lpove\\Desktop\\P3proyect\\Carpeta Diseños\\Fondos\\", fondo01, fondo02, fondo03,
            predeterminado = "fondopredeterminado.png";
        int start = 0, pagesize = 3, end;
        public VistaMundo(User usuario, Plantilla plantilla)
        {
            InitializeComponent();
            accionesPerso = new AccionesPerso();
            mundoService = new MundoService();
            mundos = mundoService.GetAll();
            user = usuario;
            personaje = plantilla;
            MostrarFondos();
        }

        private void Btanterior_Click(object sender, EventArgs e)
        {
            start -= pagesize;
            MostrarFondos();
        }

        private void MostrarFondos()
        {
            ValidarBotones();
            AsignarFondos();
            CargarPicture();
            panel01.Controls.Add(picture1);
            panel02.Controls.Add(picture2);
            panel03.Controls.Add(picture3);
        }

        private void Btsiguiente_Click(object sender, EventArgs e)
        {
            start += pagesize;
            MostrarFondos();
        }

        private void AsignarFondos()
        {
            int intervalo = start + pagesize;
            int faltante = Math.Abs(mundos.Count - intervalo);
            if (intervalo <= mundos.Count)
            {
                fondo01 = mundos[start].Fondo;
                txtmundo1.Text = mundos[start].Nombre;
                fondo02 = mundos[start + 1].Fondo;
                txtmundo2.Text = mundos[start+1].Nombre;
                fondo03 = mundos[start + 2].Fondo;
                txtmundo3.Text = mundos[start+2].Nombre;
            }
            else
            {
                switch (faltante)
                {
                    case 1:
                        {
                            fondo01 = mundos[start].Fondo;
                            txtmundo1.Text = mundos[start].Nombre;
                            fondo02 = mundos[start + 1].Fondo;
                            txtmundo2.Text = mundos[start + 1].Nombre;
                            fondo03 = predeterminado;
                            txtmundo3.Text = "";
                        }
                        break;
                    case 2:
                        {
                            fondo01 = mundos[start].Fondo;
                            txtmundo1.Text = mundos[start].Nombre;
                            fondo02 = predeterminado;
                            txtmundo2.Text = "";
                            fondo03 = predeterminado;
                            txtmundo3.Text = "";
                        }
                        break;
                    default:
                        {
                            fondo01 = predeterminado;
                            txtmundo1.Text = "";
                            fondo02 = predeterminado;
                            txtmundo2.Text = "";
                            fondo03 = predeterminado;
                            txtmundo3.Text = "";
                        }
                        break;
                }
            }
        }

        private void CargarPicture()
        {
            Image fondo3 = Image.FromFile(ruta + fondo03);
            Image fondo2 = Image.FromFile(ruta + fondo02);
            Image fondo1 = Image.FromFile(ruta + fondo01);
            picture1.Dock = DockStyle.Fill;
            picture1.SizeMode = PictureBoxSizeMode.Zoom;
            picture1.Image = fondo1;
            picture2.Dock = DockStyle.Fill;
            picture2.SizeMode = PictureBoxSizeMode.Zoom;
            picture2.Image = fondo2;
            picture3.Dock = DockStyle.Fill;
            picture3.SizeMode = PictureBoxSizeMode.Zoom;
            picture3.Image = fondo3;
        }

        private void ValidarBotones()
        {
            if (start <= 0)
            {
                Btanterior.Enabled = false;
            }
            else
            {
                Btanterior.Enabled = true;
            }

            if (start >= mundos.Count)
            {
                Btsiguiente.Enabled = false;
            }
            else
            {
                Btsiguiente.Enabled = true;
            }
        }

        private void Btfondo1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AccionesPerso(ruta + fondo01, user, personaje).ShowDialog();
            this.Close();
        }

        private void Btfondo2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AccionesPerso(ruta + fondo02, user, personaje).ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AccionesPerso(ruta + fondo03, user, personaje).ShowDialog();
            this.Close();
        }
    }
}
