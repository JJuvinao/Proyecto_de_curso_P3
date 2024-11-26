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
    public partial class SeleccionPrreyRes : MaterialForm
    {
        Preg_Y_RespService preg_Y_Respservice;
        List<Preg_Y_Resp> preg_Y_Resps;
        List<Respuestas_falsas> respuestas_Falsas;
        string repes1 = "", repes2 = "", repes3 = "", repes4 = "", pregunta = "";
        bool Validar = false;

        Random ramd = new Random();

        public SeleccionPrreyRes()
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
            preg_Y_Respservice = new Preg_Y_RespService();
            Llenarpreguyresp();
            MostrarPrepyResp();
        }

        private void Btrepuesta1_Click(object sender, EventArgs e)
        {
            ValidarRepuesta(Btrepuesta1.Text);
            this.Close();
        }

        private void Btrepuesta2_Click(object sender, EventArgs e)
        {
            ValidarRepuesta(Btrepuesta2.Text);
            this.Close();
        }

        private void Btrepuesta3_Click(object sender, EventArgs e)
        {
            ValidarRepuesta(Btrepuesta3.Text);
            this.Close();
        }

        private void Btrepuesta4_Click(object sender, EventArgs e)
        {
            ValidarRepuesta(Btrepuesta4.Text);
            this.Close();
        }

        #region METODOS

        private void Llenarpreguyresp()
        {
            preg_Y_Resps = preg_Y_Respservice.GetAll();
            if (preg_Y_Resps.Count > 0)
            {
                int opc = ramd.Next(0, preg_Y_Resps.Count() - 1);
                pregunta = preg_Y_Resps[opc].Pregunta;
                repes1 = preg_Y_Resps[opc].Repuesta;
                respuestas_Falsas = preg_Y_Respservice.Getlis_falsas_Pregunta(preg_Y_Resps[opc].Id);
                if (respuestas_Falsas.Count > 0)
                {
                    repes2 = respuestas_Falsas[0].Respesta_f;
                    repes3 = respuestas_Falsas[1].Respesta_f;
                    repes4 = respuestas_Falsas[2].Respesta_f;
                }
            }
            else
            {
                MessageBox.Show("No hay preguntas ni repuestas");
            }
        }
        private void MostrarPrepyResp()
        {
            labelpregunta.Text = pregunta;
            Btrepuesta1.Text = repes1;
            Btrepuesta2.Text = repes2;
            Btrepuesta3.Text = repes3;
            Btrepuesta4.Text = repes4;
        }

        public bool Responder()
        {
            return Validar;
        }

        public string RepuestaCorrecto()
        {
            return repes1;
        }

        private void ValidarRepuesta(string preguntaselec)
        {
            if (repes1 == preguntaselec)
            {
                Validar = true;
            }
            else
            {
                Validar = false;
            }
        }

        #endregion

    }
}
