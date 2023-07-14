using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoTres
{
    internal class Vehiculo
    {
        private int patente, tipoVehiculo, capacidadCarga, horaPartida,
                    cantPaqTipoA, cantPaqTipoB, cantPaqTipoC, dia, mes, año;
        private double abonado;
        private bool domingoOFeriado;
        public int Patente
        {
            get { return patente; }
        }

        public int TipoVehiculo
        {
            get { return tipoVehiculo; }
        }

        public int CapacidadCarga
        {
            get { return capacidadCarga; }
        }

        public int CantPaqTipoA
        {
            get { return  cantPaqTipoA; }
        }
        public int CantPaqTipoB
        {
            get { return cantPaqTipoB; }
        }
        public int CantPaqTipoC
        {
            get { return cantPaqTipoC; }
        }

        public int HoraPartida
        {
            get { return horaPartida; }
        }

        public int TotalKilogramos
        {
            get { return (CantPaqTipoA * 5) + (CantPaqTipoB * 15) + (CantPaqTipoC * 30); }
        }

        public double Abonado
        {
            get { return abonado;}
        }

        public int Dia
        {
            get { return dia; }
        }
        public int Mes
        {
            get { return mes; }
        }
        public int Año
        {
            get { return año; }
        }

        public bool DomingoOFeriado
        {
            get { return domingoOFeriado;}
        }

        public Vehiculo(int patente, int tipoVehiculo, int capacidadCarga, int cantPaqTipoA,
                        int cantPaqTipoB, int cantPaqTipoC, int horaPartida, double abonado,
                        int dia, int mes, int año, bool domingoOFeriado)
        {
            this.patente  = patente;
            this.tipoVehiculo = tipoVehiculo;
            this.capacidadCarga = capacidadCarga;
            this.cantPaqTipoA = cantPaqTipoA;
            this.cantPaqTipoB = cantPaqTipoB;
            this.cantPaqTipoC = cantPaqTipoC;
            this.horaPartida = horaPartida;
            this.abonado = abonado;
            this.dia = dia;
            this.mes = mes;
            this.año = año;
            this.domingoOFeriado= domingoOFeriado;
        }
        public void GuardarCobro(double total)
        {
            abonado = total;
        }
    }
}
