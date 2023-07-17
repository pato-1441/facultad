namespace TrabajoPracticoTres
{
    partial class ModalAñadirVehiculo
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
            this.gbDatosVehiculo = new System.Windows.Forms.GroupBox();
            this.tbCapacidadVehiculo = new System.Windows.Forms.TextBox();
            this.lCapacidadVehiculo = new System.Windows.Forms.Label();
            this.rbCamion = new System.Windows.Forms.RadioButton();
            this.rbFurgon = new System.Windows.Forms.RadioButton();
            this.lTipo = new System.Windows.Forms.Label();
            this.tbPatente = new System.Windows.Forms.TextBox();
            this.lPatente = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbDatosVehiculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosVehiculo
            // 
            this.gbDatosVehiculo.Controls.Add(this.tbCapacidadVehiculo);
            this.gbDatosVehiculo.Controls.Add(this.lCapacidadVehiculo);
            this.gbDatosVehiculo.Controls.Add(this.rbCamion);
            this.gbDatosVehiculo.Controls.Add(this.rbFurgon);
            this.gbDatosVehiculo.Controls.Add(this.lTipo);
            this.gbDatosVehiculo.Controls.Add(this.tbPatente);
            this.gbDatosVehiculo.Controls.Add(this.lPatente);
            this.gbDatosVehiculo.Location = new System.Drawing.Point(12, 12);
            this.gbDatosVehiculo.Name = "gbDatosVehiculo";
            this.gbDatosVehiculo.Size = new System.Drawing.Size(206, 172);
            this.gbDatosVehiculo.TabIndex = 0;
            this.gbDatosVehiculo.TabStop = false;
            this.gbDatosVehiculo.Text = "Datos del vehiculo";
            // 
            // tbCapacidadVehiculo
            // 
            this.tbCapacidadVehiculo.Location = new System.Drawing.Point(21, 139);
            this.tbCapacidadVehiculo.Name = "tbCapacidadVehiculo";
            this.tbCapacidadVehiculo.Size = new System.Drawing.Size(100, 20);
            this.tbCapacidadVehiculo.TabIndex = 6;
            // 
            // lCapacidadVehiculo
            // 
            this.lCapacidadVehiculo.AutoSize = true;
            this.lCapacidadVehiculo.Location = new System.Drawing.Point(18, 123);
            this.lCapacidadVehiculo.Name = "lCapacidadVehiculo";
            this.lCapacidadVehiculo.Size = new System.Drawing.Size(178, 13);
            this.lCapacidadVehiculo.TabIndex = 5;
            this.lCapacidadVehiculo.Text = "Capacidad del vehiculo (Kilogramos)";
            // 
            // rbCamion
            // 
            this.rbCamion.AutoSize = true;
            this.rbCamion.Location = new System.Drawing.Point(85, 48);
            this.rbCamion.Name = "rbCamion";
            this.rbCamion.Size = new System.Drawing.Size(60, 17);
            this.rbCamion.TabIndex = 4;
            this.rbCamion.Text = "Camion";
            this.rbCamion.UseVisualStyleBackColor = true;
            // 
            // rbFurgon
            // 
            this.rbFurgon.AutoSize = true;
            this.rbFurgon.Checked = true;
            this.rbFurgon.Location = new System.Drawing.Point(21, 48);
            this.rbFurgon.Name = "rbFurgon";
            this.rbFurgon.Size = new System.Drawing.Size(58, 17);
            this.rbFurgon.TabIndex = 3;
            this.rbFurgon.TabStop = true;
            this.rbFurgon.Text = "Furgon";
            this.rbFurgon.UseVisualStyleBackColor = true;
            // 
            // lTipo
            // 
            this.lTipo.AutoSize = true;
            this.lTipo.Location = new System.Drawing.Point(18, 29);
            this.lTipo.Name = "lTipo";
            this.lTipo.Size = new System.Drawing.Size(86, 13);
            this.lTipo.TabIndex = 2;
            this.lTipo.Text = "Tipo de vehiculo";
            // 
            // tbPatente
            // 
            this.tbPatente.Location = new System.Drawing.Point(21, 91);
            this.tbPatente.Name = "tbPatente";
            this.tbPatente.Size = new System.Drawing.Size(100, 20);
            this.tbPatente.TabIndex = 1;
            // 
            // lPatente
            // 
            this.lPatente.AutoSize = true;
            this.lPatente.Location = new System.Drawing.Point(18, 75);
            this.lPatente.Name = "lPatente";
            this.lPatente.Size = new System.Drawing.Size(44, 13);
            this.lPatente.TabIndex = 0;
            this.lPatente.Text = "Patente";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(12, 190);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(77, 46);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(97, 190);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(121, 46);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Añadir vehiculo";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // ModalAñadirVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 251);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbDatosVehiculo);
            this.Name = "ModalAñadirVehiculo";
            this.Text = "Añadir vehiculo";
            this.gbDatosVehiculo.ResumeLayout(false);
            this.gbDatosVehiculo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosVehiculo;
        private System.Windows.Forms.Label lTipo;
        private System.Windows.Forms.Label lPatente;
        private System.Windows.Forms.Label lCapacidadVehiculo;
        public System.Windows.Forms.RadioButton rbCamion;
        public System.Windows.Forms.RadioButton rbFurgon;
        public System.Windows.Forms.TextBox tbPatente;
        public System.Windows.Forms.TextBox tbCapacidadVehiculo;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnAceptar;
    }
}