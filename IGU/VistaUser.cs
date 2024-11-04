using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace IGU
{
    public partial class VistaUser : Form
    {
        UserServices UserServices = new UserServices();
        public VistaUser()
        {
            InitializeComponent();
            CargarLista();
        }

        //private void Btvisi_Click(object sender, EventArgs e)
        //{
        //    //    if(Btop.Visible == true)
        //    //    {
        //    //        Btop.Visible = false;
        //    //    }
        //    //    else
        //    //    {
        //    //        Btop.Visible = true;
        //    //    }
        //}

        #region "Metodos"
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

        private void Limpiar()
        {
            Txtnom.Text = "";
            Txtcontra.Text = "";
            Boxrol.Text = "";
        }

        private void Guardar(User user)
        {
            var mgs = UserServices.SaveData(user);
            MessageBox.Show(mgs);
        }

        private void CargarLista()
        {
            UserServices Tableusers = new UserServices();
            if (Tableusers != null)
            {
                Tablauser.DataSource = Tableusers.getall();
            }
            else
            {
                MessageBox.Show("No hay usuario actualmente");
            }
        }

        private void Uptade(string username)
        {
            var use = UserServices.GetName(username);
            if (use != null)
            {
                use.Id = use.Id;
                use.Contra = Txtcontra.Text;
                use.Name = Txtnom.Text;
                use.Rol = Boxrol.Text;
                var msg = UserServices.Update(use);
                MessageBox.Show(msg);
            }
            else
            {
                MessageBox.Show("No se encontro ninguna referencia");
            }
        }

        private void Buscar(string username)
        {
            var user = UserServices.GetName(username);
            if (user != null)
            {
                Veruser(user);
            }
            else
            {
                MessageBox.Show("No se encontro ninguna referencia");
            }
        }

        private void Veruser(User user)
        {
            Txtcontra.Text = user.Contra;
            Txtnom.Text = user.Name;
            Boxrol.Text = user.Rol;
        }

        #endregion

        private void BtVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Inicio().ShowDialog();
            this.Close();
        }

        private void Btsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txtcontra.Text) && string.IsNullOrEmpty(Txtnom.Text) && ValidarBox())
            {
                MessageBox.Show("Los campos no pueden estar vacios");
            }
            else
            {
                if (UserServices.ValidarNombre(Txtnom.Text))
                {
                    Guardar(new User(UserServices.Number(), Txtnom.Text, Txtcontra.Text, Boxrol.Text));
                    CargarLista();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Nombre ya existente,se recomienda escribir otro");
                }
            }
        }

        private void Btver_Click(object sender, EventArgs e)
        {
            Buscar(txtbuscar.Text);
        }
        private void Btupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string username = Txtnom.Text;
                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("campos vacios");
                }
                else
                {
                    Uptade(username);
                    CargarLista();
                    Limpiar();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No hay elementos en la lista");
            }
        }
        private void Listauser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
