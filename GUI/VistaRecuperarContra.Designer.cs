namespace GUI
{
    partial class VistaRecuperarContra
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

        private void InitializeComponent()
        {
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblInstructions = new MaterialSkin.Controls.MaterialLabel();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.txtnomuser = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.txtnuevacontra = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtconfircontra = new MaterialSkin.Controls.MaterialTextBox2();
            this.BtcambiarContra = new MaterialSkin.Controls.MaterialButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.Btbuscar = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.Btbuscar);
            this.materialCard1.Controls.Add(this.lblInstructions);
            this.materialCard1.Controls.Add(this.lblTitle);
            this.materialCard1.Controls.Add(this.txtnomuser);
            this.materialCard1.Controls.Add(this.materialDivider1);
            this.materialCard1.Controls.Add(this.txtnuevacontra);
            this.materialCard1.Controls.Add(this.txtconfircontra);
            this.materialCard1.Controls.Add(this.BtcambiarContra);
            this.materialCard1.Controls.Add(this.btnCancel);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(20, 80);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(460, 500);
            this.materialCard1.TabIndex = 0;
            this.materialCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard1_Paint);
            // 
            // lblInstructions
            // 
            this.lblInstructions.Depth = 0;
            this.lblInstructions.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblInstructions.Location = new System.Drawing.Point(17, 53);
            this.lblInstructions.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(426, 40);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.Text = "Ingresa tu username para recuperar tu contraseña";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblTitle.Location = new System.Drawing.Point(17, 14);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(310, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Recuperación de Contraseña";
            // 
            // txtnomuser
            // 
            this.txtnomuser.AnimateReadOnly = false;
            this.txtnomuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtnomuser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtnomuser.Depth = 0;
            this.txtnomuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtnomuser.HelperText = "Ingresa el user asociado a tu cuenta";
            this.txtnomuser.HideSelection = true;
            this.txtnomuser.Hint = "Username";
            this.txtnomuser.LeadingIcon = null;
            this.txtnomuser.Location = new System.Drawing.Point(17, 96);
            this.txtnomuser.MaxLength = 32767;
            this.txtnomuser.MouseState = MaterialSkin.MouseState.OUT;
            this.txtnomuser.Name = "txtnomuser";
            this.txtnomuser.PasswordChar = '\0';
            this.txtnomuser.PrefixSuffixText = null;
            this.txtnomuser.ReadOnly = false;
            this.txtnomuser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtnomuser.SelectedText = "";
            this.txtnomuser.SelectionLength = 0;
            this.txtnomuser.SelectionStart = 0;
            this.txtnomuser.ShortcutsEnabled = true;
            this.txtnomuser.Size = new System.Drawing.Size(426, 48);
            this.txtnomuser.TabIndex = 2;
            this.txtnomuser.TabStop = false;
            this.txtnomuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtnomuser.TrailingIcon = null;
            this.txtnomuser.UseSystemPasswordChar = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(17, 199);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(426, 1);
            this.materialDivider1.TabIndex = 4;
            // 
            // txtnuevacontra
            // 
            this.txtnuevacontra.AnimateReadOnly = false;
            this.txtnuevacontra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtnuevacontra.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtnuevacontra.Depth = 0;
            this.txtnuevacontra.Enabled = false;
            this.txtnuevacontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtnuevacontra.HideSelection = true;
            this.txtnuevacontra.Hint = "Nueva contraseña";
            this.txtnuevacontra.LeadingIcon = null;
            this.txtnuevacontra.Location = new System.Drawing.Point(17, 242);
            this.txtnuevacontra.MaxLength = 32767;
            this.txtnuevacontra.MouseState = MaterialSkin.MouseState.OUT;
            this.txtnuevacontra.Name = "txtnuevacontra";
            this.txtnuevacontra.PasswordChar = '●';
            this.txtnuevacontra.PrefixSuffixText = null;
            this.txtnuevacontra.ReadOnly = false;
            this.txtnuevacontra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtnuevacontra.SelectedText = "";
            this.txtnuevacontra.SelectionLength = 0;
            this.txtnuevacontra.SelectionStart = 0;
            this.txtnuevacontra.ShortcutsEnabled = true;
            this.txtnuevacontra.Size = new System.Drawing.Size(426, 48);
            this.txtnuevacontra.TabIndex = 6;
            this.txtnuevacontra.TabStop = false;
            this.txtnuevacontra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtnuevacontra.TrailingIcon = null;
            this.txtnuevacontra.UseSystemPasswordChar = true;
            // 
            // txtconfircontra
            // 
            this.txtconfircontra.AnimateReadOnly = false;
            this.txtconfircontra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtconfircontra.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtconfircontra.Depth = 0;
            this.txtconfircontra.Enabled = false;
            this.txtconfircontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtconfircontra.HideSelection = true;
            this.txtconfircontra.Hint = "Confirmar contraseña";
            this.txtconfircontra.LeadingIcon = null;
            this.txtconfircontra.Location = new System.Drawing.Point(17, 302);
            this.txtconfircontra.MaxLength = 32767;
            this.txtconfircontra.MouseState = MaterialSkin.MouseState.OUT;
            this.txtconfircontra.Name = "txtconfircontra";
            this.txtconfircontra.PasswordChar = '●';
            this.txtconfircontra.PrefixSuffixText = null;
            this.txtconfircontra.ReadOnly = false;
            this.txtconfircontra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtconfircontra.SelectedText = "";
            this.txtconfircontra.SelectionLength = 0;
            this.txtconfircontra.SelectionStart = 0;
            this.txtconfircontra.ShortcutsEnabled = true;
            this.txtconfircontra.Size = new System.Drawing.Size(426, 48);
            this.txtconfircontra.TabIndex = 7;
            this.txtconfircontra.TabStop = false;
            this.txtconfircontra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtconfircontra.TrailingIcon = null;
            this.txtconfircontra.UseSystemPasswordChar = true;
            // 
            // BtcambiarContra
            // 
            this.BtcambiarContra.AutoSize = false;
            this.BtcambiarContra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtcambiarContra.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtcambiarContra.Depth = 0;
            this.BtcambiarContra.Enabled = false;
            this.BtcambiarContra.HighEmphasis = true;
            this.BtcambiarContra.Icon = null;
            this.BtcambiarContra.Location = new System.Drawing.Point(17, 401);
            this.BtcambiarContra.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtcambiarContra.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtcambiarContra.Name = "BtcambiarContra";
            this.BtcambiarContra.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtcambiarContra.Size = new System.Drawing.Size(426, 36);
            this.BtcambiarContra.TabIndex = 8;
            this.BtcambiarContra.Text = "CAMBIAR CONTRASEÑA";
            this.BtcambiarContra.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtcambiarContra.UseAccentColor = true;
            this.BtcambiarContra.UseVisualStyleBackColor = true;
            this.BtcambiarContra.Click += new System.EventHandler(this.BtcambiarContra_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = false;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(17, 449);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(426, 36);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnCancel.UseAccentColor = true;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Btbuscar
            // 
            this.Btbuscar.AutoSize = false;
            this.Btbuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btbuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btbuscar.Depth = 0;
            this.Btbuscar.HighEmphasis = true;
            this.Btbuscar.Icon = null;
            this.Btbuscar.Location = new System.Drawing.Point(17, 154);
            this.Btbuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btbuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btbuscar.Name = "Btbuscar";
            this.Btbuscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Btbuscar.Size = new System.Drawing.Size(426, 36);
            this.Btbuscar.TabIndex = 11;
            this.Btbuscar.Text = "BUSCAR USUARIO";
            this.Btbuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btbuscar.UseAccentColor = true;
            this.Btbuscar.UseVisualStyleBackColor = true;
            this.Btbuscar.Click += new System.EventHandler(this.Btbuscar_Click);
            // 
            // VistaRecuperarContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.materialCard1);
            this.Name = "VistaRecuperarContra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar Contraseña";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialTextBox2 txtnuevacontra;
        private MaterialSkin.Controls.MaterialTextBox2 txtconfircontra;
        private MaterialSkin.Controls.MaterialButton BtcambiarContra;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialLabel lblInstructions;
        private MaterialSkin.Controls.MaterialTextBox2 txtnomuser;
        private MaterialSkin.Controls.MaterialButton Btbuscar;
    }
}

