namespace GUI
{
    partial class VistaConsulPrgRp
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
            this.tablapreyres = new System.Windows.Forms.DataGridView();
            this.Btcategoria = new MaterialSkin.Controls.MaterialButton();
            this.Btagregar = new MaterialSkin.Controls.MaterialButton();
            this.Btsalir = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.tablapreyres)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(698, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulta de Preguntas y Respuestas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tablapreyres
            // 
            this.tablapreyres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablapreyres.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.tablapreyres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablapreyres.Location = new System.Drawing.Point(102, 153);
            this.tablapreyres.Name = "tablapreyres";
            this.tablapreyres.Size = new System.Drawing.Size(692, 359);
            this.tablapreyres.TabIndex = 2;
            // 
            // Btcategoria
            // 
            this.Btcategoria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btcategoria.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btcategoria.Depth = 0;
            this.Btcategoria.HighEmphasis = true;
            this.Btcategoria.Icon = null;
            this.Btcategoria.Location = new System.Drawing.Point(102, 536);
            this.Btcategoria.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btcategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btcategoria.Name = "Btcategoria";
            this.Btcategoria.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Btcategoria.Size = new System.Drawing.Size(206, 36);
            this.Btcategoria.TabIndex = 3;
            this.Btcategoria.Text = "MOSTRAR POR CATEGORIA";
            this.Btcategoria.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btcategoria.UseAccentColor = false;
            this.Btcategoria.UseVisualStyleBackColor = true;
            this.Btcategoria.Click += new System.EventHandler(this.materialBtnCategoria_Click);
            // 
            // Btagregar
            // 
            this.Btagregar.AutoSize = false;
            this.Btagregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btagregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btagregar.Depth = 0;
            this.Btagregar.HighEmphasis = true;
            this.Btagregar.Icon = null;
            this.Btagregar.Location = new System.Drawing.Point(351, 536);
            this.Btagregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btagregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btagregar.Name = "Btagregar";
            this.Btagregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Btagregar.Size = new System.Drawing.Size(206, 36);
            this.Btagregar.TabIndex = 3;
            this.Btagregar.Text = "Agregar";
            this.Btagregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btagregar.UseAccentColor = false;
            this.Btagregar.UseVisualStyleBackColor = true;
            this.Btagregar.Click += new System.EventHandler(this.materialBtnAgregar_Click);
            // 
            // Btsalir
            // 
            this.Btsalir.AutoSize = false;
            this.Btsalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btsalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btsalir.Depth = 0;
            this.Btsalir.HighEmphasis = true;
            this.Btsalir.Icon = null;
            this.Btsalir.Location = new System.Drawing.Point(589, 536);
            this.Btsalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btsalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btsalir.Name = "Btsalir";
            this.Btsalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Btsalir.Size = new System.Drawing.Size(206, 36);
            this.Btsalir.TabIndex = 3;
            this.Btsalir.Text = "VOLVER";
            this.Btsalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btsalir.UseAccentColor = false;
            this.Btsalir.UseVisualStyleBackColor = true;
            this.Btsalir.Click += new System.EventHandler(this.materialBtnVolver_Click);
            // 
            // VistaConsulPrgRp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.Btsalir);
            this.Controls.Add(this.Btagregar);
            this.Controls.Add(this.Btcategoria);
            this.Controls.Add(this.tablapreyres);
            this.Controls.Add(this.label1);
            this.Name = "VistaConsulPrgRp";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preguntas y Respuestas";
            ((System.ComponentModel.ISupportInitialize)(this.tablapreyres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablapreyres;
        private MaterialSkin.Controls.MaterialButton Btcategoria;
        private MaterialSkin.Controls.MaterialButton Btagregar;
        private MaterialSkin.Controls.MaterialButton Btsalir;
    }
}