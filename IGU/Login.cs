using BLL;
using System;
using System.Windows.Forms;

namespace IGU
{
    public partial class Login : Form
    {
        UserServices UserServices = new UserServices();
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #region METODOS
        private void Buscar(string username)
        {
            var user = UserServices.GetName(username);
            if (user != null)
            {
                if(user.Contra == txtcontra.Text)
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

        #endregion
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Inicio().ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void BtRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaRegistrar().ShowDialog();
            this.Close();
        }
    }
}
