namespace SistemaDeCalidad
{
    partial class Form1
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
            this.btnEncuestar = new System.Windows.Forms.Button();
            this.btnVerInsatisfechos = new System.Windows.Forms.Button();
            this.lbInsatisfechos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnEncuestar
            // 
            this.btnEncuestar.Location = new System.Drawing.Point(147, 31);
            this.btnEncuestar.Name = "btnEncuestar";
            this.btnEncuestar.Size = new System.Drawing.Size(127, 50);
            this.btnEncuestar.TabIndex = 0;
            this.btnEncuestar.Text = "Encuestar";
            this.btnEncuestar.UseVisualStyleBackColor = true;
            this.btnEncuestar.Click += new System.EventHandler(this.btnEncuestar_Click);
            // 
            // btnVerInsatisfechos
            // 
            this.btnVerInsatisfechos.Location = new System.Drawing.Point(147, 106);
            this.btnVerInsatisfechos.Name = "btnVerInsatisfechos";
            this.btnVerInsatisfechos.Size = new System.Drawing.Size(127, 50);
            this.btnVerInsatisfechos.TabIndex = 1;
            this.btnVerInsatisfechos.Text = "Ver Insatisfechos";
            this.btnVerInsatisfechos.UseVisualStyleBackColor = true;
            this.btnVerInsatisfechos.Click += new System.EventHandler(this.btnVerInsatisfechos_Click);
            // 
            // lbInsatisfechos
            // 
            this.lbInsatisfechos.FormattingEnabled = true;
            this.lbInsatisfechos.Location = new System.Drawing.Point(12, 178);
            this.lbInsatisfechos.Name = "lbInsatisfechos";
            this.lbInsatisfechos.Size = new System.Drawing.Size(407, 43);
            this.lbInsatisfechos.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 238);
            this.Controls.Add(this.lbInsatisfechos);
            this.Controls.Add(this.btnVerInsatisfechos);
            this.Controls.Add(this.btnEncuestar);
            this.Name = "Form1";
            this.Text = "Sistema de Calidad";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEncuestar;
        private System.Windows.Forms.Button btnVerInsatisfechos;
        private System.Windows.Forms.ListBox lbInsatisfechos;
    }
}

