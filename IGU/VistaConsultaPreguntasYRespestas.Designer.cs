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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btagregar = new System.Windows.Forms.Button();
            this.Btcategoria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btsalir = new System.Windows.Forms.Button();
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
            this.tablapreyres.Size = new System.Drawing.Size(580, 208);
            this.tablapreyres.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Btsalir);
            this.panel1.Controls.Add(this.Btagregar);
            this.panel1.Controls.Add(this.Btcategoria);
            this.panel1.Location = new System.Drawing.Point(12, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 74);
            this.panel1.TabIndex = 2;
            // 
            // Btagregar
            // 
            this.Btagregar.Location = new System.Drawing.Point(200, 12);
            this.Btagregar.Name = "Btagregar";
            this.Btagregar.Size = new System.Drawing.Size(180, 50);
            this.Btagregar.TabIndex = 4;
            this.Btagregar.Text = "AGREGAR";
            this.Btagregar.UseVisualStyleBackColor = true;
            this.Btagregar.Click += new System.EventHandler(this.Btagregar_Click);
            // 
            // Btcategoria
            // 
            this.Btcategoria.Location = new System.Drawing.Point(3, 12);
            this.Btcategoria.Name = "Btcategoria";
            this.Btcategoria.Size = new System.Drawing.Size(180, 50);
            this.Btcategoria.TabIndex = 2;
            this.Btcategoria.Text = "MOSTRAR POR CATEGORIA";
            this.Btcategoria.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "CONSULTA DE PREGUNTAS YRESPUESTAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btsalir
            // 
            this.Btsalir.Location = new System.Drawing.Point(395, 12);
            this.Btsalir.Name = "Btsalir";
            this.Btsalir.Size = new System.Drawing.Size(180, 50);
            this.Btsalir.TabIndex = 5;
            this.Btsalir.Text = "VOLVER";
            this.Btsalir.UseVisualStyleBackColor = true;
            this.Btsalir.Click += new System.EventHandler(this.Btsalir_Click);
            // 
            // VistaConsultaPreguntasYRespestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 346);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btcategoria;
        private System.Windows.Forms.Button Btagregar;
        private System.Windows.Forms.Button Btsalir;
    }
}