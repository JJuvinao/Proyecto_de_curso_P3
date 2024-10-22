namespace IGU
{
    partial class VistaPreg_Y_Resp
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
            this.btguaradar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpreg = new System.Windows.Forms.TextBox();
            this.txtresp = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btsalir = new System.Windows.Forms.Button();
            this.btver = new System.Windows.Forms.Button();
            this.Respuestas = new System.Windows.Forms.ListBox();
            this.Preguntas = new System.Windows.Forms.ListBox();
            this.Btconculta = new System.Windows.Forms.Button();
            this.Btlimpiar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btguaradar
            // 
            this.btguaradar.Location = new System.Drawing.Point(23, 283);
            this.btguaradar.Name = "btguaradar";
            this.btguaradar.Size = new System.Drawing.Size(148, 51);
            this.btguaradar.TabIndex = 0;
            this.btguaradar.Text = "Guardar";
            this.btguaradar.UseVisualStyleBackColor = true;
            this.btguaradar.Click += new System.EventHandler(this.Btguaradar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pregunta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Respuesta";
            // 
            // txtpreg
            // 
            this.txtpreg.Location = new System.Drawing.Point(23, 98);
            this.txtpreg.Name = "txtpreg";
            this.txtpreg.Size = new System.Drawing.Size(273, 20);
            this.txtpreg.TabIndex = 3;
            // 
            // txtresp
            // 
            this.txtresp.Location = new System.Drawing.Point(23, 201);
            this.txtresp.Name = "txtresp";
            this.txtresp.Size = new System.Drawing.Size(264, 20);
            this.txtresp.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btconculta);
            this.panel1.Controls.Add(this.Btsalir);
            this.panel1.Controls.Add(this.btver);
            this.panel1.Controls.Add(this.Respuestas);
            this.panel1.Controls.Add(this.Preguntas);
            this.panel1.Location = new System.Drawing.Point(373, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 437);
            this.panel1.TabIndex = 5;
            // 
            // Btsalir
            // 
            this.Btsalir.Location = new System.Drawing.Point(301, 381);
            this.Btsalir.Name = "Btsalir";
            this.Btsalir.Size = new System.Drawing.Size(90, 35);
            this.Btsalir.TabIndex = 3;
            this.Btsalir.Text = "Salir";
            this.Btsalir.UseVisualStyleBackColor = true;
            this.Btsalir.Click += new System.EventHandler(this.Btsalir_Click);
            // 
            // btver
            // 
            this.btver.Location = new System.Drawing.Point(18, 381);
            this.btver.Name = "btver";
            this.btver.Size = new System.Drawing.Size(99, 35);
            this.btver.TabIndex = 2;
            this.btver.Text = "VER";
            this.btver.UseVisualStyleBackColor = true;
            this.btver.Click += new System.EventHandler(this.Btver_Click);
            // 
            // Respuestas
            // 
            this.Respuestas.FormattingEnabled = true;
            this.Respuestas.Location = new System.Drawing.Point(18, 206);
            this.Respuestas.Name = "Respuestas";
            this.Respuestas.Size = new System.Drawing.Size(372, 147);
            this.Respuestas.TabIndex = 1;
            // 
            // Preguntas
            // 
            this.Preguntas.FormattingEnabled = true;
            this.Preguntas.Location = new System.Drawing.Point(18, 27);
            this.Preguntas.Name = "Preguntas";
            this.Preguntas.Size = new System.Drawing.Size(374, 160);
            this.Preguntas.TabIndex = 0;
            this.Preguntas.SelectedIndexChanged += new System.EventHandler(this.Preguntas_SelectedIndexChanged);
            // 
            // Btconculta
            // 
            this.Btconculta.Location = new System.Drawing.Point(154, 381);
            this.Btconculta.Name = "Btconculta";
            this.Btconculta.Size = new System.Drawing.Size(99, 34);
            this.Btconculta.TabIndex = 4;
            this.Btconculta.Text = "Consultar";
            this.Btconculta.UseVisualStyleBackColor = true;
            this.Btconculta.Click += new System.EventHandler(this.Btconculta_Click);
            // 
            // Btlimpiar
            // 
            this.Btlimpiar.Location = new System.Drawing.Point(26, 406);
            this.Btlimpiar.Name = "Btlimpiar";
            this.Btlimpiar.Size = new System.Drawing.Size(115, 36);
            this.Btlimpiar.TabIndex = 6;
            this.Btlimpiar.Text = "limpiar";
            this.Btlimpiar.UseVisualStyleBackColor = true;
            this.Btlimpiar.Click += new System.EventHandler(this.Btlimpiar_Click);
            // 
            // VistaPreg_Y_Resp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btlimpiar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtresp);
            this.Controls.Add(this.txtpreg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btguaradar);
            this.Name = "VistaPreg_Y_Resp";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btguaradar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpreg;
        private System.Windows.Forms.TextBox txtresp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox Preguntas;
        private System.Windows.Forms.ListBox Respuestas;
        private System.Windows.Forms.Button btver;
        private System.Windows.Forms.Button Btsalir;
        private System.Windows.Forms.Button Btconculta;
        private System.Windows.Forms.Button Btlimpiar;
    }
}