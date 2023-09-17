using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Una aplicación almacena los nombres de los clientes, como cadenas de caracteres en mayúscula,
            primero el apellido y luego el nombre, separados por una coma y un espacio en blanco.
            Por ejemplo: PEREZ, JUAN CARLOS Se requiere de un método que permita obtener a partir del
            nombre del cliente con el formato indicado una nueva versión del mismo con solo la primera
            letra de cada palabra en mayúscula, sin la coma, y que comience por el nombre. Investigue
            los argumentos y funcionalidad e los métodos SubString y Trim de la clase string, elabore
            para cada uno una breve reseña sobre su funcionamiento. 
            */
            string[] nombresArray = {"PEREZ, JUAN CARLOS", "RODRIGUEZ, ALFONSO", "BENAVIDES, MOMO GERONIMO"};
            foreach (string nombre in nombresArray)
            {
                Console.WriteLine(nombre);
            }
            Console.WriteLine("\n");
            foreach (string nom in nombresArray)
            {
                Console.WriteLine(FormatearTexto(nom));
            }
            Console.ReadKey();
        }

        private static string FormatearTexto(string nom)
        {
            int indiceComa, indiceSegundoNombre;
            string resultado;

            indiceComa = nom.IndexOf(", ");
            string nombre = nom.Substring(indiceComa + 2, 1);
            string apellido = nom.Substring(0, indiceComa);

            string nombreCompleto = nom.Substring(indiceComa + 2);
            indiceSegundoNombre = nombreCompleto.IndexOf(" ");
            string nombreSegundo = nombreCompleto.Substring(indiceSegundoNombre + 1, 1);

            if (indiceSegundoNombre != -1)
            {
                resultado = nombre + nombreSegundo + apellido[0];
            }
            else
            {
                resultado = nombre + apellido[0];
            }

            return resultado;
        }
    }
}
