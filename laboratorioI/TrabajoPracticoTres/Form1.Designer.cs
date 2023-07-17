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
            this.btnGenerarCobro = new System.Windows.Forms.Button();
            this.lbVehiculos = new System.Windows.Forms.ListBox();
            this.lPatentes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAñadirVehiculos
            // 
            this.btnAñadirVehiculos.Location = new System.Drawing.Point(22, 38);
            this.btnAñadirVehiculos.Name = "btnAñadirVehiculos";
            this.btnAñadirVehiculos.Size = new System.Drawing.Size(183, 54);
            this.btnAñadirVehiculos.TabIndex = 0;
            this.btnAñadirVehiculos.Text = "Añadir vehiculos";
            this.btnAñadirVehiculos.UseVisualStyleBackColor = true;
            this.btnAñadirVehiculos.Click += new System.EventHandler(this.btnAñadirVehiculo_Click);
            // 
            // btnFinalizarPrograma
            // 
            this.btnFinalizarPrograma.Location = new System.Drawing.Point(22, 183);
            this.btnFinalizarPrograma.Name = "btnFinalizarPrograma";
            this.btnFinalizarPrograma.Size = new System.Drawing.Size(183, 54);
            this.btnFinalizarPrograma.TabIndex = 1;
            this.btnFinalizarPrograma.Text = "Finalizar programa";
            this.btnFinalizarPrograma.UseVisualStyleBackColor = true;
            this.btnFinalizarPrograma.Click += new System.EventHandler(this.btnFinalizarPrograma_Click);
            // 
            // btnGenerarCobro
            // 
            this.btnGenerarCobro.Location = new System.Drawing.Point(22, 109);
            this.btnGenerarCobro.Name = "btnGenerarCobro";
            this.btnGenerarCobro.Size = new System.Drawing.Size(183, 54);
            this.btnGenerarCobro.TabIndex = 2;
            this.btnGenerarCobro.Text = "Generar cobro";
            this.btnGenerarCobro.UseVisualStyleBackColor = true;
            this.btnGenerarCobro.Click += new System.EventHandler(this.btnGenerarCobro_Click);
            // 
            // lbVehiculos
            // 
            this.lbVehiculos.FormattingEnabled = true;
            this.lbVehiculos.Location = new System.Drawing.Point(222, 38);
            this.lbVehiculos.Name = "lbVehiculos";
            this.lbVehiculos.Size = new System.Drawing.Size(109, 199);
            this.lbVehiculos.TabIndex = 3;
            // 
            // lPatentes
            // 
            this.lPatentes.AutoSize = true;
            this.lPatentes.Location = new System.Drawing.Point(219, 22);
            this.lPatentes.Name = "lPatentes";
            this.lPatentes.Size = new System.Drawing.Size(49, 13);
            this.lPatentes.TabIndex = 4;
            this.lPatentes.Text = "Patentes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 260);
            this.Controls.Add(this.lPatentes);
            this.Controls.Add(this.lbVehiculos);
            this.Controls.Add(this.btnGenerarCobro);
            this.Controls.Add(this.btnFinalizarPrograma);
            this.Controls.Add(this.btnAñadirVehiculos);
            this.Name = "Form1";
            this.Text = "Sistema Cobro Transporte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAñadirVehiculos;
        private System.Windows.Forms.Button btnFinalizarPrograma;
        private System.Windows.Forms.Button btnGenerarCobro;
        private System.Windows.Forms.ListBox lbVehiculos;
        private System.Windows.Forms.Label lPatentes;
    }
}

