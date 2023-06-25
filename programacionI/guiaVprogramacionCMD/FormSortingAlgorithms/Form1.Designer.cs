namespace FormSortingAlgorithms
{
    partial class FormAlgoritmosOrdenamiento
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
            this.gbString = new System.Windows.Forms.GroupBox();
            this.gbReales = new System.Windows.Forms.GroupBox();
            this.gbEnteros = new System.Windows.Forms.GroupBox();
            this.btnEntero16 = new System.Windows.Forms.Button();
            this.btnEntero64 = new System.Windows.Forms.Button();
            this.btnReal128 = new System.Windows.Forms.Button();
            this.btnReal32 = new System.Windows.Forms.Button();
            this.btnString32 = new System.Windows.Forms.Button();
            this.btnString8 = new System.Windows.Forms.Button();
            this.gbTiposDatos.SuspendLayout();
            this.gbString.SuspendLayout();
            this.gbReales.SuspendLayout();
            this.gbEnteros.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTiposDatos
            // 
            this.gbTiposDatos.Controls.Add(this.gbString);
            this.gbTiposDatos.Controls.Add(this.gbReales);
            this.gbTiposDatos.Controls.Add(this.gbEnteros);
            this.gbTiposDatos.Location = new System.Drawing.Point(12, 12);
            this.gbTiposDatos.Name = "gbTiposDatos";
            this.gbTiposDatos.Size = new System.Drawing.Size(387, 175);
            this.gbTiposDatos.TabIndex = 0;
            this.gbTiposDatos.TabStop = false;
            this.gbTiposDatos.Text = "Tipos de Datos";
            // 
            // gbString
            // 
            this.gbString.Controls.Add(this.btnString32);
            this.gbString.Controls.Add(this.btnString8);
            this.gbString.Location = new System.Drawing.Point(255, 28);
            this.gbString.Name = "gbString";
            this.gbString.Size = new System.Drawing.Size(114, 130);
            this.gbString.TabIndex = 2;
            this.gbString.TabStop = false;
            this.gbString.Text = "String";
            // 
            // gbReales
            // 
            this.gbReales.Controls.Add(this.btnReal128);
            this.gbReales.Controls.Add(this.btnReal32);
            this.gbReales.Location = new System.Drawing.Point(135, 28);
            this.gbReales.Name = "gbReales";
            this.gbReales.Size = new System.Drawing.Size(114, 130);
            this.gbReales.TabIndex = 1;
            this.gbReales.TabStop = false;
            this.gbReales.Text = "Reales";
            // 
            // gbEnteros
            // 
            this.gbEnteros.Controls.Add(this.btnEntero64);
            this.gbEnteros.Controls.Add(this.btnEntero16);
            this.gbEnteros.Location = new System.Drawing.Point(15, 28);
            this.gbEnteros.Name = "gbEnteros";
            this.gbEnteros.Size = new System.Drawing.Size(114, 130);
            this.gbEnteros.TabIndex = 0;
            this.gbEnteros.TabStop = false;
            this.gbEnteros.Text = "Enteros";
            // 
            // btnEntero16
            // 
            this.btnEntero16.Location = new System.Drawing.Point(16, 36);
            this.btnEntero16.Name = "btnEntero16";
            this.btnEntero16.Size = new System.Drawing.Size(82, 23);
            this.btnEntero16.TabIndex = 0;
            this.btnEntero16.Text = "16 bits";
            this.btnEntero16.UseVisualStyleBackColor = true;
            // 
            // btnEntero64
            // 
            this.btnEntero64.Location = new System.Drawing.Point(16, 75);
            this.btnEntero64.Name = "btnEntero64";
            this.btnEntero64.Size = new System.Drawing.Size(82, 23);
            this.btnEntero64.TabIndex = 1;
            this.btnEntero64.Text = "64 bits";
            this.btnEntero64.UseVisualStyleBackColor = true;
            // 
            // btnReal128
            // 
            this.btnReal128.Location = new System.Drawing.Point(16, 75);
            this.btnReal128.Name = "btnReal128";
            this.btnReal128.Size = new System.Drawing.Size(82, 23);
            this.btnReal128.TabIndex = 3;
            this.btnReal128.Text = "128 bits";
            this.btnReal128.UseVisualStyleBackColor = true;
            // 
            // btnReal32
            // 
            this.btnReal32.Location = new System.Drawing.Point(16, 36);
            this.btnReal32.Name = "btnReal32";
            this.btnReal32.Size = new System.Drawing.Size(82, 23);
            this.btnReal32.TabIndex = 2;
            this.btnReal32.Text = "32 bits";
            this.btnReal32.UseVisualStyleBackColor = true;
            // 
            // btnString32
            // 
            this.btnString32.Location = new System.Drawing.Point(15, 75);
            this.btnString32.Name = "btnString32";
            this.btnString32.Size = new System.Drawing.Size(82, 23);
            this.btnString32.TabIndex = 5;
            this.btnString32.Text = "32 caracteres";
            this.btnString32.UseVisualStyleBackColor = true;
            // 
            // btnString8
            // 
            this.btnString8.Location = new System.Drawing.Point(15, 36);
            this.btnString8.Name = "btnString8";
            this.btnString8.Size = new System.Drawing.Size(82, 23);
            this.btnString8.TabIndex = 4;
            this.btnString8.Text = "8 caracteres";
            this.btnString8.UseVisualStyleBackColor = true;
            // 
            // FormAlgoritmosOrdenamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 203);
            this.Controls.Add(this.gbTiposDatos);
            this.Name = "FormAlgoritmosOrdenamiento";
            this.Text = "Algoritmos de Ordenamiento";
            this.gbTiposDatos.ResumeLayout(false);
            this.gbString.ResumeLayout(false);
            this.gbReales.ResumeLayout(false);
            this.gbEnteros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTiposDatos;
        private System.Windows.Forms.GroupBox gbString;
        private System.Windows.Forms.GroupBox gbReales;
        private System.Windows.Forms.GroupBox gbEnteros;
        private System.Windows.Forms.Button btnString32;
        private System.Windows.Forms.Button btnString8;
        private System.Windows.Forms.Button btnReal128;
        private System.Windows.Forms.Button btnReal32;
        private System.Windows.Forms.Button btnEntero64;
        private System.Windows.Forms.Button btnEntero16;
    }
}

