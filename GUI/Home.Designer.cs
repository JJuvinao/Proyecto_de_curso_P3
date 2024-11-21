namespace GUI
{
    partial class Home
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialBtnRegistrar = new MaterialSkin.Controls.MaterialButton();
            this.materialBtnIniciar = new MaterialSkin.Controls.MaterialButton();
            this.txtcontra = new MaterialSkin.Controls.MaterialTextBox();
            this.txtnombre = new MaterialSkin.Controls.MaterialTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.materialCard1);
            this.tabPage2.Controls.Add(this.materialBtnRegistrar);
            this.tabPage2.Controls.Add(this.materialBtnIniciar);
            this.tabPage2.Controls.Add(this.txtcontra);
            this.tabPage2.Controls.Add(this.txtnombre);
            this.tabPage2.ImageKey = "icons8-login-50.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(886, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Login";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(551, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Login";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.pictureBox1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 17);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(336, 464);
            this.materialCard1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.LogoHdAPp_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(38, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // materialBtnRegistrar
            // 
            this.materialBtnRegistrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialBtnRegistrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialBtnRegistrar.Depth = 0;
            this.materialBtnRegistrar.HighEmphasis = true;
            this.materialBtnRegistrar.Icon = null;
            this.materialBtnRegistrar.Location = new System.Drawing.Point(452, 257);
            this.materialBtnRegistrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialBtnRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialBtnRegistrar.Name = "materialBtnRegistrar";
            this.materialBtnRegistrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialBtnRegistrar.Size = new System.Drawing.Size(99, 36);
            this.materialBtnRegistrar.TabIndex = 3;
            this.materialBtnRegistrar.Text = "REGISTRAR";
            this.materialBtnRegistrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialBtnRegistrar.UseAccentColor = false;
            this.materialBtnRegistrar.UseVisualStyleBackColor = true;
            this.materialBtnRegistrar.Click += new System.EventHandler(this.materialBtnRegistrar_Click);
            // 
            // materialBtnIniciar
            // 
            this.materialBtnIniciar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialBtnIniciar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialBtnIniciar.Depth = 0;
            this.materialBtnIniciar.HighEmphasis = true;
            this.materialBtnIniciar.Icon = null;
            this.materialBtnIniciar.Location = new System.Drawing.Point(371, 257);
            this.materialBtnIniciar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialBtnIniciar.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialBtnIniciar.Name = "materialBtnIniciar";
            this.materialBtnIniciar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialBtnIniciar.Size = new System.Drawing.Size(73, 36);
            this.materialBtnIniciar.TabIndex = 2;
            this.materialBtnIniciar.Tag = "0";
            this.materialBtnIniciar.Text = "INICIAR";
            this.materialBtnIniciar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialBtnIniciar.UseAccentColor = false;
            this.materialBtnIniciar.UseVisualStyleBackColor = true;
            this.materialBtnIniciar.Click += new System.EventHandler(this.materialBtnIniciar_Click);
            // 
            // txtcontra
            // 
            this.txtcontra.AnimateReadOnly = false;
            this.txtcontra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontra.Depth = 0;
            this.txtcontra.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtcontra.Hint = "Password";
            this.txtcontra.LeadingIcon = null;
            this.txtcontra.Location = new System.Drawing.Point(370, 198);
            this.txtcontra.MaxLength = 50;
            this.txtcontra.MouseState = MaterialSkin.MouseState.OUT;
            this.txtcontra.Multiline = false;
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Password = true;
            this.txtcontra.Size = new System.Drawing.Size(425, 50);
            this.txtcontra.TabIndex = 1;
            this.txtcontra.Text = "";
            this.txtcontra.TrailingIcon = null;
            // 
            // txtnombre
            // 
            this.txtnombre.AnimateReadOnly = false;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Depth = 0;
            this.txtnombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtnombre.Hint = "Username";
            this.txtnombre.LeadingIcon = null;
            this.txtnombre.Location = new System.Drawing.Point(370, 125);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtnombre.Multiline = false;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(425, 50);
            this.txtnombre.TabIndex = 1;
            this.txtnombre.Text = "";
            this.txtnombre.TrailingIcon = null;
            // 
            // tabPage3
            // 
            this.tabPage3.ImageKey = "icons8-settings-32.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(886, 498);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-faq-52.png");
            this.imageList1.Images.SetKeyName(1, "icons8-home-52.png");
            this.imageList1.Images.SetKeyName(2, "icons8-settings-32.png");
            this.imageList1.Images.SetKeyName(3, "icons8-login-50.png");
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Home";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Heroes del Aprendizaje";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialTextBox txtcontra;
        private MaterialSkin.Controls.MaterialTextBox txtnombre;
        private MaterialSkin.Controls.MaterialButton materialBtnIniciar;
        private MaterialSkin.Controls.MaterialButton materialBtnRegistrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label label1;
    }
}

