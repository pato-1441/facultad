﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoTres
{
    internal class SistemaVehiculos
    {
        Vehiculo[] vehiculos;
        Vehiculo[] vehiculosMultados;
        int cantVehiculos = 0, cantVehiculosMultados = 0;
        double costoBase = 2.54;

        public int CantVehiculos
        {
            get { return cantVehiculos; }
        }

        public int CantVehiculosMultados
        {
            get { return cantVehiculosMultados; }
        }
        public Vehiculo[] Vehiculos{ 
            get { return vehiculos; }
        }
        public Vehiculo[] VehiculosMultados
        {
            get { return vehiculosMultados; }
        }
        public SistemaVehiculos()
        {
            vehiculos = new Vehiculo[50];
            vehiculosMultados = new Vehiculo[20];
        }
        public void OrdenarPatentes(int[] patentes)
        {
            int aux;
            for(int i = 0; i < patentes.Length - 1; i++)
            {
                for(int j = i+1; j < patentes.Length; j++)
                {
                    if (patentes[i] > patentes[j])
                    {
                        aux = patentes[i];
                        patentes[i] = patentes[j];
                        patentes[j] = aux;
                    }
                }
            }
        }

        public int BuscarVehiculo(Vehiculo[] vehiculos, int patente)
        {
            int longitud = vehiculos.Length;
            int posicion = -1;
            int contador = 0;
            while (contador < longitud && posicion == -1)
            {
                if (vehiculos[contador].Patente == patente)
                {
                    posicion = contador;
                }
                contador++;
            }
            return posicion;
        }
        public void AñadirVehiculo(int patente, int tipoVehiculo, int capacidad) 
        {
            Vehiculo vehiculo = new Vehiculo(patente, tipoVehiculo, capacidad);
            vehiculos[cantVehiculos] = vehiculo;
            cantVehiculos++;
        }
        public void AñadirPaquetes(int indice, int cantPaqA, int cantPaqB, int cantPaqC)
        {
            vehiculos[indice].CantPaqTipoA = cantPaqA;
            vehiculos[indice].CantPaqTipoB = cantPaqB;
            vehiculos[indice].CantPaqTipoC = cantPaqC;
        }

        public void AñadirFechaPartida(int indice, int horaPartida, bool domingoOFeriado,
                                       int dia, int mes, int año)
        {
            vehiculos[indice].HoraPartida = horaPartida;
            vehiculos[indice].DomingoOFeriado = domingoOFeriado;
            vehiculos[indice].Dia = dia;
            vehiculos[indice].Mes = mes;
            vehiculos[indice].Año = año;
        }
        public double GenerarCobro(Vehiculo vehiculo)
        {
            double total = 0;
            int diferenciaPeso = vehiculo.TotalKilogramos - vehiculo.CapacidadCarga;

            if (diferenciaPeso<-150)
            {
                total = (costoBase * vehiculo.TotalKilogramos)*1.10;
            } else if (diferenciaPeso>-150 && diferenciaPeso<-10)
            {
                total = (costoBase * vehiculo.TotalKilogramos) * 1.10;
            } else if (diferenciaPeso>-10 && diferenciaPeso<10)
            {
                total = (costoBase * vehiculo.TotalKilogramos) * 0.95;
            } else if (diferenciaPeso > 10 && diferenciaPeso < 50)
            {
                total = (costoBase * vehiculo.TotalKilogramos) * 1.18;
            } else if (diferenciaPeso > 50)
            {
                total = (costoBase * vehiculo.TotalKilogramos) * 1.50;
                vehiculosMultados[cantVehiculosMultados] = vehiculo;
                cantVehiculosMultados++;
            }

            if (vehiculo.TipoVehiculo == 2)
            {
                if (vehiculo.HoraPartida > 6 && vehiculo.HoraPartida < 20)
                {
                    total *= 0.98;
                } else
                {
                    total *= 1.08;
                }
            }

            if (vehiculo.DomingoOFeriado == true)
                total += 3500;

            vehiculo.GuardarCobro(total);
            return total;
        }
    }
}
