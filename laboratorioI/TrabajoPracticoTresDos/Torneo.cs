using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoTresDos
{
    internal class Torneo
    {
        private Competidor[] competidores;
        private int cantCompetidores = 0, cantMenores = 0, cantRondas;
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

        public int CantRondas
        {
            get { return cantRondas; }
        }

        public Torneo(int cantCompetidores)
        {
            this.competidores = new Competidor[cantCompetidores];
            Random random = new Random();
            int rondas = random.Next(5, 10);
            this.cantRondas = rondas;
            this.cantRondas = 2;
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

        public void OrdenarCompetidores()
        {
            for(int i = 0; i < cantCompetidores - 1; i++)
            {
                for(int j = i+1; j < cantCompetidores; j++)
                {
                    if (competidores[i].ObtenerPuntajeTotal() < competidores[j].ObtenerPuntajeTotal())
                    {
                        Competidor aux = competidores[i];
                        competidores[i] = competidores[j];
                        competidores[j] = aux;                        
                    } else if (competidores[i].ObtenerPuntajeTotal() == competidores[j].ObtenerPuntajeTotal())
                    {
                        if (competidores[i].CantX < competidores[j].CantX)
                        {
                            Competidor aux = competidores[i];
                            competidores[i] = competidores[j];
                            competidores[j] = aux;
                        }
                    }
                }
            }
        }
    }
}
