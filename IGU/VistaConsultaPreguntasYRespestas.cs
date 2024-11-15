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
    public partial class VistaConsultaPreguntasYRespestas : Form
    {
        Preg_Y_RespService respService;
        User usuario;
        public VistaConsultaPreguntasYRespestas(User user)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            respService = new Preg_Y_RespService();
            usuario = user;
            Mostar();
        }

        private void Btver_Click(object sender, EventArgs e)
        {
            tablapreyres.DataSource = respService.Gettabla();
        }

        private void Btagregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaRegistroPreYRes(usuario).ShowDialog();
            this.Close();
        }

        private void Btsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaUserPersonajes(usuario).ShowDialog();
        }

        private void Mostar()
        {
            tablapreyres.DataSource = respService.Gettabla();
        }
    }
}
