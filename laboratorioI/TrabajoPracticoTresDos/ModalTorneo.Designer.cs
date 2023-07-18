namespace TrabajoPracticoTresDos
{
    partial class ModalTorneo
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
            this.lNombreCompetidor = new System.Windows.Forms.Label();
            this.tbNombreCompetidor = new System.Windows.Forms.TextBox();
            this.lRonda = new System.Windows.Forms.Label();
            this.lPuntaje = new System.Windows.Forms.Label();
            this.nudPuntaje = new System.Windows.Forms.NumericUpDown();
            this.btnRegistrarTiro = new System.Windows.Forms.Button();
            this.lNumeroTiro = new System.Windows.Forms.Label();
            this.gbImagen = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCentro = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuntaje)).BeginInit();
            this.SuspendLayout();
            // 
            // lNombreCompetidor
            // 
            this.lNombreCompetidor.AutoSize = true;
            this.lNombreCompetidor.Location = new System.Drawing.Point(22, 41);
            this.lNombreCompetidor.Name = "lNombreCompetidor";
            this.lNombreCompetidor.Size = new System.Drawing.Size(116, 13);
            this.lNombreCompetidor.TabIndex = 0;
            this.lNombreCompetidor.Text = "Nombre del competidor";
            // 
            // tbNombreCompetidor
            // 
            this.tbNombreCompetidor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbNombreCompetidor.Enabled = false;
            this.tbNombreCompetidor.Location = new System.Drawing.Point(25, 57);
            this.tbNombreCompetidor.Name = "tbNombreCompetidor";
            this.tbNombreCompetidor.ReadOnly = true;
            this.tbNombreCompetidor.Size = new System.Drawing.Size(128, 20);
            this.tbNombreCompetidor.TabIndex = 1;
            // 
            // lRonda
            // 
            this.lRonda.AutoSize = true;
            this.lRonda.Location = new System.Drawing.Point(22, 15);
            this.lRonda.Name = "lRonda";
            this.lRonda.Size = new System.Drawing.Size(54, 13);
            this.lRonda.TabIndex = 2;
            this.lRonda.Text = "Ronda N°";
            // 
            // lPuntaje
            // 
            this.lPuntaje.AutoSize = true;
            this.lPuntaje.Location = new System.Drawing.Point(22, 85);
            this.lPuntaje.Name = "lPuntaje";
            this.lPuntaje.Size = new System.Drawing.Size(43, 13);
            this.lPuntaje.TabIndex = 3;
            this.lPuntaje.Text = "Puntaje";
            // 
            // nudPuntaje
            // 
            this.nudPuntaje.Location = new System.Drawing.Point(25, 101);
            this.nudPuntaje.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPuntaje.Name = "nudPuntaje";
            this.nudPuntaje.Size = new System.Drawing.Size(128, 20);
            this.nudPuntaje.TabIndex = 4;
            // 
            // btnRegistrarTiro
            // 
            this.btnRegistrarTiro.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRegistrarTiro.Location = new System.Drawing.Point(25, 181);
            this.btnRegistrarTiro.Name = "btnRegistrarTiro";
            this.btnRegistrarTiro.Size = new System.Drawing.Size(128, 44);
            this.btnRegistrarTiro.TabIndex = 5;
            this.btnRegistrarTiro.Text = "Registrar tiro";
            this.btnRegistrarTiro.UseVisualStyleBackColor = true;
            // 
            // lNumeroTiro
            // 
            this.lNumeroTiro.AutoSize = true;
            this.lNumeroTiro.Location = new System.Drawing.Point(103, 15);
            this.lNumeroTiro.Name = "lNumeroTiro";
            this.lNumeroTiro.Size = new System.Drawing.Size(40, 13);
            this.lNumeroTiro.TabIndex = 6;
            this.lNumeroTiro.Text = "Tiro N°";
            // 
            // gbImagen
            // 
            this.gbImagen.BackgroundImage = global::TrabajoPracticoTresDos.Properties.Resources.puntajes;
            this.gbImagen.Location = new System.Drawing.Point(170, 12);
            this.gbImagen.Name = "gbImagen";
            this.gbImagen.Size = new System.Drawing.Size(191, 307);
            this.gbImagen.TabIndex = 7;
            this.gbImagen.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Centro";
            // 
            // cbCentro
            // 
            this.cbCentro.AutoSize = true;
            this.cbCentro.Location = new System.Drawing.Point(25, 151);
            this.cbCentro.Name = "cbCentro";
            this.cbCentro.Size = new System.Drawing.Size(35, 17);
            this.cbCentro.TabIndex = 9;
            this.cbCentro.Text = "Si";
            this.cbCentro.UseVisualStyleBackColor = true;
            // 
            // ModalTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 325);
            this.Controls.Add(this.cbCentro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbImagen);
            this.Controls.Add(this.lNumeroTiro);
            this.Controls.Add(this.btnRegistrarTiro);
            this.Controls.Add(this.nudPuntaje);
            this.Controls.Add(this.lPuntaje);
            this.Controls.Add(this.lRonda);
            this.Controls.Add(this.tbNombreCompetidor);
            this.Controls.Add(this.lNombreCompetidor);
            this.Name = "ModalTorneo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Torneo";
            ((System.ComponentModel.ISupportInitialize)(this.nudPuntaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNombreCompetidor;
        public System.Windows.Forms.TextBox tbNombreCompetidor;
        private System.Windows.Forms.Label lPuntaje;
        public System.Windows.Forms.NumericUpDown nudPuntaje;
        private System.Windows.Forms.Button btnRegistrarTiro;
        private System.Windows.Forms.GroupBox gbImagen;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox cbCentro;
        public System.Windows.Forms.Label lRonda;
        public System.Windows.Forms.Label lNumeroTiro;
    }
}