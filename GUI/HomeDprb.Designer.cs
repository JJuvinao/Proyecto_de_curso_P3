namespace GUI
{
    partial class HomeDprb
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeDprb));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.btolvidarcontra = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.btregistrar = new MaterialSkin.Controls.MaterialButton();
            this.btiniciar = new MaterialSkin.Controls.MaterialButton();
            this.txtcontra = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtnombre = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblLoginTitle = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPageLogin.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPageLogin);
            this.materialTabControl1.Controls.Add(this.tabPageSettings);
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
            // tabPageLogin
            // 
            this.tabPageLogin.BackColor = System.Drawing.Color.White;
            this.tabPageLogin.Controls.Add(this.materialCard2);
            this.tabPageLogin.Controls.Add(this.materialCard1);
            this.tabPageLogin.ImageKey = "icons8-login-50.png";
            this.tabPageLogin.Location = new System.Drawing.Point(4, 31);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogin.Size = new System.Drawing.Size(886, 498);
            this.tabPageLogin.TabIndex = 1;
            this.tabPageLogin.Text = "Login";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.btolvidarcontra);
            this.materialCard2.Controls.Add(this.materialDivider1);
            this.materialCard2.Controls.Add(this.btregistrar);
            this.materialCard2.Controls.Add(this.btiniciar);
            this.materialCard2.Controls.Add(this.txtcontra);
            this.materialCard2.Controls.Add(this.txtnombre);
            this.materialCard2.Controls.Add(this.lblLoginTitle);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(442, 20);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(430, 464);
            this.materialCard2.TabIndex = 7;
            // 
            // btolvidarcontra
            // 
            this.btolvidarcontra.AutoSize = true;
            this.btolvidarcontra.Depth = 0;
            this.btolvidarcontra.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btolvidarcontra.Location = new System.Drawing.Point(17, 321);
            this.btolvidarcontra.MouseState = MaterialSkin.MouseState.HOVER;
            this.btolvidarcontra.Name = "btolvidarcontra";
            this.btolvidarcontra.Size = new System.Drawing.Size(184, 19);
            this.btolvidarcontra.TabIndex = 10;
            this.btolvidarcontra.Text = "¿Olvidaste tu contraseña?";
            this.btolvidarcontra.Click += new System.EventHandler(this.lnkForgotPassword_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(17, 300);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(396, 10);
            this.materialDivider1.TabIndex = 8;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // btregistrar
            // 
            this.btregistrar.AutoSize = false;
            this.btregistrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btregistrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btregistrar.Depth = 0;
            this.btregistrar.HighEmphasis = true;
            this.btregistrar.Icon = null;
            this.btregistrar.Location = new System.Drawing.Point(253, 240);
            this.btregistrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btregistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btregistrar.Name = "btregistrar";
            this.btregistrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btregistrar.Size = new System.Drawing.Size(159, 28);
            this.btregistrar.TabIndex = 4;
            this.btregistrar.Text = "REGISTRARSE";
            this.btregistrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btregistrar.UseAccentColor = true;
            this.btregistrar.UseVisualStyleBackColor = true;
            this.btregistrar.Click += new System.EventHandler(this.btnRegisterSubmit_Click);
            // 
            // btiniciar
            // 
            this.btiniciar.AutoSize = false;
            this.btiniciar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btiniciar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btiniciar.Depth = 0;
            this.btiniciar.HighEmphasis = true;
            this.btiniciar.Icon = null;
            this.btiniciar.Location = new System.Drawing.Point(17, 240);
            this.btiniciar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btiniciar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btiniciar.Name = "btiniciar";
            this.btiniciar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btiniciar.Size = new System.Drawing.Size(172, 28);
            this.btiniciar.TabIndex = 3;
            this.btiniciar.Text = "INICIAR SESIÓN";
            this.btiniciar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btiniciar.UseAccentColor = true;
            this.btiniciar.UseVisualStyleBackColor = true;
            this.btiniciar.Click += new System.EventHandler(this.btnLoginSubmit_Click);
            // 
            // txtcontra
            // 
            this.txtcontra.AnimateReadOnly = false;
            this.txtcontra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtcontra.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtcontra.Depth = 0;
            this.txtcontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtcontra.HideSelection = true;
            this.txtcontra.Hint = "Contraseña";
            this.txtcontra.LeadingIcon = null;
            this.txtcontra.Location = new System.Drawing.Point(17, 167);
            this.txtcontra.MaxLength = 32767;
            this.txtcontra.MouseState = MaterialSkin.MouseState.OUT;
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.PasswordChar = '●';
            this.txtcontra.PrefixSuffixText = null;
            this.txtcontra.ReadOnly = false;
            this.txtcontra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtcontra.SelectedText = "";
            this.txtcontra.SelectionLength = 0;
            this.txtcontra.SelectionStart = 0;
            this.txtcontra.ShortcutsEnabled = true;
            this.txtcontra.Size = new System.Drawing.Size(396, 48);
            this.txtcontra.TabIndex = 2;
            this.txtcontra.TabStop = false;
            this.txtcontra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcontra.TrailingIcon = null;
            this.txtcontra.UseSystemPasswordChar = true;
            // 
            // txtnombre
            // 
            this.txtnombre.AnimateReadOnly = false;
            this.txtnombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtnombre.Depth = 0;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtnombre.HideSelection = true;
            this.txtnombre.Hint = "Nombre de usuario";
            this.txtnombre.LeadingIcon = null;
            this.txtnombre.Location = new System.Drawing.Point(17, 95);
            this.txtnombre.MaxLength = 32767;
            this.txtnombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.PasswordChar = '\0';
            this.txtnombre.PrefixSuffixText = null;
            this.txtnombre.ReadOnly = false;
            this.txtnombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtnombre.SelectedText = "";
            this.txtnombre.SelectionLength = 0;
            this.txtnombre.SelectionStart = 0;
            this.txtnombre.ShortcutsEnabled = true;
            this.txtnombre.Size = new System.Drawing.Size(396, 48);
            this.txtnombre.TabIndex = 1;
            this.txtnombre.TabStop = false;
            this.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtnombre.TrailingIcon = null;
            this.txtnombre.UseSystemPasswordChar = false;
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Depth = 0;
            this.lblLoginTitle.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblLoginTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.lblLoginTitle.Location = new System.Drawing.Point(17, 14);
            this.lblLoginTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(204, 41);
            this.lblLoginTitle.TabIndex = 7;
            this.lblLoginTitle.Text = "Iniciar Sesión";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.pictureBox1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(20, 20);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(406, 464);
            this.materialCard1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GUI.Properties.Resources.LogoHdAPp_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 436);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.BackColor = System.Drawing.Color.White;
            this.tabPageSettings.ImageKey = "icons8-settings-32.png";
            this.tabPageSettings.Location = new System.Drawing.Point(4, 31);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Size = new System.Drawing.Size(886, 498);
            this.tabPageSettings.TabIndex = 2;
            this.tabPageSettings.Text = "Settings";
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
            // HomeDprb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "HomeDprb";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Heroes del Aprendizaje";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPageLogin.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPageLogin;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPageSettings;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel lblLoginTitle;
        private MaterialSkin.Controls.MaterialTextBox2 txtnombre;
        private MaterialSkin.Controls.MaterialTextBox2 txtcontra;
        private MaterialSkin.Controls.MaterialButton btregistrar;
        private MaterialSkin.Controls.MaterialButton btiniciar;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel btolvidarcontra;
    }
}

