namespace IGU
{
    partial class VistaRegistrar
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
            this.BtRegistar = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.Boxrol = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtRegistar
            // 
            this.BtRegistar.Location = new System.Drawing.Point(12, 214);
            this.BtRegistar.Name = "BtRegistar";
            this.BtRegistar.Size = new System.Drawing.Size(196, 46);
            this.BtRegistar.TabIndex = 0;
            this.BtRegistar.Text = "Registar";
            this.BtRegistar.UseVisualStyleBackColor = true;
            this.BtRegistar.Click += new System.EventHandler(this.BtRegistar_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(236, 214);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(203, 45);
            this.BtCancelar.TabIndex = 1;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "contraseña";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(37, 64);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(138, 20);
            this.txtnombre.TabIndex = 4;
            // 
            // txtcontra
            // 
            this.txtcontra.Location = new System.Drawing.Point(35, 153);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(139, 20);
            this.txtcontra.TabIndex = 5;
            // 
            // Boxrol
            // 
            this.Boxrol.FormattingEnabled = true;
            this.Boxrol.Items.AddRange(new object[] {
            "Profesor",
            "Estudiante"});
            this.Boxrol.Location = new System.Drawing.Point(316, 63);
            this.Boxrol.Name = "Boxrol";
            this.Boxrol.Size = new System.Drawing.Size(137, 21);
            this.Boxrol.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "rol";
            // 
            // VistaRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 272);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Boxrol);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtRegistar);
            this.Name = "VistaRegistrar";
            this.Text = "VistaRegistrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtRegistar;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.ComboBox Boxrol;
        private System.Windows.Forms.Label label3;
    }
}