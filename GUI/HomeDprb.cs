using BLL;
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
    public partial class HomeDprb : MaterialForm
    {
        UserServices UserServices = new UserServices();
        public HomeDprb()
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

            
        }

        private void btnLoginSubmit_Click(object sender, EventArgs e)
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

        private void lnkForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaRecuperarContra().ShowDialog();
            this.Close();
        }

        private void btnRegisterSubmit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaRegistrarUsuarios().ShowDialog();
            this.Close();
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
    }
}
