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
        private int edad, puntaje = 0;

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

        public int Puntaje
        {
            get { return puntaje; } set { puntaje = value; } 
        }

        public Competidor(string nombre, int edad, string club)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.club = club;
        }
    }
}