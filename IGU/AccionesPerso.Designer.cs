namespace IGU
{
    partial class AccionesPerso
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtopcion = new System.Windows.Forms.TextBox();
            this.Btataque = new System.Windows.Forms.Button();
            this.Btrendirse = new System.Windows.Forms.Button();
            this.Btbeffer = new System.Windows.Forms.Button();
            this.PanelFondo = new System.Windows.Forms.Panel();
            this.sangrepersonaje = new System.Windows.Forms.PictureBox();
            this.sangrenpc = new System.Windows.Forms.PictureBox();
            this.PictureNpc2 = new System.Windows.Forms.PictureBox();
            this.PicturePersonaje2 = new System.Windows.Forms.PictureBox();
            this.PictureNpc1 = new System.Windows.Forms.PictureBox();
            this.PicturePersonaje = new System.Windows.Forms.PictureBox();
            this.txtdanio = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btdefender = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.labelclase = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labeldefensa = new System.Windows.Forms.Label();
            this.labelfuerza = new System.Windows.Forms.Label();
            this.labelmana = new System.Windows.Forms.Label();
            this.labelvida = new System.Windows.Forms.Label();
            this.labelperso = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbnpcdefensa = new System.Windows.Forms.Label();
            this.lbnpcfuerza = new System.Windows.Forms.Label();
            this.lbnpcvida = new System.Windows.Forms.Label();
            this.lbnpcnom = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.Btvolver = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.PanelFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sangrepersonaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sangrenpc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureNpc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePersonaje2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureNpc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePersonaje)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "opcion escojida:";
            // 
            // txtopcion
            // 
            this.txtopcion.Location = new System.Drawing.Point(5, 23);
            this.txtopcion.Name = "txtopcion";
            this.txtopcion.Size = new System.Drawing.Size(80, 20);
            this.txtopcion.TabIndex = 1;
            // 
            // Btataque
            // 
            this.Btataque.Location = new System.Drawing.Point(16, 49);
            this.Btataque.Name = "Btataque";
            this.Btataque.Size = new System.Drawing.Size(122, 55);
            this.Btataque.TabIndex = 2;
            this.Btataque.Text = "ATACAR";
            this.Btataque.UseVisualStyleBackColor = true;
            this.Btataque.Click += new System.EventHandler(this.Btataque_Click);
            // 
            // Btrendirse
            // 
            this.Btrendirse.Location = new System.Drawing.Point(17, 229);
            this.Btrendirse.Name = "Btrendirse";
            this.Btrendirse.Size = new System.Drawing.Size(121, 55);
            this.Btrendirse.TabIndex = 3;
            this.Btrendirse.Text = "RENDIRSE";
            this.Btrendirse.UseVisualStyleBackColor = true;
            this.Btrendirse.Click += new System.EventHandler(this.Btsalir_Click);
            // 
            // Btbeffer
            // 
            this.Btbeffer.Location = new System.Drawing.Point(16, 168);
            this.Btbeffer.Name = "Btbeffer";
            this.Btbeffer.Size = new System.Drawing.Size(122, 55);
            this.Btbeffer.TabIndex = 4;
            this.Btbeffer.Text = "BUFFERS";
            this.Btbeffer.UseVisualStyleBackColor = true;
            this.Btbeffer.Click += new System.EventHandler(this.Btbeffer_Click);
            // 
            // PanelFondo
            // 
            this.PanelFondo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelFondo.Controls.Add(this.sangrepersonaje);
            this.PanelFondo.Controls.Add(this.sangrenpc);
            this.PanelFondo.Controls.Add(this.PictureNpc2);
            this.PanelFondo.Controls.Add(this.PicturePersonaje2);
            this.PanelFondo.Controls.Add(this.PictureNpc1);
            this.PanelFondo.Controls.Add(this.PicturePersonaje);
            this.PanelFondo.Location = new System.Drawing.Point(9, 5);
            this.PanelFondo.Name = "PanelFondo";
            this.PanelFondo.Size = new System.Drawing.Size(600, 296);
            this.PanelFondo.TabIndex = 5;
            this.PanelFondo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // sangrepersonaje
            // 
            this.sangrepersonaje.Location = new System.Drawing.Point(-1, 23);
            this.sangrepersonaje.Name = "sangrepersonaje";
            this.sangrepersonaje.Size = new System.Drawing.Size(124, 96);
            this.sangrepersonaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sangrepersonaje.TabIndex = 9;
            this.sangrepersonaje.TabStop = false;
            this.sangrepersonaje.Visible = false;
            // 
            // sangrenpc
            // 
            this.sangrenpc.Location = new System.Drawing.Point(464, 23);
            this.sangrenpc.Name = "sangrenpc";
            this.sangrenpc.Size = new System.Drawing.Size(124, 96);
            this.sangrenpc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sangrenpc.TabIndex = 8;
            this.sangrenpc.TabStop = false;
            this.sangrenpc.Visible = false;
            // 
            // PictureNpc2
            // 
            this.PictureNpc2.Location = new System.Drawing.Point(154, 68);
            this.PictureNpc2.Name = "PictureNpc2";
            this.PictureNpc2.Size = new System.Drawing.Size(165, 188);
            this.PictureNpc2.TabIndex = 7;
            this.PictureNpc2.TabStop = false;
            this.PictureNpc2.Visible = false;
            // 
            // PicturePersonaje2
            // 
            this.PicturePersonaje2.BackColor = System.Drawing.SystemColors.Control;
            this.PicturePersonaje2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PicturePersonaje2.Location = new System.Drawing.Point(215, 50);
            this.PicturePersonaje2.Name = "PicturePersonaje2";
            this.PicturePersonaje2.Size = new System.Drawing.Size(190, 206);
            this.PicturePersonaje2.TabIndex = 6;
            this.PicturePersonaje2.TabStop = false;
            this.PicturePersonaje2.Visible = false;
            // 
            // PictureNpc1
            // 
            this.PictureNpc1.Location = new System.Drawing.Point(364, 68);
            this.PictureNpc1.Name = "PictureNpc1";
            this.PictureNpc1.Size = new System.Drawing.Size(165, 188);
            this.PictureNpc1.TabIndex = 5;
            this.PictureNpc1.TabStop = false;
            // 
            // PicturePersonaje
            // 
            this.PicturePersonaje.BackColor = System.Drawing.SystemColors.Control;
            this.PicturePersonaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PicturePersonaje.Location = new System.Drawing.Point(53, 50);
            this.PicturePersonaje.Name = "PicturePersonaje";
            this.PicturePersonaje.Size = new System.Drawing.Size(190, 206);
            this.PicturePersonaje.TabIndex = 4;
            this.PicturePersonaje.TabStop = false;
            // 
            // txtdanio
            // 
            this.txtdanio.Location = new System.Drawing.Point(483, 43);
            this.txtdanio.Name = "txtdanio";
            this.txtdanio.Size = new System.Drawing.Size(105, 20);
            this.txtdanio.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Btdefender);
            this.panel3.Controls.Add(this.Btrendirse);
            this.panel3.Controls.Add(this.Btbeffer);
            this.panel3.Controls.Add(this.Btataque);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtopcion);
            this.panel3.Location = new System.Drawing.Point(615, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(157, 296);
            this.panel3.TabIndex = 7;
            // 
            // Btdefender
            // 
            this.Btdefender.Location = new System.Drawing.Point(16, 110);
            this.Btdefender.Name = "Btdefender";
            this.Btdefender.Size = new System.Drawing.Size(122, 52);
            this.Btdefender.TabIndex = 5;
            this.Btdefender.Text = "DEFENDER";
            this.Btdefender.UseVisualStyleBackColor = true;
            this.Btdefender.Click += new System.EventHandler(this.Btdefender_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label);
            this.panel4.Controls.Add(this.labelclase);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.labeldefensa);
            this.panel4.Controls.Add(this.labelfuerza);
            this.panel4.Controls.Add(this.labelmana);
            this.panel4.Controls.Add(this.labelvida);
            this.panel4.Controls.Add(this.labelperso);
            this.panel4.Location = new System.Drawing.Point(3, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(154, 142);
            this.panel4.TabIndex = 7;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(8, 30);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(36, 13);
            this.label.TabIndex = 11;
            this.label.Text = "Clase:";
            // 
            // labelclase
            // 
            this.labelclase.AutoSize = true;
            this.labelclase.Location = new System.Drawing.Point(81, 30);
            this.labelclase.Name = "labelclase";
            this.labelclase.Size = new System.Drawing.Size(10, 13);
            this.labelclase.TabIndex = 10;
            this.labelclase.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Defensa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fuerza:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mana:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre: ";
            // 
            // labeldefensa
            // 
            this.labeldefensa.AutoSize = true;
            this.labeldefensa.Location = new System.Drawing.Point(81, 125);
            this.labeldefensa.Name = "labeldefensa";
            this.labeldefensa.Size = new System.Drawing.Size(10, 13);
            this.labeldefensa.TabIndex = 4;
            this.labeldefensa.Text = "-";
            // 
            // labelfuerza
            // 
            this.labelfuerza.AutoSize = true;
            this.labelfuerza.Location = new System.Drawing.Point(81, 103);
            this.labelfuerza.Name = "labelfuerza";
            this.labelfuerza.Size = new System.Drawing.Size(10, 13);
            this.labelfuerza.TabIndex = 3;
            this.labelfuerza.Text = "-";
            // 
            // labelmana
            // 
            this.labelmana.AutoSize = true;
            this.labelmana.Location = new System.Drawing.Point(81, 79);
            this.labelmana.Name = "labelmana";
            this.labelmana.Size = new System.Drawing.Size(10, 13);
            this.labelmana.TabIndex = 2;
            this.labelmana.Text = "-";
            // 
            // labelvida
            // 
            this.labelvida.AutoSize = true;
            this.labelvida.Location = new System.Drawing.Point(81, 55);
            this.labelvida.Name = "labelvida";
            this.labelvida.Size = new System.Drawing.Size(10, 13);
            this.labelvida.TabIndex = 1;
            this.labelvida.Text = "-";
            // 
            // labelperso
            // 
            this.labelperso.AutoSize = true;
            this.labelperso.Location = new System.Drawing.Point(81, 7);
            this.labelperso.Name = "labelperso";
            this.labelperso.Size = new System.Drawing.Size(10, 13);
            this.labelperso.TabIndex = 0;
            this.labelperso.Text = "-";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(160, 28);
            this.panel5.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ESTADISTICAS";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lbnpcdefensa);
            this.panel2.Controls.Add(this.lbnpcfuerza);
            this.panel2.Controls.Add(this.lbnpcvida);
            this.panel2.Controls.Add(this.lbnpcnom);
            this.panel2.Location = new System.Drawing.Point(199, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 142);
            this.panel2.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Defensa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fuerza:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Vida:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Nombre: ";
            // 
            // lbnpcdefensa
            // 
            this.lbnpcdefensa.AutoSize = true;
            this.lbnpcdefensa.Location = new System.Drawing.Point(81, 79);
            this.lbnpcdefensa.Name = "lbnpcdefensa";
            this.lbnpcdefensa.Size = new System.Drawing.Size(10, 13);
            this.lbnpcdefensa.TabIndex = 3;
            this.lbnpcdefensa.Text = "-";
            // 
            // lbnpcfuerza
            // 
            this.lbnpcfuerza.AutoSize = true;
            this.lbnpcfuerza.Location = new System.Drawing.Point(81, 55);
            this.lbnpcfuerza.Name = "lbnpcfuerza";
            this.lbnpcfuerza.Size = new System.Drawing.Size(10, 13);
            this.lbnpcfuerza.TabIndex = 2;
            this.lbnpcfuerza.Text = "-";
            // 
            // lbnpcvida
            // 
            this.lbnpcvida.AutoSize = true;
            this.lbnpcvida.Location = new System.Drawing.Point(81, 31);
            this.lbnpcvida.Name = "lbnpcvida";
            this.lbnpcvida.Size = new System.Drawing.Size(10, 13);
            this.lbnpcvida.TabIndex = 1;
            this.lbnpcvida.Text = "-";
            // 
            // lbnpcnom
            // 
            this.lbnpcnom.AutoSize = true;
            this.lbnpcnom.Location = new System.Drawing.Point(81, 7);
            this.lbnpcnom.Name = "lbnpcnom";
            this.lbnpcnom.Size = new System.Drawing.Size(10, 13);
            this.lbnpcnom.TabIndex = 0;
            this.lbnpcnom.Text = "-";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.labelMensaje);
            this.panel6.Controls.Add(this.Btvolver);
            this.panel6.Location = new System.Drawing.Point(615, 307);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(157, 208);
            this.panel6.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Mensaje:";
            // 
            // labelMensaje
            // 
            this.labelMensaje.Location = new System.Drawing.Point(3, 31);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(149, 80);
            this.labelMensaje.TabIndex = 1;
            // 
            // Btvolver
            // 
            this.Btvolver.Location = new System.Drawing.Point(1, 158);
            this.Btvolver.Name = "Btvolver";
            this.Btvolver.Size = new System.Drawing.Size(151, 40);
            this.Btvolver.TabIndex = 0;
            this.Btvolver.Text = "VOLVER";
            this.Btvolver.UseVisualStyleBackColor = true;
            this.Btvolver.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Controls.Add(this.txtdanio);
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Location = new System.Drawing.Point(9, 307);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(594, 208);
            this.panel7.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(208, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 22);
            this.label15.TabIndex = 14;
            this.label15.Text = "Npc";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(8, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 22);
            this.label13.TabIndex = 13;
            this.label13.Text = "Personaje";
            // 
            // AccionesPerso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 518);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PanelFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccionesPerso";
            this.Text = "AccionesPerso";
            this.PanelFondo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sangrepersonaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sangrenpc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureNpc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePersonaje2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureNpc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePersonaje)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtopcion;
        private System.Windows.Forms.Button Btataque;
        private System.Windows.Forms.Button Btrendirse;
        private System.Windows.Forms.Button Btbeffer;
        private System.Windows.Forms.Panel PanelFondo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelperso;
        private System.Windows.Forms.Label labeldefensa;
        private System.Windows.Forms.Label labelfuerza;
        private System.Windows.Forms.Label labelmana;
        private System.Windows.Forms.Label labelvida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbnpcdefensa;
        private System.Windows.Forms.Label lbnpcfuerza;
        private System.Windows.Forms.Label lbnpcvida;
        private System.Windows.Forms.Label lbnpcnom;
        private System.Windows.Forms.TextBox txtdanio;
        private System.Windows.Forms.PictureBox PictPerso;
        private System.Windows.Forms.PictureBox PicturePersonaje;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PictureNpc1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button Btvolver;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button Btdefender;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelMensaje;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelclase;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox PicturePersonaje2;
        private System.Windows.Forms.PictureBox PictureNpc2;
        private System.Windows.Forms.PictureBox sangrepersonaje;
        private System.Windows.Forms.PictureBox sangrenpc;
    }
}