using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5 {
	internal class Mostrador : Vendedor {
		double basico;

		public Mostrador(string nombre, double basico, int codigo) : base(nombre, codigo) {
			this.basico = basico;
		}

		public override double Sueldo() {
			return basico+(ventas*0.05);
		}
	}
}
