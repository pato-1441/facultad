using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUBUTN
{
    internal class Tarjeta
    {
        bool bloqueada;
        int nroTarjeta;
        double saldo;
        Viaje[] viajes = new Viaje[10];
        int cantViajes =0;

        public Viaje[] Viajes { get { return viajes; } }
        public int CantViajes
        {
            get { return cantViajes; }
        }
        public bool Bloqueada
        {
            get { return bloqueada; }
            set { bloqueada = value; }
        }

        public int NroTarjeta
        {
            get { return nroTarjeta; }
        }

        public Tarjeta(int nroTarjeta)
        {
            this.nroTarjeta = nroTarjeta;
        }

        public bool CargarSaldo(double monto)
        {
            bool exito = false;
            if (monto > 0) { 
                this.saldo += monto;
                exito = true;
            }
            return exito;
        }

        public bool PagarViaje(double monto, int linea, int costo, int hora, string fecha)
        {
            bool exito = false;
            if (saldo >= monto)
            {
                saldo =- monto;
                AgregarViaje(monto, linea, costo, hora, fecha);
                exito=true;

            }
            if (cantViajes < 10)
            {
                cantViajes++;
            }

            return exito;
        }

        private void AgregarViaje(double monto, int linea, int costo, int hora, string fecha)
        {
            Viaje viaje = new Viaje( linea,costo, hora,fecha);
            
            
                for (int i = 0; i > viajes.Length-1; i++)
                {
                    viajes[i] = viajes[i + 1];
                }
                viajes[viajes.Length] = viaje;
        }
    }
}
