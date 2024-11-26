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
    public partial class VistaEliminarUsuarios : MaterialForm
    {

        UserServices userServices;
        User usuario;

        public VistaEliminarUsuarios(User user)
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
            userServices = new UserServices();
            usuario = user;
            Buscar();
        }

        private void btnEliminarUser_Click(object sender, EventArgs e)
        {
            if (txtcontra.Text != null)
            {
                if (ValidarContra())
                {
                    var msg = userServices.Delete(usuario.Id);
                    MessageBox.Show(msg);
                    this.Hide();
                    new HomeDprb().ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Tienes que escribir la contraseña del usuario para poder eliminarlo");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaUserPersonajes(usuario).ShowDialog();
            this.Close();
        }

        private void Buscar()
        {
            var user = userServices.GetName(usuario.Name);
            if (user != null)
            {
                btnEliminarUser.Enabled = true;
                txtcontra.Enabled = true;
                MostrarInfo(user);
            }
            else
            {
                MessageBox.Show("No se encontro ninguna referencia");
            }
        }

        private void MostrarInfo(User user)
        {
            txtnombre.Text = user.Name;
            txtrol.Text = user.Rol;
        }

        private bool ValidarContra()
        {
            if (usuario != null)
            {
                if (txtcontra.Text == usuario.Contra)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("La contraseña es incorrecta");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("No hay usuario seleccionado");
                return false;
            }
        }
    }
}
