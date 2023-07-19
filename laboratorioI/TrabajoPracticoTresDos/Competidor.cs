using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoTresDos
{
    internal class Competidor
    {
        private string nombre, club;
        private int edad;
        private int[] puntaje;
        private int cantTiros=0;

        public string Nombre
        {
            get { return nombre; }
        }

        public string Club
        {
            get { return club;}
        }

        public int Edad
        {
            get { return edad; }    
        }

        public int[] Puntaje
        {
            get { return puntaje; }
        }

        public Competidor(string nombre, int edad, string club)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.club = club;
            this.puntaje = new int[5];
        }

        public void SumarPuntaje(int puntos)
        {
            puntaje[cantTiros] = puntos;
            cantTiros++;
        }

        public int ObtenerPuntajeTotal()
        {
            int total = 0;
            for(int i = 0; i < cantTiros-1; i++)
            {
                total += puntaje[cantTiros];
            }
            return total;
        }
    }
}
