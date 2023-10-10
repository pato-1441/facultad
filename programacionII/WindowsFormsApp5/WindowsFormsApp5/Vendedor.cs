using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5 {
	internal abstract class Vendedor:IComparable {
		int codigo;
		string nombre;
		protected double ventas;

		public int GetCodigo() {
			return codigo;
		}
		public void ResetearVentas() {
			ventas = 0;
		}
		public Vendedor(string nombre, int codigo) { 
			this.nombre = nombre;
			this.codigo = codigo;
		}
		public virtual double Sueldo() {
			return ventas;
		}
		public void AgregarVenta(double monto) {
			ventas += monto;
		}

		public int CompareTo(object obj) {
			return this.codigo.CompareTo(((Vendedor)obj).codigo);
		}
	}
}
