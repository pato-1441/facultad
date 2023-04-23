// Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class Ej8MenorValor {

		static void Main(string[] args) {

			int contador,menor,num,orden;
			contador = 0;
			orden = 1;

			Console.WriteLine("Ingrese el primer valor: ");
			num = Convert.ToInt32(Console.ReadLine());
			menor = num;
			contador = contador+1;

			Console.WriteLine("Ingrese el segundo valor: ");
			num = Convert.ToInt32(Console.ReadLine());
			if (num<menor) {
				menor = num;
				orden = contador;
			}

			Console.WriteLine("Ingrese el tercer valor: ");
			num = Convert.ToInt32(Console.ReadLine());
			if (num<menor) {
				menor = num;
				orden = contador;
			}

			Console.WriteLine("Ingrese el cuarto valor: ");
			num = Convert.ToInt32(Console.ReadLine());
			if (num<menor) {
				menor = num;
				orden = contador;
			}

			Console.WriteLine("Ingrese el quinto valor: ");
			num = Convert.ToInt32(Console.ReadLine());
			if (num<menor) {
				menor = num;
				orden = contador;
			}

			Console.WriteLine("El menor valor es: {0}, fue ingresado en: {1}° lugar.", menor, orden);
			Console.ReadKey();
		}

	}

}

