﻿using BLL;
using Entity;
using MaterialSkin.Controls;
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

namespace GUI
{
    public partial class VistaMundos : MaterialForm
    {
        User user;
        Plantilla personaje;
        MundoService mundoService;
        List<Mundo> mundos;
        string fondo01, fondo02, fondo03;
        string Rutadirec = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
        string Ruta1 = "imagenes";
        string Ruta2 = "Fondos";
        string predeterminado = "fondopredeterminado.png";
        int start = 0, pagesize = 3, end;

        public VistaMundos(User usuario, Plantilla plantilla)
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
            string combi = Path.Combine(Rutadirec, Ruta1, Ruta2, fondo01);
            CambiarVista(combi, fondo01);
        }

        private void BtEscoger2_Click(object sender, EventArgs e)
        {
            string combi = Path.Combine(Rutadirec, Ruta1, Ruta2, fondo02);
            CambiarVista(combi, fondo02);
        }

        private void BtEscoger3_Click(object sender, EventArgs e)
        {
            string combi = Path.Combine(Rutadirec, Ruta1, Ruta2, fondo03);
            CambiarVista(combi, fondo03);
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
                txtmundo1.Text = mundos[start].Nombre;
                txtcategoria1.Text = mundos[start].Id_Categoria;
                fondo02 = mundos[start + 1].Fondo;
                txtmundo2.Text = mundos[start + 1].Nombre;
                txtcategoria2.Text = mundos[start + 1].Id_Categoria;
                fondo03 = mundos[start + 2].Fondo;
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
                            txtmundo1.Text = mundos[start].Nombre;
                            txtcategoria1.Text = mundos[start].Id_Categoria;
                            fondo02 = mundos[start + 1].Fondo;
                            txtmundo2.Text = mundos[start + 1].Nombre;
                            txtcategoria2.Text = mundos[start + 1].Id_Categoria;
                            fondo03 = predeterminado;
                            txtmundo3.Text = "";
                            txtcategoria3.Text = "";
                        }
                        break;
                    case 2:
                        {
                            fondo01 = mundos[start].Fondo;
                            txtmundo1.Text = mundos[start].Nombre;
                            txtcategoria1.Text = mundos[start].Id_Categoria;
                            fondo02 = predeterminado;
                            txtmundo2.Text = "";
                            txtcategoria2.Text = "";
                            fondo03 = predeterminado;
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
                            txtmundo2.Text = "";
                            txtcategoria2.Text = "";
                            fondo03 = predeterminado;
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

        private void CambiarVista(string fondo, string mundo)
        {
            var Mundo = SelectMundo(mundo);
            if (Mundo != null)
            {
                this.Hide();
                new VistaAccionesPersonaje(fondo, user, Mundo, personaje).ShowDialog();
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
