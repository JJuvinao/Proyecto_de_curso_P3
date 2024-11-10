namespace IGU
{
    partial class VistaEscojerPersonaje
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btante = new System.Windows.Forms.Button();
            this.Btsigui = new System.Windows.Forms.Button();
            this.BtCANCELAR = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.labelclase = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labeldefensa = new System.Windows.Forms.Label();
            this.labelfuerza = new System.Windows.Forms.Label();
            this.labelmana = new System.Windows.Forms.Label();
            this.labelvida = new System.Windows.Forms.Label();
            this.labelperso = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelhabi2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelhabi1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelbasico = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btescojer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Btescojer);
            this.panel1.Controls.Add(this.Btante);
            this.panel1.Controls.Add(this.Btsigui);
            this.panel1.Controls.Add(this.BtCANCELAR);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(8, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 307);
            this.panel1.TabIndex = 0;
            // 
            // Btante
            // 
            this.Btante.Enabled = false;
            this.Btante.Location = new System.Drawing.Point(3, 239);
            this.Btante.Name = "Btante";
            this.Btante.Size = new System.Drawing.Size(83, 28);
            this.Btante.TabIndex = 10;
            this.Btante.Text = "Anterior";
            this.Btante.UseVisualStyleBackColor = true;
            this.Btante.Click += new System.EventHandler(this.Btante_Click);
            // 
            // Btsigui
            // 
            this.Btsigui.Enabled = false;
            this.Btsigui.Location = new System.Drawing.Point(92, 239);
            this.Btsigui.Name = "Btsigui";
            this.Btsigui.Size = new System.Drawing.Size(91, 28);
            this.Btsigui.TabIndex = 9;
            this.Btsigui.Text = "Siguiente";
            this.Btsigui.UseVisualStyleBackColor = true;
            this.Btsigui.Click += new System.EventHandler(this.Btsigui_Click);
            // 
            // BtCANCELAR
            // 
            this.BtCANCELAR.Location = new System.Drawing.Point(230, 261);
            this.BtCANCELAR.Name = "BtCANCELAR";
            this.BtCANCELAR.Size = new System.Drawing.Size(105, 41);
            this.BtCANCELAR.TabIndex = 0;
            this.BtCANCELAR.Text = "CANCELAR";
            this.BtCANCELAR.UseVisualStyleBackColor = true;
            this.BtCANCELAR.Click += new System.EventHandler(this.BtCANCELAR_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.labelclase);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.labeldefensa);
            this.panel4.Controls.Add(this.labelfuerza);
            this.panel4.Controls.Add(this.labelmana);
            this.panel4.Controls.Add(this.labelvida);
            this.panel4.Controls.Add(this.labelperso);
            this.panel4.Location = new System.Drawing.Point(3, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 161);
            this.panel4.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Clase: ";
            // 
            // labelclase
            // 
            this.labelclase.Location = new System.Drawing.Point(81, 32);
            this.labelclase.Name = "labelclase";
            this.labelclase.Size = new System.Drawing.Size(82, 13);
            this.labelclase.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Defensa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fuerza:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mana:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Vida:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Nombre: ";
            // 
            // labeldefensa
            // 
            this.labeldefensa.Location = new System.Drawing.Point(81, 124);
            this.labeldefensa.Name = "labeldefensa";
            this.labeldefensa.Size = new System.Drawing.Size(82, 13);
            this.labeldefensa.TabIndex = 4;
            // 
            // labelfuerza
            // 
            this.labelfuerza.Location = new System.Drawing.Point(81, 102);
            this.labelfuerza.Name = "labelfuerza";
            this.labelfuerza.Size = new System.Drawing.Size(82, 13);
            this.labelfuerza.TabIndex = 3;
            // 
            // labelmana
            // 
            this.labelmana.Location = new System.Drawing.Point(81, 78);
            this.labelmana.Name = "labelmana";
            this.labelmana.Size = new System.Drawing.Size(82, 13);
            this.labelmana.TabIndex = 2;
            // 
            // labelvida
            // 
            this.labelvida.Location = new System.Drawing.Point(81, 54);
            this.labelvida.Name = "labelvida";
            this.labelvida.Size = new System.Drawing.Size(82, 13);
            this.labelvida.TabIndex = 1;
            // 
            // labelperso
            // 
            this.labelperso.Location = new System.Drawing.Point(81, 7);
            this.labelperso.Name = "labelperso";
            this.labelperso.Size = new System.Drawing.Size(82, 13);
            this.labelperso.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "INFORMACIÓN DEL PERSONAJE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelhabi2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.labelhabi1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.labelbasico);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(354, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 306);
            this.panel2.TabIndex = 1;
            // 
            // labelhabi2
            // 
            this.labelhabi2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelhabi2.Location = new System.Drawing.Point(3, 238);
            this.labelhabi2.Name = "labelhabi2";
            this.labelhabi2.Size = new System.Drawing.Size(264, 54);
            this.labelhabi2.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Habilidad 2:";
            // 
            // labelhabi1
            // 
            this.labelhabi1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelhabi1.Location = new System.Drawing.Point(3, 147);
            this.labelhabi1.Name = "labelhabi1";
            this.labelhabi1.Size = new System.Drawing.Size(264, 54);
            this.labelhabi1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Habilidad 1:";
            // 
            // labelbasico
            // 
            this.labelbasico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelbasico.Location = new System.Drawing.Point(3, 67);
            this.labelbasico.Name = "labelbasico";
            this.labelbasico.Size = new System.Drawing.Size(264, 54);
            this.labelbasico.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Golpe basico:";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "HABILIDADES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btescojer
            // 
            this.Btescojer.Location = new System.Drawing.Point(230, 217);
            this.Btescojer.Name = "Btescojer";
            this.Btescojer.Size = new System.Drawing.Size(105, 38);
            this.Btescojer.TabIndex = 11;
            this.Btescojer.Text = "ESCOJER PERONAJE";
            this.Btescojer.UseVisualStyleBackColor = true;
            this.Btescojer.Click += new System.EventHandler(this.Btescojer_Click);
            // 
            // VistaEscojerPersonaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 329);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "VistaEscojerPersonaje";
            this.Text = "VistaEscojerPersonaje";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelhabi2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelhabi1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelbasico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtCANCELAR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labeldefensa;
        private System.Windows.Forms.Label labelfuerza;
        private System.Windows.Forms.Label labelmana;
        private System.Windows.Forms.Label labelvida;
        private System.Windows.Forms.Label labelperso;
        private System.Windows.Forms.Button Btante;
        private System.Windows.Forms.Button Btsigui;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelclase;
        private System.Windows.Forms.Button Btescojer;
    }
}