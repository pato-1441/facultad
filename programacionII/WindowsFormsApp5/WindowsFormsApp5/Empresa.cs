using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5 {
	internal class Empresa {
		int cantVendedores;
		List<Vendedor> vendedores = new List<Vendedor>();

		public List<Vendedor> Vendedores { get { return vendedores;} }

		public void AgregarVendedor(Vendedor vendedor) {
			vendedores.Add(vendedor);
			cantVendedores++;
		}

		public Empresa() {
			cantVendedores = 0;
		}

		public void AgregarVenta(double monto, int codigoVendedor) {
			Vendedor vendedor = BuscarVendedor(codigoVendedor);
			if(vendedor != null) {
				vendedor.AgregarVenta(monto);
			}
		}

		public double VerSueldo(int codigoVendedor) {
			double sueldo = 0;
			Vendedor vendedor = BuscarVendedor(codigoVendedor);
			if(vendedor != null) {
				sueldo = vendedor.Sueldo();
			}
			return sueldo;
		}

		/*public string[,] Sueldos() {
			string sueldos;
			return sueldos;
		}*/

		public Vendedor BuscarVendedor(int codigoVendedor) {
			Vendedor vendedor = new Mostrador("", 0, codigoVendedor);
			vendedores.Sort();

			int posicion = vendedores.BinarySearch(vendedor);
			if(posicion >= 0) {
				vendedor = vendedores[posicion];
			} else {
				vendedor = null;
			}		

			return vendedor;
		}
	}
}
