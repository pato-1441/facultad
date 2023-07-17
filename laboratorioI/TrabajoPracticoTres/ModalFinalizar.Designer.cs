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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbVehiculosMultados
            // 
            this.lbVehiculosMultados.FormattingEnabled = true;
            this.lbVehiculosMultados.Location = new System.Drawing.Point(12, 9);
            this.lbVehiculosMultados.Name = "lbVehiculosMultados";
            this.lbVehiculosMultados.Size = new System.Drawing.Size(283, 212);
            this.lbVehiculosMultados.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(12, 227);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(137, 35);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnConsultar.Location = new System.Drawing.Point(158, 227);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(137, 35);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar datos";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // ModalFinalizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 274);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lbVehiculosMultados);
            this.Name = "ModalFinalizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vehiculos multados";
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ListBox lbVehiculosMultados;
        public System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.Button btnConsultar;
    }
}