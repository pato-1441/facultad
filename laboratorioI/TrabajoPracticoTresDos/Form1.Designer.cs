namespace TrabajoPracticoTresDos
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
            this.btnCargarCompetidor = new System.Windows.Forms.Button();
            this.lbCompetidores = new System.Windows.Forms.ListBox();
            this.btnComenzarTorneo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCargarCompetidor
            // 
            this.btnCargarCompetidor.Location = new System.Drawing.Point(12, 12);
            this.btnCargarCompetidor.Name = "btnCargarCompetidor";
            this.btnCargarCompetidor.Size = new System.Drawing.Size(114, 49);
            this.btnCargarCompetidor.TabIndex = 0;
            this.btnCargarCompetidor.Text = "Cargar competidor";
            this.btnCargarCompetidor.UseVisualStyleBackColor = true;
            this.btnCargarCompetidor.Click += new System.EventHandler(this.btnCargarCompetidor_Click);
            // 
            // lbCompetidores
            // 
            this.lbCompetidores.FormattingEnabled = true;
            this.lbCompetidores.Location = new System.Drawing.Point(132, 12);
            this.lbCompetidores.Name = "lbCompetidores";
            this.lbCompetidores.Size = new System.Drawing.Size(149, 212);
            this.lbCompetidores.TabIndex = 1;
            // 
            // btnComenzarTorneo
            // 
            this.btnComenzarTorneo.Location = new System.Drawing.Point(12, 67);
            this.btnComenzarTorneo.Name = "btnComenzarTorneo";
            this.btnComenzarTorneo.Size = new System.Drawing.Size(114, 49);
            this.btnComenzarTorneo.TabIndex = 2;
            this.btnComenzarTorneo.Text = "Comenzar torneo";
            this.btnComenzarTorneo.UseVisualStyleBackColor = true;
            this.btnComenzarTorneo.Click += new System.EventHandler(this.btnComenzarTorneo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 239);
            this.Controls.Add(this.btnComenzarTorneo);
            this.Controls.Add(this.lbCompetidores);
            this.Controls.Add(this.btnCargarCompetidor);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Torneo tiro con arco";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarCompetidor;
        public System.Windows.Forms.ListBox lbCompetidores;
        private System.Windows.Forms.Button btnComenzarTorneo;
    }
}

