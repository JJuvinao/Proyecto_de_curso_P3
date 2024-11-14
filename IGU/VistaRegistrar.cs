using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static IGU.CustomUI;

namespace IGU
{
    public partial class VistaRegistrar : Form
    {
        UserServices UserServices = new UserServices();
        public VistaRegistrar()
        {
            InitializeComponent();
            LoadDefaultStyle(this);
        }

        private void BtRegistar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcontra.Text) && string.IsNullOrEmpty(txtnombre.Text) && ValidarBox())
            {
                MessageBox.Show("Los campos no pueden estar vacios");
            }
            else
            {
                if (UserServices.ValidarNombre(txtnombre.Text))
                {
                    Guardar(new User(UserServices.Number(), txtnombre.Text, txtcontra.Text, Boxrol.Text));
                    this.Hide();
                    new Login().ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nombre ya existente,se recomienda escribir otro");
                }
            }
        }

        private bool ValidarBox()
        {
            if (Boxrol.Text == "Profesor" || Boxrol.Text == "Estudiante")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Guardar(User user)
        {
            var mgs = UserServices.SaveData(user);
            MessageBox.Show(mgs);
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
            this.Close();
        }
    }
}
