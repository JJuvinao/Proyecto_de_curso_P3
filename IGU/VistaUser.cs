using BLL;
using Entity;
using System;
using System.Collections.Generic;
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

        private void Btvisi_Click(object sender, EventArgs e)
        {
            //    if(Btop.Visible == true)
            //    {
            //        Btop.Visible = false;
            //    }
            //    else
            //    {
            //        Btop.Visible = true;
            //    }
        }

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
                Guardar(new User(UserServices.Number(), Txtnom.Text, Txtcontra.Text, Boxrol.Text));
                CargarLista();
                Limpiar();
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
            List<User> lisusers = UserServices.GetAll();
            if (lisusers != null)
            {
                Listauser.DataSource = lisusers;
                Listauser.ValueMember = "Id";
                Listauser.DisplayMember = "Name";
            }
            else
            {
                MessageBox.Show("No hay usuario actualmente");
            }
        }

        private void Btver_Click(object sender, EventArgs e)
        {
            try
            {
                string userid = Listauser.SelectedValue.ToString();
                if (string.IsNullOrEmpty(userid))
                {
                    MessageBox.Show("campos vacios");
                }
                else
                {
                    Buscar(userid);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No hay elementos en la lista");
            }
        }

        private void Buscar(string userid)
        {
            var user = UserServices.GetId(int.Parse(userid));
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

        private void Btupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string userid = Listauser.SelectedValue.ToString();
                if (string.IsNullOrEmpty(userid))
                {
                    MessageBox.Show("campos vacios");
                }
                else
                {
                    Buscar(userid);
                    Uptade(userid);
                    CargarLista();
                    Limpiar();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No hay elementos en la lista");
            }
        }

        private void Uptade(string userid)
        {
            var use = UserServices.GetId(int.Parse(userid));
            if (use != null)
            {
                use.Id = int.Parse(userid);
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
    }
}
