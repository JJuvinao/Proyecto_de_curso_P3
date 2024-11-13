namespace IGU
{
    partial class VistaConsultaPreguntasYRespestas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btcategoria = new System.Windows.Forms.Button();
            this.Btordenar = new System.Windows.Forms.Button();
            this.Btagregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablapreyres)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablapreyres
            // 
            this.tablapreyres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablapreyres.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.tablapreyres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablapreyres.Location = new System.Drawing.Point(12, 46);
            this.tablapreyres.Name = "tablapreyres";
            this.tablapreyres.Size = new System.Drawing.Size(572, 208);
            this.tablapreyres.TabIndex = 0;
            // 
            // Btver
            // 
            this.Btver.Location = new System.Drawing.Point(3, 12);
            this.Btver.Name = "Btver";
            this.Btver.Size = new System.Drawing.Size(135, 50);
            this.Btver.TabIndex = 1;
            this.Btver.Text = "mostrar";
            this.Btver.UseVisualStyleBackColor = true;
            this.Btver.Click += new System.EventHandler(this.Btver_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btagregar);
            this.panel1.Controls.Add(this.Btordenar);
            this.panel1.Controls.Add(this.Btcategoria);
            this.panel1.Controls.Add(this.Btver);
            this.panel1.Location = new System.Drawing.Point(12, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 74);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "CONSULTA DE PREGUNTAS YRESPUESTAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btcategoria
            // 
            this.Btcategoria.Location = new System.Drawing.Point(162, 13);
            this.Btcategoria.Name = "Btcategoria";
            this.Btcategoria.Size = new System.Drawing.Size(120, 49);
            this.Btcategoria.TabIndex = 2;
            this.Btcategoria.Text = "MOSTRAR POR CATEGORIA";
            this.Btcategoria.UseVisualStyleBackColor = true;
            // 
            // Btordenar
            // 
            this.Btordenar.Location = new System.Drawing.Point(301, 14);
            this.Btordenar.Name = "Btordenar";
            this.Btordenar.Size = new System.Drawing.Size(112, 48);
            this.Btordenar.TabIndex = 3;
            this.Btordenar.Text = "ORDENAR";
            this.Btordenar.UseVisualStyleBackColor = true;
            // 
            // Btagregar
            // 
            this.Btagregar.Location = new System.Drawing.Point(444, 14);
            this.Btagregar.Name = "Btagregar";
            this.Btagregar.Size = new System.Drawing.Size(113, 47);
            this.Btagregar.TabIndex = 4;
            this.Btagregar.Text = "AGREGAR";
            this.Btagregar.UseVisualStyleBackColor = true;
            this.Btagregar.Click += new System.EventHandler(this.Btagregar_Click);
            // 
            // VistaConsultaPreguntasYRespestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 346);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tablapreyres);
            this.Name = "VistaConsultaPreguntasYRespestas";
            this.Text = "VistaConsultaPreguntasYRespestas";
            ((System.ComponentModel.ISupportInitialize)(this.tablapreyres)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablapreyres;
        private System.Windows.Forms.Button Btver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btordenar;
        private System.Windows.Forms.Button Btcategoria;
        private System.Windows.Forms.Button Btagregar;
    }
}