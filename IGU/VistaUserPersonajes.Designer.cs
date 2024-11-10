namespace IGU
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tablapuntaje = new System.Windows.Forms.DataGridView();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtrol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btvolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btpersonaje3 = new System.Windows.Forms.Button();
            this.Btpersonaje2 = new System.Windows.Forms.Button();
            this.Btpersonaje1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listperso = new System.Windows.Forms.ListBox();
            this.BtCONFIGURACION = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablapuntaje)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtCONFIGURACION);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tablapuntaje);
            this.panel1.Controls.Add(this.txtnombre);
            this.panel1.Controls.Add(this.txtrol);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Btvolver);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 297);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Puntajes";
            // 
            // tablapuntaje
            // 
            this.tablapuntaje.AllowUserToOrderColumns = true;
            this.tablapuntaje.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablapuntaje.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.tablapuntaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablapuntaje.Location = new System.Drawing.Point(18, 191);
            this.tablapuntaje.Name = "tablapuntaje";
            this.tablapuntaje.Size = new System.Drawing.Size(323, 101);
            this.tablapuntaje.TabIndex = 7;
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(20, 76);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(125, 20);
            this.txtnombre.TabIndex = 6;
            // 
            // txtrol
            // 
            this.txtrol.Enabled = false;
            this.txtrol.Location = new System.Drawing.Point(20, 135);
            this.txtrol.Name = "txtrol";
            this.txtrol.Size = new System.Drawing.Size(125, 20);
            this.txtrol.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre del usuaio";
            // 
            // Btvolver
            // 
            this.Btvolver.Location = new System.Drawing.Point(349, 47);
            this.Btvolver.Name = "Btvolver";
            this.Btvolver.Size = new System.Drawing.Size(81, 25);
            this.Btvolver.TabIndex = 1;
            this.Btvolver.Text = "SALIR";
            this.Btvolver.UseVisualStyleBackColor = true;
            this.Btvolver.Click += new System.EventHandler(this.BtVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informacion del user";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Btpersonaje3);
            this.panel2.Controls.Add(this.Btpersonaje2);
            this.panel2.Controls.Add(this.Btpersonaje1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(454, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 297);
            this.panel2.TabIndex = 1;
            // 
            // Btpersonaje3
            // 
            this.Btpersonaje3.Location = new System.Drawing.Point(10, 194);
            this.Btpersonaje3.Name = "Btpersonaje3";
            this.Btpersonaje3.Size = new System.Drawing.Size(190, 55);
            this.Btpersonaje3.TabIndex = 3;
            this.Btpersonaje3.UseVisualStyleBackColor = true;
            this.Btpersonaje3.Click += new System.EventHandler(this.Btpersonaje3_Click);
            // 
            // Btpersonaje2
            // 
            this.Btpersonaje2.Location = new System.Drawing.Point(10, 118);
            this.Btpersonaje2.Name = "Btpersonaje2";
            this.Btpersonaje2.Size = new System.Drawing.Size(190, 55);
            this.Btpersonaje2.TabIndex = 2;
            this.Btpersonaje2.UseVisualStyleBackColor = true;
            this.Btpersonaje2.Click += new System.EventHandler(this.Btpersonaje2_Click);
            // 
            // Btpersonaje1
            // 
            this.Btpersonaje1.Location = new System.Drawing.Point(10, 42);
            this.Btpersonaje1.Name = "Btpersonaje1";
            this.Btpersonaje1.Size = new System.Drawing.Size(190, 55);
            this.Btpersonaje1.TabIndex = 1;
            this.Btpersonaje1.UseVisualStyleBackColor = true;
            this.Btpersonaje1.Click += new System.EventHandler(this.Btpersonaje1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Personajes";
            // 
            // listperso
            // 
            this.listperso.FormattingEnabled = true;
            this.listperso.Location = new System.Drawing.Point(34, 335);
            this.listperso.Name = "listperso";
            this.listperso.Size = new System.Drawing.Size(299, 108);
            this.listperso.TabIndex = 2;
            // 
            // BtCONFIGURACION
            // 
            this.BtCONFIGURACION.Location = new System.Drawing.Point(313, 13);
            this.BtCONFIGURACION.Name = "BtCONFIGURACION";
            this.BtCONFIGURACION.Size = new System.Drawing.Size(117, 21);
            this.BtCONFIGURACION.TabIndex = 9;
            this.BtCONFIGURACION.Text = "CONFIGURACIÓN";
            this.BtCONFIGURACION.UseVisualStyleBackColor = true;
            this.BtCONFIGURACION.Click += new System.EventHandler(this.BtCONFIGURACION_Click);
            // 
            // VistaUserPersonajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 459);
            this.Controls.Add(this.listperso);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "VistaUserPersonajes";
            this.Text = "VistaUserPersonajes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablapuntaje)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btpersonaje3;
        private System.Windows.Forms.Button Btpersonaje2;
        private System.Windows.Forms.Button Btpersonaje1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btvolver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtrol;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView tablapuntaje;
        private System.Windows.Forms.ListBox listperso;
        private System.Windows.Forms.Button BtCONFIGURACION;
    }
}