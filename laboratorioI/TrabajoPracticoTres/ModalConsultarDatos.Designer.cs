namespace TrabajoPracticoTres
{
    partial class ModalConsultarDatos
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
            this.lFechaRegistro = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lTipoVehiculo = new System.Windows.Forms.Label();
            this.lCostoAbonado = new System.Windows.Forms.Label();
            this.tbFechaRegistro = new System.Windows.Forms.TextBox();
            this.tbTipoVehiculo = new System.Windows.Forms.TextBox();
            this.tbCostoAbonado = new System.Windows.Forms.TextBox();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lFechaRegistro
            // 
            this.lFechaRegistro.AutoSize = true;
            this.lFechaRegistro.Location = new System.Drawing.Point(17, 29);
            this.lFechaRegistro.Name = "lFechaRegistro";
            this.lFechaRegistro.Size = new System.Drawing.Size(89, 13);
            this.lFechaRegistro.TabIndex = 0;
            this.lFechaRegistro.Text = "Fecha de registro";
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.tbCostoAbonado);
            this.gbDatos.Controls.Add(this.tbTipoVehiculo);
            this.gbDatos.Controls.Add(this.tbFechaRegistro);
            this.gbDatos.Controls.Add(this.lCostoAbonado);
            this.gbDatos.Controls.Add(this.lTipoVehiculo);
            this.gbDatos.Controls.Add(this.lFechaRegistro);
            this.gbDatos.Location = new System.Drawing.Point(12, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(203, 168);
            this.gbDatos.TabIndex = 6;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos vehiculo";
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(12, 186);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(203, 40);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // lTipoVehiculo
            // 
            this.lTipoVehiculo.AutoSize = true;
            this.lTipoVehiculo.Location = new System.Drawing.Point(17, 74);
            this.lTipoVehiculo.Name = "lTipoVehiculo";
            this.lTipoVehiculo.Size = new System.Drawing.Size(86, 13);
            this.lTipoVehiculo.TabIndex = 6;
            this.lTipoVehiculo.Text = "Tipo de vehiculo";
            // 
            // lCostoAbonado
            // 
            this.lCostoAbonado.AutoSize = true;
            this.lCostoAbonado.Location = new System.Drawing.Point(17, 118);
            this.lCostoAbonado.Name = "lCostoAbonado";
            this.lCostoAbonado.Size = new System.Drawing.Size(79, 13);
            this.lCostoAbonado.TabIndex = 8;
            this.lCostoAbonado.Text = "Costo abonado";
            // 
            // tbFechaRegistro
            // 
            this.tbFechaRegistro.BackColor = System.Drawing.SystemColors.Window;
            this.tbFechaRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFechaRegistro.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbFechaRegistro.Enabled = false;
            this.tbFechaRegistro.Location = new System.Drawing.Point(20, 45);
            this.tbFechaRegistro.Name = "tbFechaRegistro";
            this.tbFechaRegistro.ReadOnly = true;
            this.tbFechaRegistro.Size = new System.Drawing.Size(100, 20);
            this.tbFechaRegistro.TabIndex = 9;
            // 
            // tbTipoVehiculo
            // 
            this.tbTipoVehiculo.BackColor = System.Drawing.SystemColors.Window;
            this.tbTipoVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTipoVehiculo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbTipoVehiculo.Enabled = false;
            this.tbTipoVehiculo.Location = new System.Drawing.Point(20, 90);
            this.tbTipoVehiculo.Name = "tbTipoVehiculo";
            this.tbTipoVehiculo.ReadOnly = true;
            this.tbTipoVehiculo.Size = new System.Drawing.Size(100, 20);
            this.tbTipoVehiculo.TabIndex = 10;
            // 
            // tbCostoAbonado
            // 
            this.tbCostoAbonado.BackColor = System.Drawing.SystemColors.Window;
            this.tbCostoAbonado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCostoAbonado.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCostoAbonado.Enabled = false;
            this.tbCostoAbonado.Location = new System.Drawing.Point(20, 134);
            this.tbCostoAbonado.Name = "tbCostoAbonado";
            this.tbCostoAbonado.ReadOnly = true;
            this.tbCostoAbonado.Size = new System.Drawing.Size(100, 20);
            this.tbCostoAbonado.TabIndex = 11;
            // 
            // ModalConsultarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 239);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbDatos);
            this.Name = "ModalConsultarDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Datos vehiculo";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lFechaRegistro;
        private System.Windows.Forms.GroupBox gbDatos;
        public System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lCostoAbonado;
        private System.Windows.Forms.Label lTipoVehiculo;
        public System.Windows.Forms.TextBox tbCostoAbonado;
        public System.Windows.Forms.TextBox tbTipoVehiculo;
        public System.Windows.Forms.TextBox tbFechaRegistro;
    }
}