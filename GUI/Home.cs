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
using BLL;

namespace GUI
{
    public partial class Home : MaterialForm
    {
        UserServices UserServices = new UserServices();
        public Home()
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
        }

        private void Buscar(string username)
        {
            var user = UserServices.GetName(username);
            if (user != null)
            {
                if (user.Contra == txtcontra.Text)
                {
                    this.Hide();
                    new VistaUserPersonajes(user).ShowDialog();
                    this.Close(); ;
                }
                else
                {
                    MessageBox.Show("contraseña incorrecta");
                }
            }
            else
            {
                MessageBox.Show("No se encontro ninguna referencia");
            }
        }

        private void materialBtnRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaRegistrarUsuarios().ShowDialog();
            this.Close();
        }

        private void materialBtnIniciar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcontra.Text) && string.IsNullOrEmpty(txtnombre.Text))
            {
                MessageBox.Show("Los campos no pueden estar vacios");
            }
            else
            {
                Buscar(txtnombre.Text);
            }
        }
    }
}
