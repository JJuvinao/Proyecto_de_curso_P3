﻿namespace IGU
{
    partial class VistaUserPersonajes
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btpersonaje1 = new System.Windows.Forms.Button();
            this.Btpersonaje2 = new System.Windows.Forms.Button();
            this.Btpersonaje3 = new System.Windows.Forms.Button();
            this.Btvolver = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Btvolver);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 297);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Btpersonaje3);
            this.panel2.Controls.Add(this.Btpersonaje2);
            this.panel2.Controls.Add(this.Btpersonaje1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(454, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 297);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informacion del user";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Personajes";
            // 
            // Btpersonaje1
            // 
            this.Btpersonaje1.Location = new System.Drawing.Point(10, 42);
            this.Btpersonaje1.Name = "Btpersonaje1";
            this.Btpersonaje1.Size = new System.Drawing.Size(190, 55);
            this.Btpersonaje1.TabIndex = 1;
            this.Btpersonaje1.Text = "Personaje1";
            this.Btpersonaje1.UseVisualStyleBackColor = true;
            this.Btpersonaje1.Click += new System.EventHandler(this.Btpersonaje1_Click);
            // 
            // Btpersonaje2
            // 
            this.Btpersonaje2.Location = new System.Drawing.Point(10, 118);
            this.Btpersonaje2.Name = "Btpersonaje2";
            this.Btpersonaje2.Size = new System.Drawing.Size(190, 55);
            this.Btpersonaje2.TabIndex = 2;
            this.Btpersonaje2.Text = "Personaje2";
            this.Btpersonaje2.UseVisualStyleBackColor = true;
            this.Btpersonaje2.Click += new System.EventHandler(this.Btpersonaje2_Click);
            // 
            // Btpersonaje3
            // 
            this.Btpersonaje3.Location = new System.Drawing.Point(10, 194);
            this.Btpersonaje3.Name = "Btpersonaje3";
            this.Btpersonaje3.Size = new System.Drawing.Size(190, 55);
            this.Btpersonaje3.TabIndex = 3;
            this.Btpersonaje3.Text = "Personaje3";
            this.Btpersonaje3.UseVisualStyleBackColor = true;
            this.Btpersonaje3.Click += new System.EventHandler(this.Btpersonaje3_Click);
            // 
            // Btvolver
            // 
            this.Btvolver.Location = new System.Drawing.Point(379, 13);
            this.Btvolver.Name = "Btvolver";
            this.Btvolver.Size = new System.Drawing.Size(51, 25);
            this.Btvolver.TabIndex = 1;
            this.Btvolver.Text = "volver";
            this.Btvolver.UseVisualStyleBackColor = true;
            this.Btvolver.Click += new System.EventHandler(this.BtVolver_Click);
            // 
            // VistaUserPersonajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 321);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "VistaUserPersonajes";
            this.Text = "VistaUserPersonajes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btpersonaje3;
        private System.Windows.Forms.Button Btpersonaje2;
        private System.Windows.Forms.Button Btpersonaje1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btvolver;
    }
}