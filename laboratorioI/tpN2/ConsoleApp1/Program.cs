using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static private void ActivarMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t\t\t¡¡Hola bienvenido al PARQUE DE DIVERSIONES!!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\tElija una opcion de compra");
            Console.WriteLine("*   1 - Comprar entrada individual    *");
            Console.WriteLine("*   2 – Comprar entrada pasaporte     *");
            Console.WriteLine("*   3 – Cerrar caja                   *");
            Console.Write("    Ingrese opcion deseada: ");
        }
        static void Main(string[] args)
        {
            //VARIABLES
            int edad, cantIndividual = 0, grupo, cantPersonas = 0, cantMenores = 0, cantPer10y15 = 0, cantMayores = 0,
                cantPasaporte = 0, acumEdadTotal = 0, opcion = -1;

            double recaudacionTicket = 0, recaudacionPasaporte = 0, recaudacionGrupoPasaporte = 0, recaudacionTotal = 0,
                   ticketMenores4 = 150, ticketMenores11 = 750, ticketMenores16 = 1200, ticketMayores = 1500, promedioEdadTotal=0;

            string teclaCompra;

            //MENU PRINCIPAL 

            while (opcion != 4)
            {
                ActivarMenu();
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:

                        //MENU INDIVUDUAL

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\t\t\t\t\t\tCompra de entrada individual");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Ingrese edad: ");
                        edad = Convert.ToInt32(Console.ReadLine());
                        cantPersonas++;
                        acumEdadTotal += edad;
                        cantIndividual++;

                        //ITERACION INDIVIDUAL

                        while (edad != -1)
                        {
                            if (edad < 16)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Usted no puede realizar esta compra");
                            }
                            else if (edad < 21)
                            {
                                cantMenores++;
                                cantIndividual++;
                                recaudacionTicket += ticketMayores;
                            }
                            else
                            {
                                cantMayores++;
                                cantIndividual++;
                                recaudacionTicket += ticketMayores;
                            }


                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Ingrese otra edad o -1 para finalizar: ");
                            edad = Convert.ToInt32(Console.ReadLine());

                            if (edad != -1)
                            {
                               cantPersonas++;
                               acumEdadTotal += edad;
                            }                           
                        }

                        Console.WriteLine("El valor del ticket es de: {0:c}", recaudacionTicket);
                        Console.WriteLine("Desea confirmar la compra? [s/n]");
                        teclaCompra = Console.ReadLine();
                        while (teclaCompra != "s" && teclaCompra != "S" && teclaCompra != "n" && teclaCompra != "N")
                        {
                            Console.WriteLine("Por favor escriba S/s o N/n");
                            teclaCompra = Console.ReadLine();
                        }
                        switch (teclaCompra)
                        {
                            case "s":
                            case "S":
                                break;
                            case "n":
                            case "N":
                                recaudacionTicket = 0;
                                cantPersonas -= cantPersonas;
                                break;
                        }
                        Console.WriteLine("Presione una tecla para volver al menu principal");
                        break;

                    case 2:

                        //MENU PASAPORTE

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\t\t\t\t\t\tCompra de entrada pasaporte");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Ingrese cantidad de personas");
                        grupo = Convert.ToInt32(Console.ReadLine());
                        cantPersonas += grupo;
                        cantPasaporte += grupo;
                        //ITERACION PASAPORTE

                        recaudacionGrupoPasaporte = 0;

                        for (int i = 1; i <= grupo; i++)
                        {

                            Console.Write("Ingrese edad: ");
                            edad = Convert.ToInt32(Console.ReadLine());
                            acumEdadTotal += edad;
                            if (edad > 9 && edad < 16)
                            {
                                cantPer10y15++;
                            }
                            if (edad < 4)
                            {
                                cantMenores++;
                                recaudacionGrupoPasaporte += ticketMenores4;
                            }
                            else if (edad < 11)
                            {
                                cantMenores++;
                                recaudacionGrupoPasaporte += (ticketMenores11*0.85);
                            }
                            else if (edad < 16)
                            {
                                cantMenores++;
                                recaudacionGrupoPasaporte += (ticketMenores16 * 0.85);
                }
                            else if (edad < 21)
                            {
                                cantMenores++;
                                recaudacionGrupoPasaporte += (ticketMayores * 0.85);
                }
                            else
                            {
                                cantMayores++;
                                recaudacionGrupoPasaporte += (ticketMayores * 0.85);
                }

                        }
                        Console.WriteLine("El valor del ticket es de: {0:c}", recaudacionGrupoPasaporte);
                        Console.WriteLine("Desea confirmar la compra? [s/n]");
                        teclaCompra = Console.ReadLine();
                        while (teclaCompra != "s" && teclaCompra != "S" && teclaCompra != "n" && teclaCompra != "N")
                        {
                            Console.WriteLine("Por favor escriba S/s o N/n");
                            teclaCompra = Console.ReadLine();
                        }
                        switch (teclaCompra)
                        {
                            case "s":
                            case "S":
                                recaudacionPasaporte += recaudacionGrupoPasaporte;
                                break;
                            case "n":
                            case "N":
                                cantPersonas -= cantPersonas;
                                break;
                        }
                        Console.WriteLine("Presione una tecla para volver al menu principal");

                        break;

                    case 3:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\t\t\t\t\t\t\tTicket");
                        Console.ForegroundColor = ConsoleColor.White;
                        recaudacionTotal = recaudacionPasaporte + recaudacionTicket;
                        promedioEdadTotal = (double)acumEdadTotal / cantPersonas;
                        if (cantPersonas > 0)
                        {
                            Console.WriteLine("La recaudacion del dia es de: {0:c}", recaudacionTotal);
                            Console.WriteLine("La recaudacion de los pasaportes es de: {0:c}", recaudacionPasaporte);
                            Console.WriteLine("La recaudacion de tickets individuales es de: {0:c}\n", recaudacionTicket);
                            Console.WriteLine("Cantidad de personas que entraron con pasaporte: {0}", cantPasaporte);
                            Console.WriteLine("Cantidad de personas entre 10 y 15 años: {0}", cantPer10y15);
                            Console.WriteLine("El promedio de edad de todos los asistentes es de: {0:F3}", promedioEdadTotal);
                        }
                        else
                        {
                            Console.WriteLine("No asistio gente");
                        }
                        break;

                }
                Console.ReadKey();
            }
        }
    }
}
