namespace IGU
{
    partial class VistaUser
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
            this.BtVolver = new System.Windows.Forms.Button();
            this.Btver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txtnom = new System.Windows.Forms.TextBox();
            this.Txtcontra = new System.Windows.Forms.TextBox();
            this.Boxrol = new System.Windows.Forms.ComboBox();
            this.Btsave = new System.Windows.Forms.Button();
            this.Btupdate = new System.Windows.Forms.Button();
            this.Tablauser = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Tablauser)).BeginInit();
            this.SuspendLayout();
            // 
            // BtVolver
            // 
            this.BtVolver.Location = new System.Drawing.Point(319, 202);
            this.BtVolver.Name = "BtVolver";
            this.BtVolver.Size = new System.Drawing.Size(117, 40);
            this.BtVolver.TabIndex = 1;
            this.BtVolver.Text = "Volver";
            this.BtVolver.UseVisualStyleBackColor = true;
            this.BtVolver.Click += new System.EventHandler(this.BtVolver_Click);
            // 
            // Btver
            // 
            this.Btver.Location = new System.Drawing.Point(468, 202);
            this.Btver.Name = "Btver";
            this.Btver.Size = new System.Drawing.Size(112, 40);
            this.Btver.TabIndex = 3;
            this.Btver.Text = "Ver user";
            this.Btver.UseVisualStyleBackColor = true;
            this.Btver.Click += new System.EventHandler(this.Btver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Rol";
            // 
            // Txtnom
            // 
            this.Txtnom.Location = new System.Drawing.Point(12, 32);
            this.Txtnom.Name = "Txtnom";
            this.Txtnom.Size = new System.Drawing.Size(136, 20);
            this.Txtnom.TabIndex = 10;
            // 
            // Txtcontra
            // 
            this.Txtcontra.Location = new System.Drawing.Point(12, 84);
            this.Txtcontra.Name = "Txtcontra";
            this.Txtcontra.Size = new System.Drawing.Size(137, 20);
            this.Txtcontra.TabIndex = 11;
            // 
            // Boxrol
            // 
            this.Boxrol.FormattingEnabled = true;
            this.Boxrol.Items.AddRange(new object[] {
            "Profesor",
            "Estudiante"});
            this.Boxrol.Location = new System.Drawing.Point(11, 138);
            this.Boxrol.Name = "Boxrol";
            this.Boxrol.Size = new System.Drawing.Size(137, 21);
            this.Boxrol.TabIndex = 12;
            // 
            // Btsave
            // 
            this.Btsave.Location = new System.Drawing.Point(15, 202);
            this.Btsave.Name = "Btsave";
            this.Btsave.Size = new System.Drawing.Size(133, 40);
            this.Btsave.TabIndex = 16;
            this.Btsave.Text = "Registrar";
            this.Btsave.UseVisualStyleBackColor = true;
            this.Btsave.Click += new System.EventHandler(this.Btsave_Click);
            // 
            // Btupdate
            // 
            this.Btupdate.Location = new System.Drawing.Point(174, 202);
            this.Btupdate.Name = "Btupdate";
            this.Btupdate.Size = new System.Drawing.Size(127, 40);
            this.Btupdate.TabIndex = 17;
            this.Btupdate.Text = "Actualizar";
            this.Btupdate.UseVisualStyleBackColor = true;
            this.Btupdate.Click += new System.EventHandler(this.Btupdate_Click);
            // 
            // Tablauser
            // 
            this.Tablauser.AllowUserToAddRows = false;
            this.Tablauser.AllowUserToDeleteRows = false;
            this.Tablauser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tablauser.Location = new System.Drawing.Point(173, 26);
            this.Tablauser.Name = "Tablauser";
            this.Tablauser.ReadOnly = true;
            this.Tablauser.Size = new System.Drawing.Size(407, 161);
            this.Tablauser.TabIndex = 18;
            // 
            // VistaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 249);
            this.Controls.Add(this.Tablauser);
            this.Controls.Add(this.Btupdate);
            this.Controls.Add(this.Btsave);
            this.Controls.Add(this.Boxrol);
            this.Controls.Add(this.Txtcontra);
            this.Controls.Add(this.Txtnom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btver);
            this.Controls.Add(this.BtVolver);
            this.Name = "VistaUser";
            this.Text = "VistaUser";
            ((System.ComponentModel.ISupportInitialize)(this.Tablauser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtVolver;
        private System.Windows.Forms.Button Btver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txtnom;
        private System.Windows.Forms.TextBox Txtcontra;
        private System.Windows.Forms.ComboBox Boxrol;
        private System.Windows.Forms.Button Btsave;
        private System.Windows.Forms.Button Btupdate;
        private System.Windows.Forms.DataGridView Tablauser;
    }
}