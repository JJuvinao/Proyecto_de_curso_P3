namespace IGU
{
    partial class VistaRegistroPreYRes
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtpregunta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtrespuesta = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.boxcategoria = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btcancelar = new System.Windows.Forms.Button();
            this.Btregistrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGSITRAR PREGUNTAS Y REPUESTAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pregunta: ";
            // 
            // txtpregunta
            // 
            this.txtpregunta.Location = new System.Drawing.Point(61, 17);
            this.txtpregunta.Name = "txtpregunta";
            this.txtpregunta.Size = new System.Drawing.Size(452, 20);
            this.txtpregunta.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Respuesta:";
            // 
            // txtrespuesta
            // 
            this.txtrespuesta.Location = new System.Drawing.Point(61, 86);
            this.txtrespuesta.Name = "txtrespuesta";
            this.txtrespuesta.Size = new System.Drawing.Size(452, 20);
            this.txtrespuesta.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.boxcategoria);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtrespuesta);
            this.panel1.Controls.Add(this.txtpregunta);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(9, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 172);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Categoria:";
            // 
            // boxcategoria
            // 
            this.boxcategoria.FormattingEnabled = true;
            this.boxcategoria.Location = new System.Drawing.Point(61, 136);
            this.boxcategoria.Name = "boxcategoria";
            this.boxcategoria.Size = new System.Drawing.Size(152, 21);
            this.boxcategoria.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Btcancelar);
            this.panel2.Controls.Add(this.Btregistrar);
            this.panel2.Location = new System.Drawing.Point(10, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 63);
            this.panel2.TabIndex = 6;
            // 
            // Btcancelar
            // 
            this.Btcancelar.Location = new System.Drawing.Point(270, 14);
            this.Btcancelar.Name = "Btcancelar";
            this.Btcancelar.Size = new System.Drawing.Size(254, 34);
            this.Btcancelar.TabIndex = 1;
            this.Btcancelar.Text = "CANCELAR";
            this.Btcancelar.UseVisualStyleBackColor = true;
            this.Btcancelar.Click += new System.EventHandler(this.Btcancelar_Click);
            // 
            // Btregistrar
            // 
            this.Btregistrar.Location = new System.Drawing.Point(3, 14);
            this.Btregistrar.Name = "Btregistrar";
            this.Btregistrar.Size = new System.Drawing.Size(254, 34);
            this.Btregistrar.TabIndex = 0;
            this.Btregistrar.Text = "REGISTRAR";
            this.Btregistrar.UseVisualStyleBackColor = true;
            this.Btregistrar.Click += new System.EventHandler(this.Btregistrar_Click);
            // 
            // VistaRegistroPreYRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 303);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "VistaRegistroPreYRes";
            this.Text = "VistaRegistroPreYRes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpregunta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtrespuesta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox boxcategoria;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btcancelar;
        private System.Windows.Forms.Button Btregistrar;
    }
}