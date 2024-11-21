namespace GUI
{
    partial class VistaRegistrarPrgRp
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
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpregunta = new MaterialSkin.Controls.MaterialTextBox();
            this.txtrespuesta = new MaterialSkin.Controls.MaterialTextBox();
            this.boxcategoria = new MaterialSkin.Controls.MaterialComboBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.Btregistrar = new MaterialSkin.Controls.MaterialButton();
            this.Btcancelar = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.ReadOnly = false;
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox1.TabIndex = 0;
            this.materialCheckbox1.Text = "2";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(698, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registrar Preguntas y Respuestas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtpregunta
            // 
            this.txtpregunta.AnimateReadOnly = false;
            this.txtpregunta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpregunta.Depth = 0;
            this.txtpregunta.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtpregunta.Hint = "Pregunta";
            this.txtpregunta.LeadingIcon = null;
            this.txtpregunta.Location = new System.Drawing.Point(36, 102);
            this.txtpregunta.MaxLength = 300;
            this.txtpregunta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtpregunta.Multiline = false;
            this.txtpregunta.Name = "txtpregunta";
            this.txtpregunta.Size = new System.Drawing.Size(693, 50);
            this.txtpregunta.TabIndex = 3;
            this.txtpregunta.Text = "";
            this.txtpregunta.TrailingIcon = null;
            // 
            // txtrespuesta
            // 
            this.txtrespuesta.AnimateReadOnly = false;
            this.txtrespuesta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrespuesta.Depth = 0;
            this.txtrespuesta.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtrespuesta.Hint = "Respuesta";
            this.txtrespuesta.LeadingIcon = null;
            this.txtrespuesta.Location = new System.Drawing.Point(36, 172);
            this.txtrespuesta.MaxLength = 200;
            this.txtrespuesta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtrespuesta.Multiline = false;
            this.txtrespuesta.Name = "txtrespuesta";
            this.txtrespuesta.Size = new System.Drawing.Size(693, 50);
            this.txtrespuesta.TabIndex = 3;
            this.txtrespuesta.Text = "";
            this.txtrespuesta.TrailingIcon = null;
            // 
            // boxcategoria
            // 
            this.boxcategoria.AutoResize = false;
            this.boxcategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.boxcategoria.Depth = 0;
            this.boxcategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.boxcategoria.DropDownHeight = 174;
            this.boxcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxcategoria.DropDownWidth = 121;
            this.boxcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.boxcategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.boxcategoria.FormattingEnabled = true;
            this.boxcategoria.IntegralHeight = false;
            this.boxcategoria.ItemHeight = 43;
            this.boxcategoria.Location = new System.Drawing.Point(36, 244);
            this.boxcategoria.MaxDropDownItems = 4;
            this.boxcategoria.MouseState = MaterialSkin.MouseState.OUT;
            this.boxcategoria.Name = "boxcategoria";
            this.boxcategoria.Size = new System.Drawing.Size(196, 49);
            this.boxcategoria.StartIndex = 0;
            this.boxcategoria.TabIndex = 4;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.boxcategoria);
            this.materialCard1.Controls.Add(this.txtrespuesta);
            this.materialCard1.Controls.Add(this.txtpregunta);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(62, 98);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(762, 365);
            this.materialCard1.TabIndex = 5;
            // 
            // Btregistrar
            // 
            this.Btregistrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btregistrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btregistrar.Depth = 0;
            this.Btregistrar.HighEmphasis = true;
            this.Btregistrar.Icon = null;
            this.Btregistrar.Location = new System.Drawing.Point(341, 494);
            this.Btregistrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btregistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btregistrar.Name = "Btregistrar";
            this.Btregistrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Btregistrar.Size = new System.Drawing.Size(99, 36);
            this.Btregistrar.TabIndex = 6;
            this.Btregistrar.Text = "Registrar";
            this.Btregistrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btregistrar.UseAccentColor = false;
            this.Btregistrar.UseVisualStyleBackColor = true;
            this.Btregistrar.Click += new System.EventHandler(this.Btregistrar_Click);
            // 
            // Btcancelar
            // 
            this.Btcancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btcancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btcancelar.Depth = 0;
            this.Btcancelar.HighEmphasis = true;
            this.Btcancelar.Icon = null;
            this.Btcancelar.Location = new System.Drawing.Point(463, 494);
            this.Btcancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btcancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btcancelar.Name = "Btcancelar";
            this.Btcancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Btcancelar.Size = new System.Drawing.Size(96, 36);
            this.Btcancelar.TabIndex = 6;
            this.Btcancelar.Text = "Cancelar";
            this.Btcancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btcancelar.UseAccentColor = false;
            this.Btcancelar.UseVisualStyleBackColor = true;
            this.Btcancelar.Click += new System.EventHandler(this.materialBtnCancelar_Click);
            // 
            // VistaRegistrarPrgRp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.Btcancelar);
            this.Controls.Add(this.Btregistrar);
            this.Controls.Add(this.materialCard1);
            this.Name = "VistaRegistrarPrgRp";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Preguntas y Respuestas";
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox txtpregunta;
        private MaterialSkin.Controls.MaterialTextBox txtrespuesta;
        private MaterialSkin.Controls.MaterialComboBox boxcategoria;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton Btregistrar;
        private MaterialSkin.Controls.MaterialButton Btcancelar;
    }
}