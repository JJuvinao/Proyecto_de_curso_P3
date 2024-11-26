using BLL;
using Entity;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI
{
    public partial class VistaMundos : MaterialForm
    {
        User user;
        Plantilla personaje;
        MundoService mundoService;
        List<Mundo> mundos;
        string fondo01, fondo02, fondo03;
        string piso01, piso02, piso03;
        string Rutadirec = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
        string Ruta1 = "imagenes";
        string Ruta2 = "Fondos";
        string predeterminado = "fondopredeterminado.png";
        int start = 0, pagesize = 3;

        public VistaMundos(User usuario, Plantilla plantilla)
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
            mundoService = new MundoService();
            mundos = mundoService.GetAll();
            user = usuario;
            personaje = plantilla;
            MostrarFondos();
        }

        private void materialBtnAnt_Click(object sender, EventArgs e)
        {
            start -= pagesize;
            MostrarFondos();
        }

        private void Btsiguiente_Click(object sender, EventArgs e)
        {
            start += pagesize;
            MostrarFondos();
        }

        private void BtEscoger1_Click(object sender, EventArgs e)
        {
            string combifondo = Path.Combine(Rutadirec, Ruta1, Ruta2, fondo01);
            string combipiso = Path.Combine(Rutadirec, Ruta1, Ruta2, piso01);
            CambiarVista(combifondo, combipiso, fondo01);
        }

        private void BtEscoger2_Click(object sender, EventArgs e)
        {
            string combifondo = Path.Combine(Rutadirec, Ruta1, Ruta2, fondo02);
            string combipiso = Path.Combine(Rutadirec, Ruta1, Ruta2, piso02);
            CambiarVista(combifondo, combipiso, fondo02);
        }

        private void BtEscoger3_Click(object sender, EventArgs e)
        {
            string combifondo = Path.Combine(Rutadirec, Ruta1, Ruta2, fondo03);
            string combipiso = Path.Combine(Rutadirec, Ruta1, Ruta2, piso03);
            CambiarVista(combifondo, combipiso, fondo03);
        }

        #region METODOS

        private void MostrarFondos()
        {
            ValidarAnterior();
            Validarsiguiente();
            AsignarFondos();
            CargarPicture();
        }

        private void AsignarFondos()
        {
            int intervalo = start + pagesize;
            int faltante = Math.Abs(mundos.Count - intervalo);
            if (intervalo <= mundos.Count)
            {
                fondo01 = mundos[start].Fondo;
                piso01 = mundos[start].Piso;
                txtmundo1.Text = mundos[start].Nombre;
                txtcategoria1.Text = mundos[start].Id_Categoria;
                fondo02 = mundos[start + 1].Fondo;
                piso02 = mundos[start + 1].Piso;
                txtmundo2.Text = mundos[start + 1].Nombre;
                txtcategoria2.Text = mundos[start + 1].Id_Categoria;
                fondo03 = mundos[start + 2].Fondo;
                piso03 = mundos[start + 2].Piso;
                txtmundo3.Text = mundos[start + 2].Nombre;
                txtcategoria3.Text = mundos[start + 2].Id_Categoria;
            }
            else
            {
                switch (faltante)
                {
                    case 1:
                        {
                            fondo01 = mundos[start].Fondo;
                            piso01 = mundos[start].Piso;
                            txtmundo1.Text = mundos[start].Nombre;
                            txtcategoria1.Text = mundos[start].Id_Categoria;
                            fondo02 = mundos[start + 1].Fondo;
                            piso02 = mundos[start + 1].Piso;
                            txtmundo2.Text = mundos[start + 1].Nombre;
                            txtcategoria2.Text = mundos[start + 1].Id_Categoria;
                            fondo03 = predeterminado;
                            piso03 = predeterminado;
                            txtmundo3.Text = "";
                            txtcategoria3.Text = "";
                        }
                        break;
                    case 2:
                        {
                            fondo01 = mundos[start].Fondo;
                            piso01 = mundos[start].Piso;
                            txtmundo1.Text = mundos[start].Nombre;
                            txtcategoria1.Text = mundos[start].Id_Categoria;
                            fondo02 = predeterminado;
                            piso02 = predeterminado;
                            txtmundo2.Text = "";
                            txtcategoria2.Text = "";
                            fondo03 = predeterminado;
                            piso03 = predeterminado;
                            txtmundo3.Text = "";
                            txtcategoria3.Text = "";
                        }
                        break;
                    default:
                        {
                            fondo01 = predeterminado;
                            txtmundo1.Text = "";
                            txtcategoria1.Text = "";
                            fondo02 = predeterminado;
                            piso02 = predeterminado;
                            txtmundo2.Text = "";
                            txtcategoria2.Text = "";
                            fondo03 = predeterminado;
                            piso03 = predeterminado;
                            txtmundo3.Text = "";
                            txtcategoria3.Text = "";
                        }
                        break;
                }
            }
        }

        private void CargarPicture()
        {
            string combi3 = Path.Combine(Rutadirec, Ruta1, Ruta2, fondo03);
            string combi2 = Path.Combine(Rutadirec, Ruta1, Ruta2, fondo02);
            string combi1 = Path.Combine(Rutadirec, Ruta1, Ruta2, fondo01);
            Image fondo3 = Image.FromFile(combi3);
            Image fondo2 = Image.FromFile(combi2);
            Image fondo1 = Image.FromFile(combi1);
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

        private void ValidarAnterior()
        {
            if (start <= 0)
            {
                Btanterior.Enabled = false;
                return;
            }
            else
            {
                Btanterior.Enabled = true;
            }
        }
        private void Validarsiguiente()
        {
            if (start >= mundos.Count - 1)
            {
                Btsiguiente.Enabled = false;
                return;
            }
            else
            {
                Btsiguiente.Enabled = true;
            }
        }

        private Mundo SelectMundo(string fondo)
        {
            return mundoService.GetByName(fondo);
        }

        private void CambiarVista(string fondo, string piso, string mundo)
        {
            var Mundo = SelectMundo(mundo);
            if (Mundo != null)
            {
                this.Hide();
                new VistaAccionesPersonaje(fondo, piso, user, Mundo, personaje).ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("error al seleccionar el mundo");
                this.Hide();
                new VistaUserPersonajes(user).ShowDialog();
                this.Close();
            }
        }

        #endregion
    }
}
