using BLL;
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
    public partial class VistaPreguntasYRespestas : Form
    {
        Preg_Y_RespService respService;
        public VistaPreguntasYRespestas()
        {
            InitializeComponent();
            respService = new Preg_Y_RespService();
        }

        private void Btver_Click(object sender, EventArgs e)
        {
            tablapreyres.DataSource = respService.Gettabla();
        }
    }
}
