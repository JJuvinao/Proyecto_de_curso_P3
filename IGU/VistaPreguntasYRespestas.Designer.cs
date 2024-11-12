namespace IGU
{
    partial class VistaPreguntasYRespestas
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
            this.tablapreyres = new System.Windows.Forms.DataGridView();
            this.Btver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablapreyres)).BeginInit();
            this.SuspendLayout();
            // 
            // tablapreyres
            // 
            this.tablapreyres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablapreyres.Location = new System.Drawing.Point(16, 30);
            this.tablapreyres.Name = "tablapreyres";
            this.tablapreyres.Size = new System.Drawing.Size(332, 190);
            this.tablapreyres.TabIndex = 0;
            // 
            // Btver
            // 
            this.Btver.Location = new System.Drawing.Point(399, 37);
            this.Btver.Name = "Btver";
            this.Btver.Size = new System.Drawing.Size(138, 70);
            this.Btver.TabIndex = 1;
            this.Btver.Text = "mostrar";
            this.Btver.UseVisualStyleBackColor = true;
            this.Btver.Click += new System.EventHandler(this.Btver_Click);
            // 
            // VistaPreguntasYRespestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 381);
            this.Controls.Add(this.Btver);
            this.Controls.Add(this.tablapreyres);
            this.Name = "VistaPreguntasYRespestas";
            this.Text = "VistaPreguntasYRespestas";
            ((System.ComponentModel.ISupportInitialize)(this.tablapreyres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablapreyres;
        private System.Windows.Forms.Button Btver;
    }
}