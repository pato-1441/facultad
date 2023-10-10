using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5 {
	internal class Temporal:Vendedor {
		double basico;

		public Temporal(string nombre, double basico, int codigo) : base(nombre, codigo) {
			this.basico = basico;
		}

		public override double Sueldo() {
			double sueldo = 0;
			if(ventas <= 1000000) {
				sueldo = basico + ( ventas * 0.15 );
			} else if (ventas > 1000000) {
				sueldo = basico + (ventas * 0.20);
			}
			return sueldo;
		}
	}
}
