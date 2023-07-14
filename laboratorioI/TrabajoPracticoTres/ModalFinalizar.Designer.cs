namespace TrabajoPracticoTres
{
    partial class ModalFinalizar
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
            this.lbVehiculosMultados = new System.Windows.Forms.ListBox();
            this.btnConsultarDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbVehiculosMultados
            // 
            this.lbVehiculosMultados.FormattingEnabled = true;
            this.lbVehiculosMultados.Location = new System.Drawing.Point(12, 9);
            this.lbVehiculosMultados.Name = "lbVehiculosMultados";
            this.lbVehiculosMultados.Size = new System.Drawing.Size(143, 303);
            this.lbVehiculosMultados.TabIndex = 0;
            // 
            // btnConsultarDatos
            // 
            this.btnConsultarDatos.Location = new System.Drawing.Point(161, 9);
            this.btnConsultarDatos.Name = "btnConsultarDatos";
            this.btnConsultarDatos.Size = new System.Drawing.Size(138, 43);
            this.btnConsultarDatos.TabIndex = 1;
            this.btnConsultarDatos.Text = "Consultar Datos";
            this.btnConsultarDatos.UseVisualStyleBackColor = true;
            // 
            // ModalFinalizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 324);
            this.Controls.Add(this.btnConsultarDatos);
            this.Controls.Add(this.lbVehiculosMultados);
            this.Name = "ModalFinalizar";
            this.Text = "Vehiculos multados";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConsultarDatos;
        public System.Windows.Forms.ListBox lbVehiculosMultados;
    }
}