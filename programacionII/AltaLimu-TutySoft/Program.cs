using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AltaLimu_TutySoft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            try 
            {
                cliente.Nombre = "Matias";
                cliente.Apellido = "PEREZ LOPEZ";
                cliente.Cuit = 11111111111;
                cliente.NroSerie = "AA-111-BB";
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            Console.ReadKey();
        }

    }
}
