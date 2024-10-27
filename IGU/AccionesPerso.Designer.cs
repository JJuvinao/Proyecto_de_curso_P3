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
            this.Btsalir = new System.Windows.Forms.Button();
            this.Btdefender = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelperso = new System.Windows.Forms.Label();
            this.labelvida = new System.Windows.Forms.Label();
            this.labelmana = new System.Windows.Forms.Label();
            this.labelfuerza = new System.Windows.Forms.Label();
            this.labeldefensa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "opcion escojida:";
            // 
            // txtopcion
            // 
            this.txtopcion.Location = new System.Drawing.Point(4, 52);
            this.txtopcion.Name = "txtopcion";
            this.txtopcion.Size = new System.Drawing.Size(80, 20);
            this.txtopcion.TabIndex = 1;
            // 
            // Btataque
            // 
            this.Btataque.Location = new System.Drawing.Point(3, 107);
            this.Btataque.Name = "Btataque";
            this.Btataque.Size = new System.Drawing.Size(122, 55);
            this.Btataque.TabIndex = 2;
            this.Btataque.Text = "Atacar";
            this.Btataque.UseVisualStyleBackColor = true;
            this.Btataque.Click += new System.EventHandler(this.Btataque_Click);
            // 
            // Btsalir
            // 
            this.Btsalir.Location = new System.Drawing.Point(3, 229);
            this.Btsalir.Name = "Btsalir";
            this.Btsalir.Size = new System.Drawing.Size(121, 55);
            this.Btsalir.TabIndex = 3;
            this.Btsalir.Text = "Salir";
            this.Btsalir.UseVisualStyleBackColor = true;
            this.Btsalir.Click += new System.EventHandler(this.Btsalir_Click);
            // 
            // Btdefender
            // 
            this.Btdefender.Location = new System.Drawing.Point(2, 168);
            this.Btdefender.Name = "Btdefender";
            this.Btdefender.Size = new System.Drawing.Size(122, 55);
            this.Btdefender.TabIndex = 4;
            this.Btdefender.Text = "Defender";
            this.Btdefender.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(143, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 296);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(528, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 127);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Btsalir);
            this.panel3.Controls.Add(this.Btdefender);
            this.panel3.Controls.Add(this.Btataque);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtopcion);
            this.panel3.Location = new System.Drawing.Point(7, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 296);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.panel4.Location = new System.Drawing.Point(528, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(201, 126);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(528, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(201, 28);
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
            // labelperso
            // 
            this.labelperso.AutoSize = true;
            this.labelperso.Location = new System.Drawing.Point(81, 7);
            this.labelperso.Name = "labelperso";
            this.labelperso.Size = new System.Drawing.Size(10, 13);
            this.labelperso.TabIndex = 0;
            this.labelperso.Text = "-";
            // 
            // labelvida
            // 
            this.labelvida.AutoSize = true;
            this.labelvida.Location = new System.Drawing.Point(81, 31);
            this.labelvida.Name = "labelvida";
            this.labelvida.Size = new System.Drawing.Size(10, 13);
            this.labelvida.TabIndex = 1;
            this.labelvida.Text = "-";
            // 
            // labelmana
            // 
            this.labelmana.AutoSize = true;
            this.labelmana.Location = new System.Drawing.Point(81, 55);
            this.labelmana.Name = "labelmana";
            this.labelmana.Size = new System.Drawing.Size(10, 13);
            this.labelmana.TabIndex = 2;
            this.labelmana.Text = "-";
            // 
            // labelfuerza
            // 
            this.labelfuerza.AutoSize = true;
            this.labelfuerza.Location = new System.Drawing.Point(81, 79);
            this.labelfuerza.Name = "labelfuerza";
            this.labelfuerza.Size = new System.Drawing.Size(10, 13);
            this.labelfuerza.TabIndex = 3;
            this.labelfuerza.Text = "-";
            // 
            // labeldefensa
            // 
            this.labeldefensa.AutoSize = true;
            this.labeldefensa.Location = new System.Drawing.Point(81, 101);
            this.labeldefensa.Name = "labeldefensa";
            this.labeldefensa.Size = new System.Drawing.Size(10, 13);
            this.labeldefensa.TabIndex = 4;
            this.labeldefensa.Text = "-";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vida:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mana:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fuerza:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Defensa:";
            // 
            // AccionesPerso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 302);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AccionesPerso";
            this.Text = "AccionesPerso";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtopcion;
        private System.Windows.Forms.Button Btataque;
        private System.Windows.Forms.Button Btsalir;
        private System.Windows.Forms.Button Btdefender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
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
    }
}