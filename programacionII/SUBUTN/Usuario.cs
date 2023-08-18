using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUBUTN
{
    internal class Usuario
    {
        int dni;
        string direccion;
        Tarjeta tarjeta;

        public Tarjeta Tarjeta
        {
            get { return tarjeta; }
        }
        public int Dni
        {
            get { return dni; }
            private set { dni = value; }
        }

        public string Direccion 
        { 
            get { return direccion; } 
            set { direccion = value; }
        }

        public Usuario(int dni, string direccion,int tarjetasEmitidas)
        {
            this.dni = dni;
            this.tarjeta = new Tarjeta(tarjetasEmitidas);
            this.direccion = direccion;            
        }

        public bool BloquearTarjeta()
        {
            tarjeta.Bloqueada = !tarjeta.Bloqueada;
            return tarjeta.Bloqueada;
        }

        public int VerNroTarjeta()
        {
            return tarjeta.NroTarjeta;
        }
    }
}
