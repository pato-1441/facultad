namespace ConsoleApp1
{
    partial class SortAlghoritms
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
            this.gbTiposDatos = new System.Windows.Forms.GroupBox();
            this.gbEnteros = new System.Windows.Forms.GroupBox();
            this.gbReales = new System.Windows.Forms.GroupBox();
            this.gbStrings = new System.Windows.Forms.GroupBox();
            this.btn16Bit = new System.Windows.Forms.Button();
            this.btn64Bit = new System.Windows.Forms.Button();
            this.btnFloat = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btn32Char = new System.Windows.Forms.Button();
            this.btn8Char = new System.Windows.Forms.Button();
            this.gbTiposDatos.SuspendLayout();
            this.gbEnteros.SuspendLayout();
            this.gbReales.SuspendLayout();
            this.gbStrings.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTiposDatos
            // 
            this.gbTiposDatos.Controls.Add(this.gbStrings);
            this.gbTiposDatos.Controls.Add(this.gbReales);
            this.gbTiposDatos.Controls.Add(this.gbEnteros);
            this.gbTiposDatos.Location = new System.Drawing.Point(12, 12);
            this.gbTiposDatos.Name = "gbTiposDatos";
            this.gbTiposDatos.Size = new System.Drawing.Size(519, 173);
            this.gbTiposDatos.TabIndex = 0;
            this.gbTiposDatos.TabStop = false;
            this.gbTiposDatos.Text = "Tipos de Datos";
            // 
            // gbEnteros
            // 
            this.gbEnteros.Controls.Add(this.btn64Bit);
            this.gbEnteros.Controls.Add(this.btn16Bit);
            this.gbEnteros.Location = new System.Drawing.Point(15, 28);
            this.gbEnteros.Name = "gbEnteros";
            this.gbEnteros.Size = new System.Drawing.Size(133, 128);
            this.gbEnteros.TabIndex = 0;
            this.gbEnteros.TabStop = false;
            this.gbEnteros.Text = "Enteros";
            // 
            // gbReales
            // 
            this.gbReales.Controls.Add(this.btnFloat);
            this.gbReales.Controls.Add(this.btnDecimal);
            this.gbReales.Location = new System.Drawing.Point(180, 31);
            this.gbReales.Name = "gbReales";
            this.gbReales.Size = new System.Drawing.Size(133, 125);
            this.gbReales.TabIndex = 1;
            this.gbReales.TabStop = false;
            this.gbReales.Text = "Reales";
            // 
            // gbStrings
            // 
            this.gbStrings.Controls.Add(this.btn32Char);
            this.gbStrings.Controls.Add(this.btn8Char);
            this.gbStrings.Location = new System.Drawing.Point(357, 28);
            this.gbStrings.Name = "gbStrings";
            this.gbStrings.Size = new System.Drawing.Size(133, 128);
            this.gbStrings.TabIndex = 1;
            this.gbStrings.TabStop = false;
            this.gbStrings.Text = "Strings";
            // 
            // btn16Bit
            // 
            this.btn16Bit.Location = new System.Drawing.Point(16, 29);
            this.btn16Bit.Name = "btn16Bit";
            this.btn16Bit.Size = new System.Drawing.Size(101, 33);
            this.btn16Bit.TabIndex = 0;
            this.btn16Bit.Text = "16 bit";
            this.btn16Bit.UseVisualStyleBackColor = true;
            // 
            // btn64Bit
            // 
            this.btn64Bit.Location = new System.Drawing.Point(16, 68);
            this.btn64Bit.Name = "btn64Bit";
            this.btn64Bit.Size = new System.Drawing.Size(101, 33);
            this.btn64Bit.TabIndex = 1;
            this.btn64Bit.Text = "64 bit";
            this.btn64Bit.UseVisualStyleBackColor = true;
            // 
            // btnFloat
            // 
            this.btnFloat.Location = new System.Drawing.Point(16, 65);
            this.btnFloat.Name = "btnFloat";
            this.btnFloat.Size = new System.Drawing.Size(101, 33);
            this.btnFloat.TabIndex = 3;
            this.btnFloat.Text = "Float (32 bits)";
            this.btnFloat.UseVisualStyleBackColor = true;
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(16, 26);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(101, 33);
            this.btnDecimal.TabIndex = 2;
            this.btnDecimal.Text = "Decimal (128 bits)";
            this.btnDecimal.UseVisualStyleBackColor = true;
            // 
            // btn32Char
            // 
            this.btn32Char.Location = new System.Drawing.Point(17, 68);
            this.btn32Char.Name = "btn32Char";
            this.btn32Char.Size = new System.Drawing.Size(101, 33);
            this.btn32Char.TabIndex = 5;
            this.btn32Char.Text = "32 characters";
            this.btn32Char.UseVisualStyleBackColor = true;
            // 
            // btn8Char
            // 
            this.btn8Char.Location = new System.Drawing.Point(17, 29);
            this.btn8Char.Name = "btn8Char";
            this.btn8Char.Size = new System.Drawing.Size(101, 33);
            this.btn8Char.TabIndex = 4;
            this.btn8Char.Text = "8 characters";
            this.btn8Char.UseVisualStyleBackColor = true;
            // 
            // SortAlghoritms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 205);
            this.Controls.Add(this.gbTiposDatos);
            this.Name = "SortAlghoritms";
            this.Text = "SortAlghoritms";
            this.gbTiposDatos.ResumeLayout(false);
            this.gbEnteros.ResumeLayout(false);
            this.gbReales.ResumeLayout(false);
            this.gbStrings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTiposDatos;
        private System.Windows.Forms.GroupBox gbStrings;
        private System.Windows.Forms.GroupBox gbReales;
        private System.Windows.Forms.GroupBox gbEnteros;
        private System.Windows.Forms.Button btn64Bit;
        private System.Windows.Forms.Button btn16Bit;
        private System.Windows.Forms.Button btn32Char;
        private System.Windows.Forms.Button btn8Char;
        private System.Windows.Forms.Button btnFloat;
        private System.Windows.Forms.Button btnDecimal;
    }
}