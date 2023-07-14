namespace TrabajoPracticoTres
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
            this.btnAñadirVehiculos = new System.Windows.Forms.Button();
            this.btnFinalizarPrograma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAñadirVehiculos
            // 
            this.btnAñadirVehiculos.Location = new System.Drawing.Point(22, 21);
            this.btnAñadirVehiculos.Name = "btnAñadirVehiculos";
            this.btnAñadirVehiculos.Size = new System.Drawing.Size(183, 43);
            this.btnAñadirVehiculos.TabIndex = 0;
            this.btnAñadirVehiculos.Text = "Añadir vehiculos";
            this.btnAñadirVehiculos.UseVisualStyleBackColor = true;
            this.btnAñadirVehiculos.Click += new System.EventHandler(this.btnAñadirVehiculo_Click);
            // 
            // btnFinalizarPrograma
            // 
            this.btnFinalizarPrograma.Location = new System.Drawing.Point(22, 83);
            this.btnFinalizarPrograma.Name = "btnFinalizarPrograma";
            this.btnFinalizarPrograma.Size = new System.Drawing.Size(183, 43);
            this.btnFinalizarPrograma.TabIndex = 1;
            this.btnFinalizarPrograma.Text = "Finalizar Programa";
            this.btnFinalizarPrograma.UseVisualStyleBackColor = true;
            this.btnFinalizarPrograma.Click += new System.EventHandler(this.btnFinalizarPrograma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 148);
            this.Controls.Add(this.btnFinalizarPrograma);
            this.Controls.Add(this.btnAñadirVehiculos);
            this.Name = "Form1";
            this.Text = "Sistema Cobro Transporte";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAñadirVehiculos;
        private System.Windows.Forms.Button btnFinalizarPrograma;
    }
}

