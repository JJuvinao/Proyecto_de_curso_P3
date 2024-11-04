namespace IGU
{
    partial class VistaMundo
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
            this.Btfondo1 = new System.Windows.Forms.Button();
            this.Btfondo2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Btfondo1
            // 
            this.Btfondo1.Location = new System.Drawing.Point(9, 15);
            this.Btfondo1.Name = "Btfondo1";
            this.Btfondo1.Size = new System.Drawing.Size(158, 48);
            this.Btfondo1.TabIndex = 0;
            this.Btfondo1.Text = "Fondo1";
            this.Btfondo1.UseVisualStyleBackColor = true;
            this.Btfondo1.Click += new System.EventHandler(this.Btfondo1_Click);
            // 
            // Btfondo2
            // 
            this.Btfondo2.Location = new System.Drawing.Point(197, 15);
            this.Btfondo2.Name = "Btfondo2";
            this.Btfondo2.Size = new System.Drawing.Size(164, 47);
            this.Btfondo2.TabIndex = 1;
            this.Btfondo2.Text = "Fondo2";
            this.Btfondo2.UseVisualStyleBackColor = true;
            this.Btfondo2.Click += new System.EventHandler(this.Btfondo2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Btfondo2);
            this.panel2.Controls.Add(this.Btfondo1);
            this.panel2.Location = new System.Drawing.Point(3, 372);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 76);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Picture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 451);
            this.panel1.TabIndex = 0;
            // 
            // Picture
            // 
            this.Picture.Location = new System.Drawing.Point(3, 3);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(640, 268);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "ESCOGER MUNDO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VistaMundo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 451);
            this.Controls.Add(this.panel1);
            this.Name = "VistaMundo";
            this.Text = "VistaMundo";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btfondo1;
        private System.Windows.Forms.Button Btfondo2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Button button1;
    }
}