using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUBUTN
{
    internal class Sistema
    {
        int activo;
        Usuario[] usuarios = new Usuario[100];
        int cantUsuarios=0;
        static int tarjetasEmitidas = 0;
        
        public void AgregarUsuario(int dni, string direccion)
        {
            usuarios[cantUsuarios] = new Usuario(dni, direccion, tarjetasEmitidas);
            cantUsuarios++;
            tarjetasEmitidas++;
        }
        public Viaje[] VerViajes(int dni)
        {
            int i = 0;
            bool encontrado = false;
            while (i < usuarios.Length && encontrado==false)
            {
                if (usuarios[i].Dni == dni)
                {
                    encontrado = true;
                }
                i++;
            }

            Viaje[] viajesHechos = new Viaje[usuarios[i].Tarjeta.CantViajes];
            if (encontrado)
            {
                i--;
                int nro = usuarios[i].VerNroTarjeta();
                for (int j =0; j > usuarios[i].Tarjeta.CantViajes; j++)
                {
                    viajesHechos[j] = usuarios[i].Tarjeta.Viajes[usuarios[i].Tarjeta.Viajes.Length - (usuarios[i].Tarjeta.CantViajes-1) + j];
                }
                
            }
            return viajesHechos;
        }
    }
}
