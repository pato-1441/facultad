using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contBat = 0, batBuenas = 0, contBatDes = 0, batMayorErr = 0, totalBatDes = 0;
            double voltaje, voltajeBat, difMayorError = 0, voltajeError;


            //Arranca lote
            for (int lote = 1; lote < 3; lote++)
            {
                Console.WriteLine("Lote n° {0}", lote);

                Console.WriteLine("Ingrese voltaje al vacio deseado: ");
                voltaje = Convert.ToDouble(Console.ReadLine());

                //Arranca ingreso de lotes
                Console.WriteLine("Ingrese voltaje de la bateria (ingrese -1 para finalizar ingreso)");
                voltajeBat = Convert.ToDouble(Console.ReadLine());

                while (voltajeBat != -1)
                {
                    //Verificar error de voltaje ingresado
                    if (voltajeBat < voltaje)
                    {
                        voltajeError = voltaje - voltajeBat;
                        Console.WriteLine("El error de la bateria es de: {0}v.", voltajeError);

                        //Verificar mayor error de voltaje ingresado
                        if (voltajeError > difMayorError)
                        {
                            batMayorErr = contBat;
                            difMayorError = voltajeError;
                        }

                        //Incrementar contador bat. descartadas
                        contBatDes++;
                        totalBatDes++;
                    }

                    Console.WriteLine("Ingrese voltaje de la bateria (ingrese -1 para finalizar ingreso)");
                    voltajeBat = Convert.ToDouble(Console.ReadLine());
                    contBat++;
                };
                batBuenas = contBat - contBatDes;
                Console.WriteLine("Cantidad de baterias buenas: {0}", batBuenas);
            }

            Console.WriteLine("Total de baterias descartadas: {0}", totalBatDes);
            Console.WriteLine("Bateria con mayor error descartada: n° {0}, Error: {1}v.", batMayorErr, difMayorError);
            Console.ReadKey();
        }
        }
    }

