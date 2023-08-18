using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUBUTN
{
    internal class Viaje
    {
        int linea, costo, hora;
        string fecha;

        public int Linea { get { return linea;}}
        public int Costo { get { return costo;}}
        public int Hora { get { return hora;}}
        public string Fecha { get { return fecha;}}


        public Viaje(int linea, int costo, int hora, string fecha)
        {
            this.linea = linea;
            this.costo = costo;
            this.hora = hora;
            this.fecha = fecha;
        }
    }
}
