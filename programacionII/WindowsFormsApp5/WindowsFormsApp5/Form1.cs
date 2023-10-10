using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}
		Empresa miEmpresa;
		private void button1_Click(object sender, EventArgs e) {
			Vendedor vendedor = new Mostrador(tbNombreVendedor.Text,
							Convert.ToDouble(tbBasicoVendedor.Text),
							Convert.ToInt32(tbCodigoVendedorAgregar.Text));
			miEmpresa.AgregarVendedor(vendedor);
		}

		private void btnVerSueldos_Click(object sender, EventArgs e) {
			foreach(Vendedor vendedor in miEmpresa.Vendedores) {
				string sueldo = Convert.ToString(vendedor.Sueldo());
				MessageBox.Show(sueldo);
			}
		}

		private void Form1_Load(object sender, EventArgs e) {
			miEmpresa = new Empresa();
		}

		private void btnAgregarVenta_Click(object sender, EventArgs e) {
			if(Convert.ToDouble(tbMontoVenta.Text) > 0) {
				miEmpresa.AgregarVenta(Convert.ToDouble(tbMontoVenta.Text),
									Convert.ToInt32(tbCodigoVendedorVenta.Text));
			} else {
				MessageBox.Show("Ingrese un monto valido! >:/");
			}
			
		}
	}
}
