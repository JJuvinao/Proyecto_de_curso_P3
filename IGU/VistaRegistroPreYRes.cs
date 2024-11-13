using BLL;
using Entity;
using System;
using System.Linq;
using System.Windows.Forms;

namespace IGU
{
    public partial class VistaRegistroPreYRes : Form
    {
        Preg_Y_RespService respService;
        public VistaRegistroPreYRes()
        {
            InitializeComponent();
            respService = new Preg_Y_RespService();
        }

        private void Btcancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaConsultaPreguntasYRespestas().ShowDialog();
            this.Close();
        }

        private void Btregistrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtpregunta.Text) && !string.IsNullOrEmpty(txtrespuesta.Text)/* && ValidarBox()*/)
            {
                Guardar(new Preg_Y_Resp(respService.Number(), txtpregunta.Text, txtrespuesta.Text));
                this.Hide();
                new VistaConsultaPreguntasYRespestas().ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios");
            }
        }

        private bool ValidarBox()
        {
            string[] categorias = { "Matematicas", "Español", "Biologia" };
            if (categorias.Contains(boxcategoria.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Guardar(Preg_Y_Resp preg_Y_Resp)
        {
            var msg = respService.SaveData(preg_Y_Resp);
            MessageBox.Show(msg);
        }
    }
}
