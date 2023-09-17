namespace WindowsFormsApp1
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.labCadenaUno = new System.Windows.Forms.Label();
            this.labCadenaDos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(168, 32);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(105, 50);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // labCadenaUno
            // 
            this.labCadenaUno.AutoSize = true;
            this.labCadenaUno.Location = new System.Drawing.Point(165, 145);
            this.labCadenaUno.Name = "labCadenaUno";
            this.labCadenaUno.Size = new System.Drawing.Size(35, 13);
            this.labCadenaUno.TabIndex = 1;
            this.labCadenaUno.Text = "label1";
            // 
            // labCadenaDos
            // 
            this.labCadenaDos.AutoSize = true;
            this.labCadenaDos.Location = new System.Drawing.Point(165, 201);
            this.labCadenaDos.Name = "labCadenaDos";
            this.labCadenaDos.Size = new System.Drawing.Size(35, 13);
            this.labCadenaDos.TabIndex = 2;
            this.labCadenaDos.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 294);
            this.Controls.Add(this.labCadenaDos);
            this.Controls.Add(this.labCadenaUno);
            this.Controls.Add(this.btnMostrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label labCadenaUno;
        private System.Windows.Forms.Label labCadenaDos;
    }
}

