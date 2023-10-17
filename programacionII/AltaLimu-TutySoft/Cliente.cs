using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AltaLimu_TutySoft
{
    internal class Cliente
    {
        long cuit;
        string nombre;
        string apellido;
        string nroSerie;            

        public string NroSerie
        {
            get { return nroSerie; }
            set
            {
                Regex regex = new Regex(@"^[A-Z0-9]+(?:-[A-Z0-9]+)*$");
                if (regex.IsMatch(value))
                    nroSerie = value;
                else
                    throw new Exception("Número de serie inválido");
            }
        }

        public string Apellido { get { return apellido; }
            set
            {
                Regex regex = new Regex(@"^[A-ZÁÉÍÓÚ\s]+$");
                if (regex.IsMatch(value))
                    apellido = value;
                else
                    throw new Exception("Apellido inválido");
            }
        }

        public string Nombre { get { return nombre; }
            set
            {
                Regex regex = new Regex(@"^[A-Z][a-z]*(\s[A-Z][a-z]*)*$");
                if (regex.IsMatch(value))
                    nombre = value;
                else
                    throw new Exception("Nombre inválido");
            }
        }

        public long Cuit { get { return cuit; }
            set {
                string cuitIngresado = Convert.ToString(value);
                Regex regex = new Regex(@"^\d{11}$");

                if (!regex.IsMatch(cuitIngresado))
                {
                    throw new Exception("CUIT no posee 11 dígitos.");
                }

                int[] factores = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
                int suma = 0;

                for (int i = 0; i < 10; i++)
                {
                    suma += Convert.ToInt32(cuitIngresado[i].ToString()) * factores[i];
                }

                int digitoVerificador = 11 - (suma % 11);
                if (digitoVerificador == 11)
                {
                    digitoVerificador = 0;
                }
                else if (digitoVerificador == 10)
                {
                    digitoVerificador = 9;
                }

                if (digitoVerificador == Convert.ToInt32(cuitIngresado[10].ToString()))
                    cuit = value;
                else
                    throw new Exception("CUIT Inválido.");
            }
        }
    }
}
