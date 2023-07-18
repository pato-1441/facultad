using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoTresDos
{
    internal class Torneo
    {
        private Competidor[] competidores;
        private int cantCompetidores = 0, cantMenores = 0;

        public Competidor[] Competidores
        {
            get { return competidores; }
        }

        public int CantCompetidores
        {
            get { return cantCompetidores; }
        }
        public int CantMenores
        {
            get { return cantMenores; }
        }

        public int CantMayores
        {
            get { return cantCompetidores - cantMenores; }
        }

        public Torneo(int cantCompetidores)
        {
            this.competidores = new Competidor[cantCompetidores];
        }

        public void AñadirCompetidor(string nombre, int edad, string club)
        {
            if (edad < 18)
            {
                cantMenores++;
            }
            if (cantCompetidores < Competidores.Length)
            {
                Competidor competidor = new Competidor(nombre, edad, club);
                competidores[cantCompetidores] = competidor;
                cantCompetidores++;
            }
        }
        public void SumarPuntaje(int indiceCompetidor,int puntajeRealizado)
        {
            competidores[indiceCompetidor].Puntaje += puntajeRealizado;
        }
    }
}
