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
    public partial class VistaRegistrarUsuarios : MaterialForm
    {
        UserServices UserServices = new UserServices();
        public VistaRegistrarUsuarios()
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
        }

        private void materialBtnRegistrar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtcontra.Text) && string.IsNullOrEmpty(txtnombre.Text) && ValidarBox())
            {
                MessageBox.Show("Los campos no pueden estar vacios");
            }
            else
            {
                if (UserServices.ValidarNombre(txtnombre.Text))
                {
                    Guardar(new User(UserServices.Number(), txtnombre.Text, txtcontra.Text, SeleccionRol()));
                    this.Hide();
                    new HomeDprb().ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nombre ya existente,se recomienda escribir otro");
                }
            }
        }

        private void materialBtnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeDprb().ShowDialog();
            this.Close();
        }

        #region METODOS

        private bool ValidarBox()
        {
            if (btestudiante.Checked && btprofe.Checked)
            {
                MessageBox.Show("NO SE PUEDE SELECIONAR LOS DOS AL MISMO TIEMPO");
                return false;
            }
            else
            {
                return true;
            }
        }

        private string SeleccionRol()
        {
            if (btestudiante.Checked)
            {
                return  "Estudiante";
            }else
            {
                return  "Profesor";
            }
        }

        private void Guardar(User user)
        {
            var mgs = UserServices.SaveData(user);
            MessageBox.Show(mgs);
        }

        #endregion
    }
}
