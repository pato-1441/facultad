using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCalidad
{
    internal class ClassSistemaDeCalidad
    {
        string[] insatisfechos;
        int cantidad = 0;
        int cantidadTotal = 0;
        public double PorcInsatisfechos
        {
            get
            {
                double porc = 0;
                if (cantidadTotal > 0) porc = (double)cantidad / cantidadTotal;
                return porc * 100;
            }
        }
        public int Cantidad
        {
            get { return cantidad; }
        }

        public ClassSistemaDeCalidad()
        {
            insatisfechos = new string[100];
        }

        public void RegistrarCalidad(int calidad, string email)
        {
            if (calidad == 0)
            {
                insatisfechos[cantidad] = email;
                cantidad++;
            }
            cantidadTotal++;
        }

        public string VerInsatisfecho(int idx)
        {
            string insatisfecho = null;
            if (insatisfechos[idx] != null) insatisfecho = insatisfechos[idx];
            return insatisfecho;
        }
    }
}
