namespace IGU
{
    partial class OpcionesPerso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpcionesPerso));
            this.Bthabilidad02 = new System.Windows.Forms.Button();
            this.Bthabilidad01 = new System.Windows.Forms.Button();
            this.Btbasico = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.labelbasico = new System.Windows.Forms.Label();
            this.labelhab1 = new System.Windows.Forms.Label();
            this.labelhab2 = new System.Windows.Forms.Label();
            this.labelcancelar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bthabilidad02
            // 
            resources.ApplyResources(this.Bthabilidad02, "Bthabilidad02");
            this.Bthabilidad02.Name = "Bthabilidad02";
            this.Bthabilidad02.UseVisualStyleBackColor = true;
            this.Bthabilidad02.Click += new System.EventHandler(this.Bthabilidad02_Click);
            // 
            // Bthabilidad01
            // 
            resources.ApplyResources(this.Bthabilidad01, "Bthabilidad01");
            this.Bthabilidad01.Name = "Bthabilidad01";
            this.Bthabilidad01.UseVisualStyleBackColor = true;
            this.Bthabilidad01.Click += new System.EventHandler(this.Bthabilidad01_Click);
            // 
            // Btbasico
            // 
            resources.ApplyResources(this.Btbasico, "Btbasico");
            this.Btbasico.Name = "Btbasico";
            this.Btbasico.UseVisualStyleBackColor = true;
            this.Btbasico.Click += new System.EventHandler(this.Btbasico_Click);
            // 
            // Cancelar
            // 
            resources.ApplyResources(this.Cancelar, "Cancelar");
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelbasico
            // 
            this.labelbasico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.labelbasico, "labelbasico");
            this.labelbasico.Name = "labelbasico";
            // 
            // labelhab1
            // 
            this.labelhab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.labelhab1, "labelhab1");
            this.labelhab1.Name = "labelhab1";
            // 
            // labelhab2
            // 
            this.labelhab2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.labelhab2, "labelhab2");
            this.labelhab2.Name = "labelhab2";
            // 
            // labelcancelar
            // 
            this.labelcancelar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.labelcancelar, "labelcancelar");
            this.labelcancelar.Name = "labelcancelar";
            // 
            // OpcionesPerso
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelcancelar);
            this.Controls.Add(this.labelhab2);
            this.Controls.Add(this.labelhab1);
            this.Controls.Add(this.labelbasico);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Btbasico);
            this.Controls.Add(this.Bthabilidad01);
            this.Controls.Add(this.Bthabilidad02);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OpcionesPerso";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bthabilidad02;
        private System.Windows.Forms.Button Bthabilidad01;
        private System.Windows.Forms.Button Btbasico;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Label labelbasico;
        private System.Windows.Forms.Label labelhab1;
        private System.Windows.Forms.Label labelhab2;
        private System.Windows.Forms.Label labelcancelar;
    }
}