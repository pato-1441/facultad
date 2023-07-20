namespace TrabajoPracticoTresDos
{
    partial class ModalResultados
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
            this.lbResultados = new System.Windows.Forms.ListBox();
            this.lCompetidor = new System.Windows.Forms.Label();
            this.lCompetidorNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbResultados
            // 
            this.lbResultados.FormattingEnabled = true;
            this.lbResultados.Location = new System.Drawing.Point(12, 38);
            this.lbResultados.Name = "lbResultados";
            this.lbResultados.Size = new System.Drawing.Size(350, 251);
            this.lbResultados.TabIndex = 0;
            // 
            // lCompetidor
            // 
            this.lCompetidor.AutoSize = true;
            this.lCompetidor.Location = new System.Drawing.Point(12, 20);
            this.lCompetidor.Name = "lCompetidor";
            this.lCompetidor.Size = new System.Drawing.Size(63, 13);
            this.lCompetidor.TabIndex = 1;
            this.lCompetidor.Text = "Competidor:";
            // 
            // lCompetidorNombre
            // 
            this.lCompetidorNombre.AutoSize = true;
            this.lCompetidorNombre.Location = new System.Drawing.Point(81, 20);
            this.lCompetidorNombre.Name = "lCompetidorNombre";
            this.lCompetidorNombre.Size = new System.Drawing.Size(0, 13);
            this.lCompetidorNombre.TabIndex = 2;
            // 
            // ModalResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 301);
            this.Controls.Add(this.lCompetidorNombre);
            this.Controls.Add(this.lCompetidor);
            this.Controls.Add(this.lbResultados);
            this.Name = "ModalResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Resultados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox lbResultados;
        private System.Windows.Forms.Label lCompetidor;
        public System.Windows.Forms.Label lCompetidorNombre;
    }
}