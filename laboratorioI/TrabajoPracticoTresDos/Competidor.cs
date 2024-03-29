﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoTresDos
{
    internal class Competidor
    {
        private string nombre, club;
        private int edad, cantTiros = 0, cantX = 0;
        private int[] puntaje;

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
        public int CantTiros
        {
            get { return cantTiros; }
        }
        public int CantX 
        { 
            get { return cantX; }
        }

        public Competidor(string nombre, int edad, string club)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.club = club;
            this.puntaje = new int[50];
        }

        public void SumarPuntaje(int puntos)
        {
            puntaje[cantTiros] = puntos;
            cantTiros++;
        }

        public void SumarPuntaje(int puntos, bool X)
        {
            puntaje[cantTiros] = puntos;
            cantTiros++;
            cantX++;
        }

        public int[] ObtenerTirosRonda(int ronda) {

            int[] tiros = new int[cantTiros];
            int inf = (ronda) * 5;
            int sup = (ronda+1) * 5;                        
            for(int i = inf,j=0; i < sup; i++,j++){
                tiros[j] = puntaje[inf];
			}
            return tiros;
		}
        public int ObtenerTotalRonda(int ronda) {

            int[] puntos = ObtenerTirosRonda(ronda);
            int total = 0;
            for(int n = 0; n < 5; n++) 
            {
                total += puntos[n];
            }
            return total;
        }

        public int ObtenerPuntajeTotal()
        {
            int total = 0;
            for(int i = 0; i < cantTiros; i++)
            {
                total += puntaje[i];
            }
            return total;
        }
    }
}
