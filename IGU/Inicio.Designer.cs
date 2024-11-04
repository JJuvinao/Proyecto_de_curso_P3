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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btempezar = new System.Windows.Forms.Button();
            this.Btopcion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Preguntas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(280, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "User";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btsalir
            // 
            this.Btsalir.Location = new System.Drawing.Point(13, 237);
            this.Btsalir.Name = "Btsalir";
            this.Btsalir.Size = new System.Drawing.Size(213, 51);
            this.Btsalir.TabIndex = 2;
            this.Btsalir.Text = "Salir";
            this.Btsalir.UseVisualStyleBackColor = true;
            this.Btsalir.Click += new System.EventHandler(this.Btsalir_Click);
            // 
            // Btmundos
            // 
            this.Btmundos.Location = new System.Drawing.Point(280, 242);
            this.Btmundos.Name = "Btmundos";
            this.Btmundos.Size = new System.Drawing.Size(85, 68);
            this.Btmundos.TabIndex = 3;
            this.Btmundos.Text = "Mundo";
            this.Btmundos.UseVisualStyleBackColor = true;
            this.Btmundos.Click += new System.EventHandler(this.Btmundos_Click);
            // 
            // Btacciones
            // 
            this.Btacciones.Location = new System.Drawing.Point(280, 96);
            this.Btacciones.Name = "Btacciones";
            this.Btacciones.Size = new System.Drawing.Size(85, 64);
            this.Btacciones.TabIndex = 4;
            this.Btacciones.Text = "Acciones";
            this.Btacciones.UseVisualStyleBackColor = true;
            this.Btacciones.Click += new System.EventHandler(this.Btacciones_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Btopcion);
            this.panel1.Controls.Add(this.Btempezar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Btsalir);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 309);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "HEROES DEL APRENDIZAJE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btempezar
            // 
            this.Btempezar.Location = new System.Drawing.Point(13, 97);
            this.Btempezar.Name = "Btempezar";
            this.Btempezar.Size = new System.Drawing.Size(213, 49);
            this.Btempezar.TabIndex = 4;
            this.Btempezar.Text = "EMPEZAR";
            this.Btempezar.UseVisualStyleBackColor = true;
            this.Btempezar.Click += new System.EventHandler(this.Btempezar_Click);
            // 
            // Btopcion
            // 
            this.Btopcion.Location = new System.Drawing.Point(13, 166);
            this.Btopcion.Name = "Btopcion";
            this.Btopcion.Size = new System.Drawing.Size(213, 49);
            this.Btopcion.TabIndex = 5;
            this.Btopcion.Text = "OPCIONES";
            this.Btopcion.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 333);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btacciones);
            this.Controls.Add(this.Btmundos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Btsalir;
        private System.Windows.Forms.Button Btmundos;
        private System.Windows.Forms.Button Btacciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btopcion;
        private System.Windows.Forms.Button Btempezar;
    }
}