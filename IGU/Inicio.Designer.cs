namespace IGU
{
    partial class Inicio
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Btsalir = new System.Windows.Forms.Button();
            this.Btmundos = new System.Windows.Forms.Button();
            this.Btacciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Preguntas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "User";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btsalir
            // 
            this.Btsalir.Location = new System.Drawing.Point(33, 209);
            this.Btsalir.Name = "Btsalir";
            this.Btsalir.Size = new System.Drawing.Size(107, 51);
            this.Btsalir.TabIndex = 2;
            this.Btsalir.Text = "Salir";
            this.Btsalir.UseVisualStyleBackColor = true;
            this.Btsalir.Click += new System.EventHandler(this.Btsalir_Click);
            // 
            // Btmundos
            // 
            this.Btmundos.Location = new System.Drawing.Point(175, 37);
            this.Btmundos.Name = "Btmundos";
            this.Btmundos.Size = new System.Drawing.Size(119, 68);
            this.Btmundos.TabIndex = 3;
            this.Btmundos.Text = "Mundo";
            this.Btmundos.UseVisualStyleBackColor = true;
            this.Btmundos.Click += new System.EventHandler(this.Btmundos_Click);
            // 
            // Btacciones
            // 
            this.Btacciones.Location = new System.Drawing.Point(175, 126);
            this.Btacciones.Name = "Btacciones";
            this.Btacciones.Size = new System.Drawing.Size(118, 64);
            this.Btacciones.TabIndex = 4;
            this.Btacciones.Text = "Acciones";
            this.Btacciones.UseVisualStyleBackColor = true;
            this.Btacciones.Click += new System.EventHandler(this.Btacciones_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 278);
            this.Controls.Add(this.Btacciones);
            this.Controls.Add(this.Btmundos);
            this.Controls.Add(this.Btsalir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Btsalir;
        private System.Windows.Forms.Button Btmundos;
        private System.Windows.Forms.Button Btacciones;
    }
}