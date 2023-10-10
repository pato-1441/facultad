namespace WindowsFormsApp5 {
	partial class Form1 {
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent() {
			this.btnAgregarVendedor = new System.Windows.Forms.Button();
			this.tbNombreVendedor = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbCodigoVendedorAgregar = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbBasicoVendedor = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbCodigoVendedorVenta = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tbMontoVenta = new System.Windows.Forms.TextBox();
			this.btnAgregarVenta = new System.Windows.Forms.Button();
			this.btnVerSueldos = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnAgregarVendedor
			// 
			this.btnAgregarVendedor.Location = new System.Drawing.Point(236, 40);
			this.btnAgregarVendedor.Name = "btnAgregarVendedor";
			this.btnAgregarVendedor.Size = new System.Drawing.Size(106, 161);
			this.btnAgregarVendedor.TabIndex = 0;
			this.btnAgregarVendedor.Text = "Agregar Vendedor";
			this.btnAgregarVendedor.UseVisualStyleBackColor = true;
			this.btnAgregarVendedor.Click += new System.EventHandler(this.button1_Click);
			// 
			// tbNombreVendedor
			// 
			this.tbNombreVendedor.Location = new System.Drawing.Point(77, 63);
			this.tbNombreVendedor.Name = "tbNombreVendedor";
			this.tbNombreVendedor.Size = new System.Drawing.Size(133, 22);
			this.tbNombreVendedor.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(74, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nombre vendedor:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(74, 156);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(115, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Codigo vendedor:";
			// 
			// tbCodigoVendedorAgregar
			// 
			this.tbCodigoVendedorAgregar.Location = new System.Drawing.Point(77, 179);
			this.tbCodigoVendedorAgregar.Name = "tbCodigoVendedorAgregar";
			this.tbCodigoVendedorAgregar.Size = new System.Drawing.Size(133, 22);
			this.tbCodigoVendedorAgregar.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(74, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(113, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "Basico vendedor:";
			// 
			// tbBasicoVendedor
			// 
			this.tbBasicoVendedor.Location = new System.Drawing.Point(77, 121);
			this.tbBasicoVendedor.Name = "tbBasicoVendedor";
			this.tbBasicoVendedor.Size = new System.Drawing.Size(133, 22);
			this.tbBasicoVendedor.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(386, 98);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(115, 16);
			this.label5.TabIndex = 11;
			this.label5.Text = "Codigo vendedor:";
			// 
			// tbCodigoVendedorVenta
			// 
			this.tbCodigoVendedorVenta.Location = new System.Drawing.Point(389, 121);
			this.tbCodigoVendedorVenta.Name = "tbCodigoVendedorVenta";
			this.tbCodigoVendedorVenta.Size = new System.Drawing.Size(133, 22);
			this.tbCodigoVendedorVenta.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(386, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 16);
			this.label6.TabIndex = 9;
			this.label6.Text = "Monto venta:";
			// 
			// tbMontoVenta
			// 
			this.tbMontoVenta.Location = new System.Drawing.Point(389, 63);
			this.tbMontoVenta.Name = "tbMontoVenta";
			this.tbMontoVenta.Size = new System.Drawing.Size(133, 22);
			this.tbMontoVenta.TabIndex = 8;
			// 
			// btnAgregarVenta
			// 
			this.btnAgregarVenta.Location = new System.Drawing.Point(562, 40);
			this.btnAgregarVenta.Name = "btnAgregarVenta";
			this.btnAgregarVenta.Size = new System.Drawing.Size(106, 103);
			this.btnAgregarVenta.TabIndex = 7;
			this.btnAgregarVenta.Text = "Agregar Venta";
			this.btnAgregarVenta.UseVisualStyleBackColor = true;
			this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
			// 
			// btnVerSueldos
			// 
			this.btnVerSueldos.Location = new System.Drawing.Point(502, 213);
			this.btnVerSueldos.Name = "btnVerSueldos";
			this.btnVerSueldos.Size = new System.Drawing.Size(166, 51);
			this.btnVerSueldos.TabIndex = 12;
			this.btnVerSueldos.Text = "Ver Sueldos";
			this.btnVerSueldos.UseVisualStyleBackColor = true;
			this.btnVerSueldos.Click += new System.EventHandler(this.btnVerSueldos_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(723, 297);
			this.Controls.Add(this.btnVerSueldos);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbCodigoVendedorVenta);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tbMontoVenta);
			this.Controls.Add(this.btnAgregarVenta);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbBasicoVendedor);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbCodigoVendedorAgregar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbNombreVendedor);
			this.Controls.Add(this.btnAgregarVendedor);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAgregarVendedor;
		private System.Windows.Forms.TextBox tbNombreVendedor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbCodigoVendedorAgregar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbBasicoVendedor;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbCodigoVendedorVenta;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbMontoVenta;
		private System.Windows.Forms.Button btnAgregarVenta;
		private System.Windows.Forms.Button btnVerSueldos;
	}
}

