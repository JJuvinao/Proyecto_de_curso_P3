using BLL;
using Entity;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class VistaRecuperarContra : MaterialForm
    {
        UserServices userServices;
        User usuario;

        public VistaRecuperarContra()
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
        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btbuscar_Click(object sender, EventArgs e)
        {
            if (txtnomuser.Text != null)
            {
                Buscar(txtnomuser.Text);
            }
            else
            {
                MessageBox.Show("Campo de nombre vacio");
            }
        }

        private void BtcambiarContra_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas cambiar la contraseña?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                if (txtnuevacontra.Text != null || txtconfircontra.Text != null)
                {
                    CambiarContra();
                }
                else
                {
                    MessageBox.Show("No ha escrito la nueva contraseña");
                }
            }
        }

        private void Buscar(string username)
        {
            var user = userServices.GetName(username);
            if (user != null)
            {
                usuario = user;
                txtconfircontra.Enabled = true;
                txtnuevacontra.Enabled = true;
                BtcambiarContra.Enabled = true;
                Btbuscar.Enabled = false;
                txtnomuser.Enabled = false;
            }
            else
            {
                MessageBox.Show("No se encontro ninguna referencia");
            }
        }

        private void CambiarContra()
        {
            if (ValidarContra())
            {
                var msg = userServices.Update(usuario.Id, txtnuevacontra.Text);
                MessageBox.Show(msg);
                this.Hide();
                new HomeDprb().ShowDialog();
                this.Close();
            }
        }

        private bool ValidarContra()
        {
            if (usuario != null)
            {
                if (txtnuevacontra.Text == txtconfircontra.Text)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Las contraseñas no son iguales");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("No hay usuario seleccionado");
                return false;
            } 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeDprb().ShowDialog();
            this.Close();
        }
    }
}
