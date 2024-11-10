namespace IGU
{
    partial class OpcionDeBuffer
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
            this.labelcancelar = new System.Windows.Forms.Label();
            this.labelrecuperar = new System.Windows.Forms.Label();
            this.labelaumentar = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Btaumentar = new System.Windows.Forms.Button();
            this.Btrecuperar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelcancelar);
            this.panel1.Controls.Add(this.labelrecuperar);
            this.panel1.Controls.Add(this.labelaumentar);
            this.panel1.Controls.Add(this.Cancelar);
            this.panel1.Controls.Add(this.Btaumentar);
            this.panel1.Controls.Add(this.Btrecuperar);
            this.panel1.Location = new System.Drawing.Point(5, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 214);
            this.panel1.TabIndex = 0;
            // 
            // labelcancelar
            // 
            this.labelcancelar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelcancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelcancelar.Location = new System.Drawing.Point(206, 138);
            this.labelcancelar.Name = "labelcancelar";
            this.labelcancelar.Size = new System.Drawing.Size(198, 61);
            this.labelcancelar.TabIndex = 15;
            this.labelcancelar.Text = "-";
            // 
            // labelrecuperar
            // 
            this.labelrecuperar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelrecuperar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelrecuperar.Location = new System.Drawing.Point(207, 71);
            this.labelrecuperar.Name = "labelrecuperar";
            this.labelrecuperar.Size = new System.Drawing.Size(197, 61);
            this.labelrecuperar.TabIndex = 14;
            this.labelrecuperar.Text = "-";
            // 
            // labelaumentar
            // 
            this.labelaumentar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelaumentar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelaumentar.Location = new System.Drawing.Point(207, 4);
            this.labelaumentar.Name = "labelaumentar";
            this.labelaumentar.Size = new System.Drawing.Size(197, 61);
            this.labelaumentar.TabIndex = 13;
            this.labelaumentar.Text = "-";
            // 
            // Cancelar
            // 
            this.Cancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Cancelar.Location = new System.Drawing.Point(16, 137);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(174, 61);
            this.Cancelar.TabIndex = 11;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Btaumentar
            // 
            this.Btaumentar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btaumentar.Location = new System.Drawing.Point(16, 3);
            this.Btaumentar.Name = "Btaumentar";
            this.Btaumentar.Size = new System.Drawing.Size(175, 61);
            this.Btaumentar.TabIndex = 9;
            this.Btaumentar.Text = "Aumentar daño";
            this.Btaumentar.UseVisualStyleBackColor = true;
            this.Btaumentar.Click += new System.EventHandler(this.Btaumentar_Click);
            // 
            // Btrecuperar
            // 
            this.Btrecuperar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btrecuperar.Location = new System.Drawing.Point(16, 70);
            this.Btrecuperar.Name = "Btrecuperar";
            this.Btrecuperar.Size = new System.Drawing.Size(174, 61);
            this.Btrecuperar.TabIndex = 8;
            this.Btrecuperar.Text = "Recuperar mana";
            this.Btrecuperar.UseVisualStyleBackColor = true;
            this.Btrecuperar.Click += new System.EventHandler(this.Btrecuperar_Click);
            // 
            // OpcionDeBuffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 236);
            this.Controls.Add(this.panel1);
            this.Name = "OpcionDeBuffer";
            this.Text = "OpcionDeBuffer";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelcancelar;
        private System.Windows.Forms.Label labelrecuperar;
        private System.Windows.Forms.Label labelaumentar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Btaumentar;
        private System.Windows.Forms.Button Btrecuperar;
    }
}