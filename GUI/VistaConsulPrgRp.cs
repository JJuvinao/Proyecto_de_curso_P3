using BLL;
using Entity;
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
    public partial class VistaConsulPrgRp : MaterialForm
    {

        Preg_Y_RespService respService;
        User usuario;

        public VistaConsulPrgRp(User user)
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
            tablapreyres.ForeColor = Color.Black;
            respService = new Preg_Y_RespService();
            usuario = user;
            Mostar();
        }

        private void materialBtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaUserPersonajes(usuario).ShowDialog();
            this.Close();
        }

        private void materialBtnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaRegistrarPrgRp(usuario).ShowDialog();
            this.Close();
        }

        private void materialBtnCategoria_Click(object sender, EventArgs e)
        {

        }

        #region METODOS

        private void Mostar()
        {
            tablapreyres.DataSource = respService.Gettabla();
        }

        #endregion
    }
}
