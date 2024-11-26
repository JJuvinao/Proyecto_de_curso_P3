namespace GUI
{
    partial class VistaEliminarUsuarios
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
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.txtnombre = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtrol = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnEliminarUser = new MaterialSkin.Controls.MaterialButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.txtcontra = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtcontra);
            this.materialCard1.Controls.Add(this.lblTitle);
            this.materialCard1.Controls.Add(this.materialDivider1);
            this.materialCard1.Controls.Add(this.txtnombre);
            this.materialCard1.Controls.Add(this.txtrol);
            this.materialCard1.Controls.Add(this.btnEliminarUser);
            this.materialCard1.Controls.Add(this.btnCancel);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(20, 80);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(460, 387);
            this.materialCard1.TabIndex = 0;
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
            this.lblTitle.Size = new System.Drawing.Size(188, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Eliminar Usuarios";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(16, 84);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(426, 1);
            this.materialDivider1.TabIndex = 4;
            // 
            // txtnombre
            // 
            this.txtnombre.AnimateReadOnly = false;
            this.txtnombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtnombre.Depth = 0;
            this.txtnombre.Enabled = false;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtnombre.HideSelection = true;
            this.txtnombre.Hint = "Name";
            this.txtnombre.LeadingIcon = null;
            this.txtnombre.Location = new System.Drawing.Point(16, 106);
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
            this.txtnombre.Size = new System.Drawing.Size(426, 48);
            this.txtnombre.TabIndex = 6;
            this.txtnombre.TabStop = false;
            this.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtnombre.TrailingIcon = null;
            this.txtnombre.UseSystemPasswordChar = false;
            // 
            // txtrol
            // 
            this.txtrol.AnimateReadOnly = false;
            this.txtrol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtrol.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtrol.Depth = 0;
            this.txtrol.Enabled = false;
            this.txtrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtrol.HideSelection = true;
            this.txtrol.Hint = "Rol";
            this.txtrol.LeadingIcon = null;
            this.txtrol.Location = new System.Drawing.Point(16, 160);
            this.txtrol.MaxLength = 32767;
            this.txtrol.MouseState = MaterialSkin.MouseState.OUT;
            this.txtrol.Name = "txtrol";
            this.txtrol.PasswordChar = '\0';
            this.txtrol.PrefixSuffixText = null;
            this.txtrol.ReadOnly = false;
            this.txtrol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtrol.SelectedText = "";
            this.txtrol.SelectionLength = 0;
            this.txtrol.SelectionStart = 0;
            this.txtrol.ShortcutsEnabled = true;
            this.txtrol.Size = new System.Drawing.Size(426, 48);
            this.txtrol.TabIndex = 6;
            this.txtrol.TabStop = false;
            this.txtrol.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtrol.TrailingIcon = null;
            this.txtrol.UseSystemPasswordChar = false;
            // 
            // btnEliminarUser
            // 
            this.btnEliminarUser.AutoSize = false;
            this.btnEliminarUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarUser.Depth = 0;
            this.btnEliminarUser.Enabled = false;
            this.btnEliminarUser.HighEmphasis = true;
            this.btnEliminarUser.Icon = null;
            this.btnEliminarUser.Location = new System.Drawing.Point(16, 286);
            this.btnEliminarUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarUser.Name = "btnEliminarUser";
            this.btnEliminarUser.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarUser.Size = new System.Drawing.Size(426, 36);
            this.btnEliminarUser.TabIndex = 8;
            this.btnEliminarUser.Text = "ELIMINAR USUARIO";
            this.btnEliminarUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarUser.UseAccentColor = true;
            this.btnEliminarUser.UseVisualStyleBackColor = true;
            this.btnEliminarUser.Click += new System.EventHandler(this.btnEliminarUser_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = false;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(16, 334);
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
            // txtcontra
            // 
            this.txtcontra.AnimateReadOnly = false;
            this.txtcontra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtcontra.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtcontra.Depth = 0;
            this.txtcontra.Enabled = false;
            this.txtcontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtcontra.HideSelection = true;
            this.txtcontra.Hint = "CONTRASEÑA";
            this.txtcontra.LeadingIcon = null;
            this.txtcontra.Location = new System.Drawing.Point(16, 214);
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
            this.txtcontra.Size = new System.Drawing.Size(426, 48);
            this.txtcontra.TabIndex = 11;
            this.txtcontra.TabStop = false;
            this.txtcontra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcontra.TrailingIcon = null;
            this.txtcontra.UseSystemPasswordChar = true;
            // 
            // VistaEliminarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 480);
            this.Controls.Add(this.materialCard1);
            this.Name = "VistaEliminarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Usuario";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialTextBox2 txtnombre;
        private MaterialSkin.Controls.MaterialTextBox2 txtrol;
        private MaterialSkin.Controls.MaterialButton btnEliminarUser;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialTextBox2 txtcontra;
    }
}

