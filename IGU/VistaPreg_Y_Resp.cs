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

namespace IGU
{
    public partial class VistaPreg_Y_Resp : Form
    {
        Preg_Y_RespService Preg_Y_RespService = new Preg_Y_RespService();
        public VistaPreg_Y_Resp()
        {
            InitializeComponent();
        }

        private void Btver_Click(object sender, EventArgs e)
        {
            Cargarlista();
        }

        private void Cargarlista()
        {
            Preguntas.DataSource = Preg_Y_RespService.Consultar();
            Preguntas.ValueMember = "Id";
            Preguntas.DisplayMember = "Pregunta";

            Respuestas.DataSource = Preg_Y_RespService.Consultar();
            Respuestas.ValueMember = "Id";
            Respuestas.DisplayMember = "Repuesta";
        }

        private void Btguaradar_Click(object sender, EventArgs e)
        {
            Guardar(new Preg_Y_Resp(Preg_Y_RespService.Number(),txtpreg.Text,txtresp.Text));
            Cargarlista();
        }

        private void Guardar(Preg_Y_Resp preg_Y_Resp)
        {
            var msg = Preg_Y_RespService.SaveData(preg_Y_Resp);
            MessageBox.Show(msg);
        }

        private void Btsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
