﻿using Entity;
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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Btsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void Btempezar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
            this.Close();
        }

        private void Btopcion_Click(object sender, EventArgs e)
        {

        }

        private void Btpreguntas_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaPreguntasYRespestas().ShowDialog();
            this.Close();
        }
    }
}
