namespace SUBUTN
{
    partial class RegistroLogueo
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
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rbIngresar = new System.Windows.Forms.RadioButton();
            this.rbRegistrar = new System.Windows.Forms.RadioButton();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(40, 38);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(188, 20);
            this.tbDNI.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(92, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rbIngresar
            // 
            this.rbIngresar.AutoSize = true;
            this.rbIngresar.Checked = true;
            this.rbIngresar.Location = new System.Drawing.Point(40, 65);
            this.rbIngresar.Name = "rbIngresar";
            this.rbIngresar.Size = new System.Drawing.Size(63, 17);
            this.rbIngresar.TabIndex = 3;
            this.rbIngresar.TabStop = true;
            this.rbIngresar.Text = "Ingresar";
            this.rbIngresar.UseVisualStyleBackColor = true;
            this.rbIngresar.CheckedChanged += new System.EventHandler(this.rbIngresar_CheckedChanged);
            // 
            // rbRegistrar
            // 
            this.rbRegistrar.AutoSize = true;
            this.rbRegistrar.Location = new System.Drawing.Point(40, 89);
            this.rbRegistrar.Name = "rbRegistrar";
            this.rbRegistrar.Size = new System.Drawing.Size(67, 17);
            this.rbRegistrar.TabIndex = 4;
            this.rbRegistrar.Text = "Registrar";
            this.rbRegistrar.UseVisualStyleBackColor = true;
            // 
            // tbNombre
            // 
            this.tbNombre.Enabled = false;
            this.tbNombre.Location = new System.Drawing.Point(40, 130);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(188, 20);
            this.tbNombre.TabIndex = 5;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Enabled = false;
            this.tbDireccion.Location = new System.Drawing.Point(40, 169);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(188, 20);
            this.tbDireccion.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Direccion";
            // 
            // RegistroLogueo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 245);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.rbRegistrar);
            this.Controls.Add(this.rbIngresar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDNI);
            this.Name = "RegistroLogueo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ingresar";
            this.Load += new System.EventHandler(this.RegistroLogueo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbDNI;
        public System.Windows.Forms.RadioButton rbIngresar;
        public System.Windows.Forms.RadioButton rbRegistrar;
        public System.Windows.Forms.TextBox tbNombre;
        public System.Windows.Forms.TextBox tbDireccion;
    }
}