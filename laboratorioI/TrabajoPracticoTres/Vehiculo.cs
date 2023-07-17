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
            get { return  cantPaqTipoA; } set { cantPaqTipoA = value; }
        }
        public int CantPaqTipoB
        {
            get { return cantPaqTipoB; } set { cantPaqTipoB = value; }
        }
        public int CantPaqTipoC
        {
            get { return cantPaqTipoC; } set { cantPaqTipoC = value; }
        }

        public int HoraPartida
        {
            get { return horaPartida; } set { horaPartida = value; }
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
            get { return dia; } set { dia = value; }
        }
        public int Mes
        {
            get { return mes; } set { mes = value; }
        }
        public int Año
        {
            get { return año; } set { año = value; }
        }

        public bool DomingoOFeriado
        {
            get { return domingoOFeriado; } set {  domingoOFeriado = value;}
        }

        public Vehiculo(int patente, int tipoVehiculo, int capacidadCarga)
        {
            this.patente  = patente;
            this.tipoVehiculo = tipoVehiculo;
            this.capacidadCarga = capacidadCarga;
            this.cantPaqTipoA = 0;
            this.cantPaqTipoB = 0;
            this.cantPaqTipoC = 0;
            /*
            this.horaPartida = horaPartida;
            this.abonado = abonado;
            this.dia = dia;
            this.mes = mes;
            this.año = año;
            this.domingoOFeriado= domingoOFeriado;
            */
        }
        public void GuardarCobro(double total)
        {
            abonado = total;
        }
    }
}
