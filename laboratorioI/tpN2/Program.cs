using System;

namespace TpN2
{
    internal class Program
    {
        static private void ActivarMenu()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\t¡Hola bienvenido al parque de diversiones!\n");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\t╔═════════════════════════════════════╗");
            Console.WriteLine("\t║   Elija una opcion de compra        ║");
            Console.WriteLine("\t╠═════════════════════════════════════║");
            Console.WriteLine("\t║   1 - Comprar entrada individual    ║");
            Console.WriteLine("\t╠═════════════════════════════════════║");
            Console.WriteLine("\t║   2 – Comprar entrada pasaporte     ║");
            Console.WriteLine("\t╠═════════════════════════════════════║");
            Console.WriteLine("\t║   3 – Cerrar caja                   ║");
            Console.WriteLine("\t╠═════════════════════════════════════║");
            Console.WriteLine("\t║   4 – Salir                         ║");
            Console.WriteLine("\t╚═════════════════════════════════════╝");
            Console.Write("\n \tOpcion: ");
        }
        static void Main(string[] args)
        {
            //VARIABLES

            int edad, grupo, cantGrupos = 0, opcion = -1,
            cantPerIndividual = 0, cantPerPasaporte = 0, cantPersonasTotal, cantPersonas,
            cantPer10y15, cantPer10y15Total = 0, cantMenores = 0,
            acumEdadTotal = 0, acumEdad, cantMayoresGrupo;

            double recaudacionTicket, recaudacionTicketTotal = 0, recaudacionPasaporte = 0, recaudacionGrupoPasaporte, recaudacionTotal,
                   ticketMenores4 = 150, ticketMenores11 = 750, ticketMenores16 = 1200, ticketMayores = 1500, promedioEdadTotal;

            string teclaCompra;

            //MENU PRINCIPAL 

            while (opcion != 4)
            {
                ActivarMenu();
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:


                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("  \nCompra de entrada individual");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("\nIngrese edad o -1 para finalizar: ");
                        edad = Convert.ToInt32(Console.ReadLine());
                        recaudacionTicket = 0;
                        cantPersonas = 0;
                        acumEdad = 0;

                        while (edad != -1)
                        {

                            if (edad < 16)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Usted no puede realizar esta compra");
                            }
                            else
                            {
                                acumEdad += edad;
                                cantPersonas++;
                                recaudacionTicket += ticketMayores;
                            }

                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("Ingrese otra edad o -1 para finalizar: ");
                            edad = Convert.ToInt32(Console.ReadLine());
                        }

                        Console.WriteLine("\nEl valor del ticket es de: {0:c}", recaudacionTicket);
                        Console.WriteLine("\nDesea confirmar la compra? [s/n]");
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
                                recaudacionTicketTotal += recaudacionTicket;
                                cantPerIndividual += cantPersonas;
                                acumEdadTotal += acumEdad;
                                if (cantPersonas > 1)
                                {
                                    cantGrupos++;
                                }
                                break;
                            case "n":
                            case "N":
                                break;
                        }
                        Console.WriteLine("Presione una tecla para volver al menu principal");
                        break;

                    case 2:


                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nCompra de entrada pasaporte");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("\nIngrese cantidad de personas:");
                        grupo = Convert.ToInt32(Console.ReadLine());
                        cantMayoresGrupo = 0;
                        cantPer10y15 = 0;
                        acumEdad = 0;
                        recaudacionGrupoPasaporte = 0;
                        if (grupo < 4 || grupo > 10)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("EL GRUPO DEBE SER MINIMO DE 4 PERSONAS Y 10 DE MAXIMO");
                        }
                        else
                        {
                            for (int i = 1; i <= grupo; i++)
                            {
                                Console.Write("Ingrese edad N° {0}: ", i);
                                edad = Convert.ToInt32(Console.ReadLine());
                                acumEdad += edad;


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
                                    recaudacionGrupoPasaporte += (ticketMenores11 * 0.85);
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
                                    cantMayoresGrupo++;
                                    recaudacionGrupoPasaporte += (ticketMayores * 0.85);
                                }

                            }
                            if (cantMenores > 5)
                            {
                                if (cantMayoresGrupo >= 2)
                                {
                                    Console.WriteLine("\nEl valor del ticket es de: {0:c}", recaudacionGrupoPasaporte);
                                    Console.WriteLine("\nDesea confirmar la compra? [s/n]");
                                    teclaCompra = Console.ReadLine();
                                    while (teclaCompra != "s" && teclaCompra != "S" && teclaCompra != "n" && teclaCompra != "N")
                                    {
                                        Console.WriteLine("\nPor favor escriba S/s o N/n");
                                        teclaCompra = Console.ReadLine();
                                    }
                                    switch (teclaCompra)
                                    {
                                        case "s":
                                        case "S":
                                            recaudacionPasaporte += recaudacionGrupoPasaporte;
                                            cantPerPasaporte += grupo;
                                            acumEdadTotal += acumEdad;
                                            cantPer10y15Total += cantPer10y15;
                                            cantGrupos++;
                                            break;
                                        case "n":
                                        case "N":
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("NO HAY SUFICIENTES ADULTOS RESPONSABLES");
                                    cantMenores = 0;
                                    cantMayoresGrupo = 0;
                                }
                            }
                            else if (cantMenores <= 5)
                            {
                                if (cantMayoresGrupo >= 1)
                                {
                                    Console.WriteLine("\nEl valor del ticket es de: {0:c}", recaudacionGrupoPasaporte);
                                    Console.WriteLine("\nDesea confirmar la compra? [s/n]");
                                    teclaCompra = Console.ReadLine();
                                    while (teclaCompra != "s" && teclaCompra != "S" && teclaCompra != "n" && teclaCompra != "N")
                                    {
                                        Console.WriteLine("\nPor favor escriba S/s o N/n");
                                        teclaCompra = Console.ReadLine();
                                    }
                                    switch (teclaCompra)
                                    {
                                        case "s":
                                        case "S":
                                            recaudacionPasaporte += recaudacionGrupoPasaporte;
                                            cantPerPasaporte += grupo;
                                            acumEdadTotal += acumEdad;
                                            cantPer10y15Total += cantPer10y15;
                                            cantGrupos++;
                                            break;
                                        case "n":
                                        case "N":
                                            break;
                                    }
                                } else
                                {                                    
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("NO HAY SUFICIENTES ADULTOS RESPONSABLES");
                                    cantMenores = 0;
                                    cantMayoresGrupo = 0;
                                }
                            }
                        

                        }
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Presione una tecla para volver al menu principal");
                        break;

                    case 3:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\n\t\t\tTicket");
                        Console.ForegroundColor = ConsoleColor.Black;
                        cantPersonasTotal = cantPerIndividual + cantPerPasaporte;
                        if (cantPersonasTotal > 0)
                        {
                            recaudacionTotal = recaudacionPasaporte + recaudacionTicketTotal;
                            promedioEdadTotal = (double)acumEdadTotal / cantPersonasTotal;
                            Console.WriteLine("\nLa recaudacion total del dia es de:                {0,12:c}", recaudacionTotal);
                            Console.WriteLine("La recaudacion de los pasaportes es de:            {0,12:c}", recaudacionPasaporte);
                            Console.WriteLine("La recaudacion de tickets individuales es de:      {0,12:c}", recaudacionTicketTotal);
                            Console.WriteLine("\nCantidad de personas que asistieron:               {0,12}", cantPersonasTotal);
                            Console.WriteLine("Cantidad de grupos que asistieron:                 {0,12}", cantGrupos);
                            Console.WriteLine("Cantidad de personas entre 10 y 15 años:           {0,12}", cantPer10y15Total);
                            Console.WriteLine("Cantidad de personas que entraron con pasaporte:   {0,12}", cantPerPasaporte);
                            Console.WriteLine("El promedio de edad de todos los asistentes es de: {0,12:F3}", promedioEdadTotal);
                        }
                        else
                        {
                            Console.WriteLine("No asistio gente");
                        }
                        break;

                    case 4:
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tOPCION INVALIDA");
                        Console.Beep(500, 500);
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}