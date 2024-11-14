using BLL;
using Entity;
using System;
using System.Windows.Forms;
using static IGU.CustomUI;

namespace IGU
{
    public partial class VistaPreg_Y_Resp : Form
    {
        Preg_Y_RespService Preg_Y_RespService = new Preg_Y_RespService();
        public VistaPreg_Y_Resp()
        {
            InitializeComponent();
            LoadDefaultStyle(this);
        }

        private void Btver_Click(object sender, EventArgs e)
        {
            Cargarlista();
        }

        private void Cargarlista()
        {
            Preguntas.DataSource = Preg_Y_RespService.GetAll();
            Preguntas.ValueMember = "Id";
            Preguntas.DisplayMember = "Pregunta";

            Respuestas.DataSource = Preg_Y_RespService.GetAll();
            Respuestas.ValueMember = "Id";
            Respuestas.DisplayMember = "Repuesta";
        }

        private void Btguaradar_Click(object sender, EventArgs e)
        {
            if (!Validar(txtpreg.Text, txtresp.Text))
            {
                Guardar(new Preg_Y_Resp(Preg_Y_RespService.Number(), txtpreg.Text, txtresp.Text));
                Cargarlista();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios");
            }
        }

        private void Guardar(Preg_Y_Resp preg_Y_Resp)
        {
            var msg = Preg_Y_RespService.SaveData(preg_Y_Resp);
            MessageBox.Show(msg);
        }

        private void Btsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Inicio().ShowDialog();
            this.Close();
        }

        private bool Validar(string pre, string res)
        {
            if (string.IsNullOrEmpty(pre) && string.IsNullOrEmpty(res))
            {
                return true;
            }
            else { return false; }
        }

        private void Limpiar()
        {
            txtpreg.Clear();
            txtresp.Text = "";
        }

        private void Btconculta_Click(object sender, EventArgs e)
        {
            try
            {
                string pre = Preguntas.SelectedValue.ToString();
                if (string.IsNullOrEmpty(pre))
                {
                    MessageBox.Show("campos vacios");
                }
                else
                {
                    Buscar(pre);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No hay elementos en la lista");
            }
        }

        private void Btlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Preguntas_SelectedIndexChanged(object sender, EventArgs e) { }

        private void Buscar(string v)
        {
            var pre = Preg_Y_RespService.GetId(int.Parse(v));
            if (pre != null)
            {
                Verpre(pre);
            }
            else
            {
                MessageBox.Show("No se encontro ninguna referencia");
            }
        }

        private void Verpre(Preg_Y_Resp pre)
        {
            txtpreg.Text = pre.Pregunta;
            txtresp.Text = pre.Repuesta;
        }

        private void BtActu_Click(object sender, EventArgs e)
        {
            try
            {
                string pre = Preguntas.SelectedValue.ToString();
                if (string.IsNullOrEmpty(pre) && Validar(txtpreg.Text, txtresp.Text))
                {
                    MessageBox.Show("campos vacios");
                }
                else
                {
                    Update(pre, txtpreg.Text, txtresp.Text);
                    Cargarlista();
                    Limpiar();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No hay elementos en la lista");
            }
        }

        private void Update(string id, string pre, string res)
        {
            var Uppreg = Preg_Y_RespService.Update(new Preg_Y_Resp(int.Parse(id), pre, res));
            MessageBox.Show(Uppreg);
        }
    }
}
