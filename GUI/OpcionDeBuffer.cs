using MaterialSkin.Controls;
using MaterialSkin;
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
    public partial class OpcionDeBuffer : MaterialForm
    {
        int opcion = 0;
        SeleccionPrreyRes seleccionpreyres;
        public OpcionDeBuffer()
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
            MostrarInfo();
        }

        private void MostrarInfo()
        {
            labelaumentar.Text = "Se aumnenta el daño en 10 por 3 turno";
            labelrecuperar.Text = "Se recupera 100 de mana";
            labelcancelar.Text = "Salir de buffer";
        }

        private void Abrirvista()
        {
            seleccionpreyres = new SeleccionPrreyRes();
            seleccionpreyres.ShowDialog();
        }

        private void Mostrarmsg()
        {
            MessageBox.Show("REPUESTA INCORECTA" + "\n"
                                + "RESPUESTA CORRECTA: " + seleccionpreyres.RepuestaCorrecto());
        }

        public int Ocpcion()
        {
            return opcion;
        }

        private void Btaumentar_Click(object sender, EventArgs e)
        {

            Abrirvista();
            if (seleccionpreyres.Responder())
            {
                opcion = 1;
            }
            else
            {
                Mostrarmsg();
            }
            this.Close();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            Abrirvista();
            if (seleccionpreyres.Responder())
            {
                opcion = 2;
            }
            else
            {
                Mostrarmsg();
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            opcion = 0;
            this.Close();
        }
    }
}
