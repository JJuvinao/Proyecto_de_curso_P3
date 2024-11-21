namespace GUI
{
    partial class VistaEscogerPersonajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaEscogerPersonajes));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Btsigui = new MaterialSkin.Controls.MaterialButton();
            this.BtCANCELAR = new MaterialSkin.Controls.MaterialButton();
            this.Btescojer = new MaterialSkin.Controls.MaterialButton();
            this.Btante = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.labelfuerza = new MaterialSkin.Controls.MaterialTextBox();
            this.labeldefensa = new MaterialSkin.Controls.MaterialTextBox();
            this.labelvida = new MaterialSkin.Controls.MaterialTextBox();
            this.labelmana = new MaterialSkin.Controls.MaterialTextBox();
            this.labelperso = new MaterialSkin.Controls.MaterialTextBox();
            this.labelclase = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.labelhabi2 = new System.Windows.Forms.Label();
            this.labelhabi1 = new System.Windows.Forms.Label();
            this.labelbasico = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialCard1.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.Btsigui);
            this.tabPage1.Controls.Add(this.BtCANCELAR);
            this.tabPage1.Controls.Add(this.Btescojer);
            this.tabPage1.Controls.Add(this.Btante);
            this.tabPage1.Controls.Add(this.materialCard1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ImageKey = "icons8-contact-details-52.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(886, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Informacion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Btsigui
            // 
            this.Btsigui.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btsigui.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btsigui.Depth = 0;
            this.Btsigui.HighEmphasis = true;
            this.Btsigui.Icon = null;
            this.Btsigui.Location = new System.Drawing.Point(389, 453);
            this.Btsigui.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btsigui.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btsigui.Name = "Btsigui";
            this.Btsigui.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Btsigui.Size = new System.Drawing.Size(95, 36);
            this.Btsigui.TabIndex = 5;
            this.Btsigui.Text = "Siguiente";
            this.Btsigui.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btsigui.UseAccentColor = false;
            this.Btsigui.UseVisualStyleBackColor = true;
            this.Btsigui.Click += new System.EventHandler(this.Btsigui_Click);
            // 
            // BtCANCELAR
            // 
            this.BtCANCELAR.AutoSize = false;
            this.BtCANCELAR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtCANCELAR.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtCANCELAR.Depth = 0;
            this.BtCANCELAR.HighEmphasis = true;
            this.BtCANCELAR.Icon = null;
            this.BtCANCELAR.Location = new System.Drawing.Point(553, 208);
            this.BtCANCELAR.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtCANCELAR.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtCANCELAR.Name = "BtCANCELAR";
            this.BtCANCELAR.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtCANCELAR.Size = new System.Drawing.Size(173, 36);
            this.BtCANCELAR.TabIndex = 5;
            this.BtCANCELAR.Text = "CANCELAR";
            this.BtCANCELAR.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtCANCELAR.UseAccentColor = false;
            this.BtCANCELAR.UseVisualStyleBackColor = true;
            this.BtCANCELAR.Click += new System.EventHandler(this.BtCANCELAR_Click);
            // 
            // Btescojer
            // 
            this.Btescojer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btescojer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btescojer.Depth = 0;
            this.Btescojer.HighEmphasis = true;
            this.Btescojer.Icon = null;
            this.Btescojer.Location = new System.Drawing.Point(553, 141);
            this.Btescojer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btescojer.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btescojer.Name = "Btescojer";
            this.Btescojer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Btescojer.Size = new System.Drawing.Size(173, 36);
            this.Btescojer.TabIndex = 5;
            this.Btescojer.Text = "ESCOGER PERSONAJE";
            this.Btescojer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btescojer.UseAccentColor = false;
            this.Btescojer.UseVisualStyleBackColor = true;
            this.Btescojer.Click += new System.EventHandler(this.materialBtnEscPer_Click);
            // 
            // Btante
            // 
            this.Btante.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btante.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btante.Depth = 0;
            this.Btante.HighEmphasis = true;
            this.Btante.Icon = null;
            this.Btante.Location = new System.Drawing.Point(140, 453);
            this.Btante.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btante.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btante.Name = "Btante";
            this.Btante.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Btante.Size = new System.Drawing.Size(92, 36);
            this.Btante.TabIndex = 5;
            this.Btante.Text = "Anterior";
            this.Btante.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btante.UseAccentColor = false;
            this.Btante.UseVisualStyleBackColor = true;
            this.Btante.Click += new System.EventHandler(this.Btante_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.labelfuerza);
            this.materialCard1.Controls.Add(this.labeldefensa);
            this.materialCard1.Controls.Add(this.labelvida);
            this.materialCard1.Controls.Add(this.labelmana);
            this.materialCard1.Controls.Add(this.labelperso);
            this.materialCard1.Controls.Add(this.labelclase);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(106, 60);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(410, 373);
            this.materialCard1.TabIndex = 4;
            // 
            // labelfuerza
            // 
            this.labelfuerza.AnimateReadOnly = false;
            this.labelfuerza.BackColor = System.Drawing.SystemColors.Window;
            this.labelfuerza.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelfuerza.Depth = 0;
            this.labelfuerza.Enabled = false;
            this.labelfuerza.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelfuerza.Hint = "Fuerza";
            this.labelfuerza.LeadingIcon = global::GUI.Properties.Resources.icons8_strength_50;
            this.labelfuerza.Location = new System.Drawing.Point(34, 246);
            this.labelfuerza.MaxLength = 50;
            this.labelfuerza.MouseState = MaterialSkin.MouseState.OUT;
            this.labelfuerza.Multiline = false;
            this.labelfuerza.Name = "labelfuerza";
            this.labelfuerza.Size = new System.Drawing.Size(344, 50);
            this.labelfuerza.TabIndex = 0;
            this.labelfuerza.Text = "";
            this.labelfuerza.TrailingIcon = null;
            // 
            // labeldefensa
            // 
            this.labeldefensa.AnimateReadOnly = false;
            this.labeldefensa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labeldefensa.Depth = 0;
            this.labeldefensa.Enabled = false;
            this.labeldefensa.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labeldefensa.Hint = "Defensa";
            this.labeldefensa.LeadingIcon = global::GUI.Properties.Resources.icons8_defense_32;
            this.labeldefensa.Location = new System.Drawing.Point(34, 302);
            this.labeldefensa.MaxLength = 50;
            this.labeldefensa.MouseState = MaterialSkin.MouseState.OUT;
            this.labeldefensa.Multiline = false;
            this.labeldefensa.Name = "labeldefensa";
            this.labeldefensa.Size = new System.Drawing.Size(344, 50);
            this.labeldefensa.TabIndex = 0;
            this.labeldefensa.Text = "";
            this.labeldefensa.TrailingIcon = null;
            // 
            // labelvida
            // 
            this.labelvida.AnimateReadOnly = false;
            this.labelvida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelvida.Depth = 0;
            this.labelvida.Enabled = false;
            this.labelvida.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelvida.Hint = "Vida";
            this.labelvida.LeadingIcon = global::GUI.Properties.Resources.icons8_heart_50;
            this.labelvida.Location = new System.Drawing.Point(34, 134);
            this.labelvida.MaxLength = 50;
            this.labelvida.MouseState = MaterialSkin.MouseState.OUT;
            this.labelvida.Multiline = false;
            this.labelvida.Name = "labelvida";
            this.labelvida.Size = new System.Drawing.Size(344, 50);
            this.labelvida.TabIndex = 0;
            this.labelvida.Text = "";
            this.labelvida.TrailingIcon = null;
            // 
            // labelmana
            // 
            this.labelmana.AnimateReadOnly = false;
            this.labelmana.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelmana.Depth = 0;
            this.labelmana.Enabled = false;
            this.labelmana.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelmana.Hint = "Mana";
            this.labelmana.LeadingIcon = global::GUI.Properties.Resources.icons8_mana_50;
            this.labelmana.Location = new System.Drawing.Point(34, 190);
            this.labelmana.MaxLength = 50;
            this.labelmana.MouseState = MaterialSkin.MouseState.OUT;
            this.labelmana.Multiline = false;
            this.labelmana.Name = "labelmana";
            this.labelmana.Size = new System.Drawing.Size(344, 50);
            this.labelmana.TabIndex = 0;
            this.labelmana.Text = "";
            this.labelmana.TrailingIcon = null;
            // 
            // labelperso
            // 
            this.labelperso.AnimateReadOnly = false;
            this.labelperso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelperso.Depth = 0;
            this.labelperso.Enabled = false;
            this.labelperso.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelperso.Hint = "Nombre";
            this.labelperso.LeadingIcon = global::GUI.Properties.Resources.icons8_contacts_32;
            this.labelperso.Location = new System.Drawing.Point(34, 22);
            this.labelperso.MaxLength = 50;
            this.labelperso.MouseState = MaterialSkin.MouseState.OUT;
            this.labelperso.Multiline = false;
            this.labelperso.Name = "labelperso";
            this.labelperso.Size = new System.Drawing.Size(344, 50);
            this.labelperso.TabIndex = 0;
            this.labelperso.Text = "";
            this.labelperso.TrailingIcon = null;
            // 
            // labelclase
            // 
            this.labelclase.AnimateReadOnly = false;
            this.labelclase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelclase.Depth = 0;
            this.labelclase.Enabled = false;
            this.labelclase.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelclase.Hint = "Clase";
            this.labelclase.LeadingIcon = global::GUI.Properties.Resources.icons8_gen_24;
            this.labelclase.Location = new System.Drawing.Point(34, 78);
            this.labelclase.MaxLength = 50;
            this.labelclase.MouseState = MaterialSkin.MouseState.OUT;
            this.labelclase.Multiline = false;
            this.labelclase.Name = "labelclase";
            this.labelclase.Size = new System.Drawing.Size(344, 50);
            this.labelclase.TabIndex = 0;
            this.labelclase.Text = "";
            this.labelclase.TrailingIcon = null;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(698, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Informacion del personaje";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialCard2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.ImageKey = "icons8-mage-staff-64.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(886, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Habilidades";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialButton2);
            this.materialCard2.Controls.Add(this.materialButton3);
            this.materialCard2.Controls.Add(this.materialButton1);
            this.materialCard2.Controls.Add(this.labelhabi2);
            this.materialCard2.Controls.Add(this.labelhabi1);
            this.materialCard2.Controls.Add(this.labelbasico);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(93, 81);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(693, 360);
            this.materialCard2.TabIndex = 5;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.Enabled = false;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(116, 77);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(158, 36);
            this.materialButton2.TabIndex = 13;
            this.materialButton2.Text = "GOLPE BASICO";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSize = false;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.Enabled = false;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(116, 248);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(158, 36);
            this.materialButton3.TabIndex = 13;
            this.materialButton3.Text = "HABILIDAD 2";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.Enabled = false;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(116, 157);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(158, 36);
            this.materialButton1.TabIndex = 13;
            this.materialButton1.Text = "HABILIDAD 1";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // labelhabi2
            // 
            this.labelhabi2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelhabi2.Location = new System.Drawing.Point(281, 242);
            this.labelhabi2.Name = "labelhabi2";
            this.labelhabi2.Size = new System.Drawing.Size(264, 54);
            this.labelhabi2.TabIndex = 12;
            // 
            // labelhabi1
            // 
            this.labelhabi1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelhabi1.Location = new System.Drawing.Point(281, 151);
            this.labelhabi1.Name = "labelhabi1";
            this.labelhabi1.Size = new System.Drawing.Size(264, 54);
            this.labelhabi1.TabIndex = 10;
            // 
            // labelbasico
            // 
            this.labelbasico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelbasico.Location = new System.Drawing.Point(281, 71);
            this.labelbasico.Name = "labelbasico";
            this.labelbasico.Size = new System.Drawing.Size(264, 54);
            this.labelbasico.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(698, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Habilidades";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-contact-details-52.png");
            this.imageList1.Images.SetKeyName(1, "icons8-mage-staff-64.png");
            // 
            // VistaEscogerPersonajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "VistaEscogerPersonajes";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personajes";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton Btsigui;
        private MaterialSkin.Controls.MaterialButton Btante;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton BtCANCELAR;
        private MaterialSkin.Controls.MaterialButton Btescojer;
        private MaterialSkin.Controls.MaterialTextBox labelclase;
        private MaterialSkin.Controls.MaterialTextBox labelfuerza;
        private MaterialSkin.Controls.MaterialTextBox labeldefensa;
        private MaterialSkin.Controls.MaterialTextBox labelvida;
        private MaterialSkin.Controls.MaterialTextBox labelmana;
        private MaterialSkin.Controls.MaterialTextBox labelperso;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Label labelhabi2;
        private System.Windows.Forms.Label labelhabi1;
        private System.Windows.Forms.Label labelbasico;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}