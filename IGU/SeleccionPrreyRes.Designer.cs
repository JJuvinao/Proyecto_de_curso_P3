namespace IGU
{
    partial class SeleccionPrreyRes
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
            this.labelpregunta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btrepuesta1 = new System.Windows.Forms.Button();
            this.Btrepuesta2 = new System.Windows.Forms.Button();
            this.Btrepuesta3 = new System.Windows.Forms.Button();
            this.Btrepuesta4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelpregunta);
            this.panel1.Location = new System.Drawing.Point(9, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 141);
            this.panel1.TabIndex = 0;
            // 
            // labelpregunta
            // 
            this.labelpregunta.Location = new System.Drawing.Point(3, 33);
            this.labelpregunta.Name = "labelpregunta";
            this.labelpregunta.Size = new System.Drawing.Size(465, 93);
            this.labelpregunta.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PREGUNTA";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Btrepuesta4);
            this.panel2.Controls.Add(this.Btrepuesta3);
            this.panel2.Controls.Add(this.Btrepuesta2);
            this.panel2.Controls.Add(this.Btrepuesta1);
            this.panel2.Location = new System.Drawing.Point(9, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 121);
            this.panel2.TabIndex = 1;
            // 
            // Btrepuesta1
            // 
            this.Btrepuesta1.Location = new System.Drawing.Point(2, 3);
            this.Btrepuesta1.Name = "Btrepuesta1";
            this.Btrepuesta1.Size = new System.Drawing.Size(230, 57);
            this.Btrepuesta1.TabIndex = 0;
            this.Btrepuesta1.UseVisualStyleBackColor = true;
            this.Btrepuesta1.Click += new System.EventHandler(this.Btrepuesta1_Click);
            // 
            // Btrepuesta2
            // 
            this.Btrepuesta2.Location = new System.Drawing.Point(238, 3);
            this.Btrepuesta2.Name = "Btrepuesta2";
            this.Btrepuesta2.Size = new System.Drawing.Size(230, 57);
            this.Btrepuesta2.TabIndex = 1;
            this.Btrepuesta2.UseVisualStyleBackColor = true;
            this.Btrepuesta2.Click += new System.EventHandler(this.Btrepuesta2_Click);
            // 
            // Btrepuesta3
            // 
            this.Btrepuesta3.Location = new System.Drawing.Point(2, 61);
            this.Btrepuesta3.Name = "Btrepuesta3";
            this.Btrepuesta3.Size = new System.Drawing.Size(230, 57);
            this.Btrepuesta3.TabIndex = 2;
            this.Btrepuesta3.UseVisualStyleBackColor = true;
            this.Btrepuesta3.Click += new System.EventHandler(this.Btrepuesta3_Click);
            // 
            // Btrepuesta4
            // 
            this.Btrepuesta4.Location = new System.Drawing.Point(238, 61);
            this.Btrepuesta4.Name = "Btrepuesta4";
            this.Btrepuesta4.Size = new System.Drawing.Size(230, 57);
            this.Btrepuesta4.TabIndex = 3;
            this.Btrepuesta4.UseVisualStyleBackColor = true;
            this.Btrepuesta4.Click += new System.EventHandler(this.Btrepuesta4_Click);
            // 
            // SeleccionPrreyRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 292);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SeleccionPrreyRes";
            this.Text = "SeleccionPrreyRes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelpregunta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btrepuesta4;
        private System.Windows.Forms.Button Btrepuesta3;
        private System.Windows.Forms.Button Btrepuesta2;
        private System.Windows.Forms.Button Btrepuesta1;
    }
}