using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPracticoTresDos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Torneo torneo = new Torneo(10);
        private int contadorCompetidores = 0;
        private void btnCargarCompetidor_Click(object sender, EventArgs e)
        {
            ModalCargarCompetidor modal = new ModalCargarCompetidor();
            if (modal.ShowDialog() == DialogResult.OK)
            {
                if (contadorCompetidores < torneo.Competidores.Length)
                {
                    torneo.AñadirCompetidor(modal.tbNombre.Text,
                                            Convert.ToInt32(modal.nudEdad.Value),
                                            modal.tbClub.Text);
                    lbCompetidores.Items.Add(modal.tbNombre.Text);
                    contadorCompetidores++;
                }
                else
                {
                    MessageBox.Show("Máximo de competidores alcanzado.");
                }
            }
            if (contadorCompetidores == 10)
            {
                MessageBox.Show("Cantidad de competidores menores: " + torneo.CantMenores.ToString()+", "+
                                "Cantidad de competidores mayores: " + torneo.CantMayores.ToString());
            }
        }

        private void btnComenzarTorneo_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            //int rondas = random.Next(5, 10);
            int rondas = 1;
            ModalTorneo modal = new ModalTorneo();
            for (int i = 0; i < rondas; i++)
            {
                modal.lRonda.Text = "Ronda N° " + (i+1);
                for(int j = 0; j < torneo.CantCompetidores; j++)
                {
                    modal.tbNombreCompetidor.Text = torneo.Competidores[j].Nombre;
                    for(int k = 0; k < 5; k++)
                    {
                        modal.lNumeroTiro.Text = "Tiro N° " + (k+1);
                        if (modal.ShowDialog() == DialogResult.OK)
                        {
                            torneo.Competidores[j].SumarPuntaje(Convert.ToInt32(modal.nudPuntaje.Value));
                            //torneo.SumarPuntaje(i,Convert.ToInt32(modal.nudPuntaje.Value));
                        }
                    }
                }
                ModalGanadorRonda modalRonda = new ModalGanadorRonda();
                modalRonda.gbRonda.Text = "Resultados Ronda N° " + (i + 1);
                int indiceGanador = torneo.ObtenerGanadorRonda();
                modalRonda.lNombre1ro.Text = torneo.Competidores[indiceGanador].Nombre;
                modalRonda.lNombre2do.Text = "";
                modalRonda.lNombre3ero.Text = "";
            }
        }
    }
}
