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
    public partial class OpcionDeBuffer : Form
    {
        int opcion = 0;
        public OpcionDeBuffer()
        {
            InitializeComponent();
            MostrarInfo();
            LoadDefaultStyle(this);
        }

        private void MostrarInfo()
        {
            labelaumentar.Text = "Se aumnenta el daño en 10 por 3 turno";
            labelrecuperar.Text = "Se recupera 100 de mana";
            labelcancelar.Text = "Salir de buffer";
        }

        public int Ocpcion()
        {
            return opcion;
        }

        private void Btaumentar_Click(object sender, EventArgs e)
        {
            opcion = 1;
            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            opcion = 0;
            this.Close();
        }

        private void Btrecuperar_Click(object sender, EventArgs e)
        {
            opcion = 2;
            this.Close();
        }
    }
}
