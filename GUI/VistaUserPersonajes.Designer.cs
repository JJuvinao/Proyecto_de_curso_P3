using System;

namespace GUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaUserPersonajes));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.BtPreguntas = new MaterialSkin.Controls.MaterialButton();
            this.materialBtnSalir = new MaterialSkin.Controls.MaterialButton();
            this.materialBtnConfig = new MaterialSkin.Controls.MaterialButton();
            this.tablapuntaje = new System.Windows.Forms.DataGridView();
            this.txtrol = new MaterialSkin.Controls.MaterialTextBox();
            this.txtnombre = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.Btpersonaje3 = new MaterialSkin.Controls.MaterialButton();
            this.label6 = new System.Windows.Forms.Label();
            this.Btpersonaje2 = new MaterialSkin.Controls.MaterialButton();
            this.label5 = new System.Windows.Forms.Label();
            this.Btpersonaje1 = new MaterialSkin.Controls.MaterialButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablapuntaje)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(894, 533);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialCard1);
            this.tabPage1.Controls.Add(this.tablapuntaje);
            this.tabPage1.Controls.Add(this.txtrol);
            this.tabPage1.Controls.Add(this.txtnombre);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ImageKey = "icons8-contacts-32.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(886, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Usuarios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.BtPreguntas);
            this.materialCard1.Controls.Add(this.materialBtnSalir);
            this.materialCard1.Controls.Add(this.materialBtnConfig);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(414, 34);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(328, 217);
            this.materialCard1.TabIndex = 3;
            // 
            // BtPreguntas
            // 
            this.BtPreguntas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtPreguntas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtPreguntas.Depth = 0;
            this.BtPreguntas.Enabled = false;
            this.BtPreguntas.HighEmphasis = true;
            this.BtPreguntas.Icon = null;
            this.BtPreguntas.Location = new System.Drawing.Point(63, 138);
            this.BtPreguntas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtPreguntas.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtPreguntas.Name = "BtPreguntas";
            this.BtPreguntas.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtPreguntas.Size = new System.Drawing.Size(212, 36);
            this.BtPreguntas.TabIndex = 1;
            this.BtPreguntas.Text = "PREGUNTAS Y RESPUESTAS";
            this.BtPreguntas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtPreguntas.UseAccentColor = false;
            this.BtPreguntas.UseVisualStyleBackColor = true;
            this.BtPreguntas.Click += new System.EventHandler(this.Btpreguntas_Click);
            // 
            // materialBtnSalir
            // 
            this.materialBtnSalir.AutoSize = false;
            this.materialBtnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialBtnSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialBtnSalir.Depth = 0;
            this.materialBtnSalir.HighEmphasis = true;
            this.materialBtnSalir.Icon = null;
            this.materialBtnSalir.Location = new System.Drawing.Point(63, 79);
            this.materialBtnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialBtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialBtnSalir.Name = "materialBtnSalir";
            this.materialBtnSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialBtnSalir.Size = new System.Drawing.Size(212, 36);
            this.materialBtnSalir.TabIndex = 0;
            this.materialBtnSalir.Text = "SALIR";
            this.materialBtnSalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialBtnSalir.UseAccentColor = false;
            this.materialBtnSalir.UseVisualStyleBackColor = true;
            this.materialBtnSalir.Click += new System.EventHandler(this.materialBtnSalir_Click);
            // 
            // materialBtnConfig
            // 
            this.materialBtnConfig.AutoSize = false;
            this.materialBtnConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialBtnConfig.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialBtnConfig.Depth = 0;
            this.materialBtnConfig.HighEmphasis = true;
            this.materialBtnConfig.Icon = null;
            this.materialBtnConfig.Location = new System.Drawing.Point(63, 20);
            this.materialBtnConfig.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialBtnConfig.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialBtnConfig.Name = "materialBtnConfig";
            this.materialBtnConfig.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialBtnConfig.Size = new System.Drawing.Size(212, 36);
            this.materialBtnConfig.TabIndex = 0;
            this.materialBtnConfig.Text = "CONFIGURACION";
            this.materialBtnConfig.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialBtnConfig.UseAccentColor = false;
            this.materialBtnConfig.UseVisualStyleBackColor = true;
            this.materialBtnConfig.Click += new System.EventHandler(this.materialBtnConfig_Click);
            // 
            // tablapuntaje
            // 
            this.tablapuntaje.AllowUserToOrderColumns = true;
            this.tablapuntaje.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablapuntaje.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.tablapuntaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablapuntaje.Location = new System.Drawing.Point(53, 290);
            this.tablapuntaje.Name = "tablapuntaje";
            this.tablapuntaje.Size = new System.Drawing.Size(689, 150);
            this.tablapuntaje.TabIndex = 2;
            // 
            // txtrol
            // 
            this.txtrol.AnimateReadOnly = false;
            this.txtrol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrol.Depth = 0;
            this.txtrol.Enabled = false;
            this.txtrol.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtrol.Hint = "Rol";
            this.txtrol.LeadingIcon = null;
            this.txtrol.Location = new System.Drawing.Point(53, 158);
            this.txtrol.MaxLength = 50;
            this.txtrol.MouseState = MaterialSkin.MouseState.OUT;
            this.txtrol.Multiline = false;
            this.txtrol.Name = "txtrol";
            this.txtrol.Size = new System.Drawing.Size(236, 50);
            this.txtrol.TabIndex = 1;
            this.txtrol.Text = "";
            this.txtrol.TrailingIcon = null;
            // 
            // txtnombre
            // 
            this.txtnombre.AnimateReadOnly = false;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Depth = 0;
            this.txtnombre.Enabled = false;
            this.txtnombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtnombre.Hint = "Username";
            this.txtnombre.LeadingIcon = null;
            this.txtnombre.Location = new System.Drawing.Point(53, 77);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtnombre.Multiline = false;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(236, 50);
            this.txtnombre.TabIndex = 1;
            this.txtnombre.Text = "";
            this.txtnombre.TrailingIcon = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Puntaje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informacion del Usuario";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialCard2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.ImageKey = "icons8-character-animator-64.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(886, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Personajes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.Btpersonaje3);
            this.materialCard2.Controls.Add(this.label6);
            this.materialCard2.Controls.Add(this.Btpersonaje2);
            this.materialCard2.Controls.Add(this.label5);
            this.materialCard2.Controls.Add(this.Btpersonaje1);
            this.materialCard2.Controls.Add(this.label4);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(140, 86);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(598, 334);
            this.materialCard2.TabIndex = 2;
            // 
            // Btpersonaje3
            // 
            this.Btpersonaje3.AutoSize = false;
            this.Btpersonaje3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btpersonaje3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btpersonaje3.Depth = 0;
            this.Btpersonaje3.HighEmphasis = true;
            this.Btpersonaje3.Icon = null;
            this.Btpersonaje3.Location = new System.Drawing.Point(232, 261);
            this.Btpersonaje3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btpersonaje3.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btpersonaje3.Name = "Btpersonaje3";
            this.Btpersonaje3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Btpersonaje3.Size = new System.Drawing.Size(150, 50);
            this.Btpersonaje3.TabIndex = 4;
            this.Btpersonaje3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btpersonaje3.UseAccentColor = false;
            this.Btpersonaje3.UseVisualStyleBackColor = true;
            this.Btpersonaje3.Click += new System.EventHandler(this.Btpersonaje3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(240, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Personaje 3";
            // 
            // Btpersonaje2
            // 
            this.Btpersonaje2.AutoSize = false;
            this.Btpersonaje2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btpersonaje2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btpersonaje2.Depth = 0;
            this.Btpersonaje2.HighEmphasis = true;
            this.Btpersonaje2.Icon = null;
            this.Btpersonaje2.Location = new System.Drawing.Point(232, 164);
            this.Btpersonaje2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btpersonaje2.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btpersonaje2.Name = "Btpersonaje2";
            this.Btpersonaje2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Btpersonaje2.Size = new System.Drawing.Size(150, 50);
            this.Btpersonaje2.TabIndex = 4;
            this.Btpersonaje2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btpersonaje2.UseAccentColor = false;
            this.Btpersonaje2.UseVisualStyleBackColor = true;
            this.Btpersonaje2.Click += new System.EventHandler(this.Btpersonaje2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(240, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Personaje 2";
            // 
            // Btpersonaje1
            // 
            this.Btpersonaje1.AutoEllipsis = true;
            this.Btpersonaje1.AutoSize = false;
            this.Btpersonaje1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btpersonaje1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btpersonaje1.Depth = 0;
            this.Btpersonaje1.HighEmphasis = true;
            this.Btpersonaje1.Icon = null;
            this.Btpersonaje1.Location = new System.Drawing.Point(232, 55);
            this.Btpersonaje1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btpersonaje1.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btpersonaje1.Name = "Btpersonaje1";
            this.Btpersonaje1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Btpersonaje1.Size = new System.Drawing.Size(150, 50);
            this.Btpersonaje1.TabIndex = 4;
            this.Btpersonaje1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btpersonaje1.UseAccentColor = false;
            this.Btpersonaje1.UseVisualStyleBackColor = true;
            this.Btpersonaje1.Click += new System.EventHandler(this.Btpersonaje1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Personaje 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Personajes";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-character-animator-64.png");
            this.imageList1.Images.SetKeyName(1, "icons8-contacts-32.png");
            // 
            // VistaUserPersonajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "VistaUserPersonajes";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios y Personajes";
            this.Load += new System.EventHandler(this.VistaUserPersonajes_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablapuntaje)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox txtnombre;
        private MaterialSkin.Controls.MaterialTextBox txtrol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tablapuntaje;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton materialBtnSalir;
        private MaterialSkin.Controls.MaterialButton materialBtnConfig;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialButton Btpersonaje3;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialButton Btpersonaje2;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialButton Btpersonaje1;
        private MaterialSkin.Controls.MaterialButton BtPreguntas;
    }
}