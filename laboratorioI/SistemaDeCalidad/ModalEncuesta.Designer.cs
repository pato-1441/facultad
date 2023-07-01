namespace SistemaDeCalidad
{
    partial class ModalEncuesta
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
            this.rbExcelente = new System.Windows.Forms.RadioButton();
            this.rbBueno = new System.Windows.Forms.RadioButton();
            this.rbRegular = new System.Windows.Forms.RadioButton();
            this.rbMalo = new System.Windows.Forms.RadioButton();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbExcelente
            // 
            this.rbExcelente.AutoSize = true;
            this.rbExcelente.Location = new System.Drawing.Point(41, 25);
            this.rbExcelente.Name = "rbExcelente";
            this.rbExcelente.Size = new System.Drawing.Size(72, 17);
            this.rbExcelente.TabIndex = 0;
            this.rbExcelente.TabStop = true;
            this.rbExcelente.Text = "Excelente";
            this.rbExcelente.UseVisualStyleBackColor = true;
            // 
            // rbBueno
            // 
            this.rbBueno.AutoSize = true;
            this.rbBueno.Location = new System.Drawing.Point(41, 48);
            this.rbBueno.Name = "rbBueno";
            this.rbBueno.Size = new System.Drawing.Size(56, 17);
            this.rbBueno.TabIndex = 1;
            this.rbBueno.TabStop = true;
            this.rbBueno.Text = "Bueno";
            this.rbBueno.UseVisualStyleBackColor = true;
            // 
            // rbRegular
            // 
            this.rbRegular.AutoSize = true;
            this.rbRegular.Location = new System.Drawing.Point(41, 71);
            this.rbRegular.Name = "rbRegular";
            this.rbRegular.Size = new System.Drawing.Size(62, 17);
            this.rbRegular.TabIndex = 2;
            this.rbRegular.TabStop = true;
            this.rbRegular.Text = "Regular";
            this.rbRegular.UseVisualStyleBackColor = true;
            // 
            // rbMalo
            // 
            this.rbMalo.AutoSize = true;
            this.rbMalo.Location = new System.Drawing.Point(41, 94);
            this.rbMalo.Name = "rbMalo";
            this.rbMalo.Size = new System.Drawing.Size(113, 17);
            this.rbMalo.TabIndex = 3;
            this.rbMalo.TabStop = true;
            this.rbMalo.Text = "Malo (insatisfecho)";
            this.rbMalo.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(71, 134);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(104, 38);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(192, 134);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 38);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(189, 25);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(32, 13);
            this.lEmail.TabIndex = 6;
            this.lEmail.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(192, 42);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(104, 20);
            this.tbEmail.TabIndex = 7;
            this.tbEmail.Text = "ejemplo@mail.com";
            // 
            // ModalEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 203);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.rbMalo);
            this.Controls.Add(this.rbRegular);
            this.Controls.Add(this.rbBueno);
            this.Controls.Add(this.rbExcelente);
            this.Name = "ModalEncuesta";
            this.Text = "N° Encuesta:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RadioButton rbExcelente;
        public System.Windows.Forms.RadioButton rbBueno;
        public System.Windows.Forms.RadioButton rbRegular;
        public System.Windows.Forms.RadioButton rbMalo;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lEmail;
        public System.Windows.Forms.TextBox tbEmail;
    }
}