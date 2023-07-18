namespace TrabajoPracticoTresDos
{
    partial class ModalCargarCompetidor
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
            this.lNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lEdad = new System.Windows.Forms.Label();
            this.tbClub = new System.Windows.Forms.TextBox();
            this.lClub = new System.Windows.Forms.Label();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.btnCargarCompetidor = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(12, 20);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(44, 13);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(12, 36);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(173, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // lEdad
            // 
            this.lEdad.AutoSize = true;
            this.lEdad.Location = new System.Drawing.Point(12, 68);
            this.lEdad.Name = "lEdad";
            this.lEdad.Size = new System.Drawing.Size(32, 13);
            this.lEdad.TabIndex = 2;
            this.lEdad.Text = "Edad";
            // 
            // tbClub
            // 
            this.tbClub.Location = new System.Drawing.Point(12, 132);
            this.tbClub.Name = "tbClub";
            this.tbClub.Size = new System.Drawing.Size(173, 20);
            this.tbClub.TabIndex = 6;
            // 
            // lClub
            // 
            this.lClub.AutoSize = true;
            this.lClub.Location = new System.Drawing.Point(12, 116);
            this.lClub.Name = "lClub";
            this.lClub.Size = new System.Drawing.Size(28, 13);
            this.lClub.TabIndex = 4;
            this.lClub.Text = "Club";
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(12, 84);
            this.nudEdad.Maximum = new decimal(new int[] {
            130,
            0,
            0,
            0});
            this.nudEdad.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(173, 20);
            this.nudEdad.TabIndex = 5;
            this.nudEdad.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // btnCargarCompetidor
            // 
            this.btnCargarCompetidor.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCargarCompetidor.Location = new System.Drawing.Point(97, 167);
            this.btnCargarCompetidor.Name = "btnCargarCompetidor";
            this.btnCargarCompetidor.Size = new System.Drawing.Size(88, 39);
            this.btnCargarCompetidor.TabIndex = 7;
            this.btnCargarCompetidor.Text = "Cargar";
            this.btnCargarCompetidor.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(12, 167);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 39);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // ModalCargarCompetidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 218);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCargarCompetidor);
            this.Controls.Add(this.nudEdad);
            this.Controls.Add(this.tbClub);
            this.Controls.Add(this.lClub);
            this.Controls.Add(this.lEdad);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lNombre);
            this.Name = "ModalCargarCompetidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cargar competidor";
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNombre;
        public System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lEdad;
        public System.Windows.Forms.TextBox tbClub;
        private System.Windows.Forms.Label lClub;
        public System.Windows.Forms.Button btnCargarCompetidor;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.NumericUpDown nudEdad;
    }
}