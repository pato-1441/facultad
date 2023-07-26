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
                MessageBox.Show("Cantidad de competidores menores: " + torneo.CantMenores.ToString() + ", " +
                                "Cantidad de competidores mayores: " + torneo.CantMayores.ToString());
            }
        }

        private void btnComenzarTorneo_Click(object sender, EventArgs e)
        {
            ModalTorneo modal = new ModalTorneo();
            if (torneo.CantCompetidores >= 3)
            {
                for (int i = 0; i < torneo.CantRondas; i++)
                {
                    modal.lRonda.Text = "Ronda N° " + (i + 1);
                    for (int j = 0; j < torneo.CantCompetidores; j++)
                    {
                        modal.tbNombreCompetidor.Text = torneo.Competidores[j].Nombre;
                        for (int k = 0; k < 5; k++)
                        {
                            modal.lNumeroTiro.Text = "Tiro N° " + (k + 1);
                            if (modal.ShowDialog() == DialogResult.OK)
                            {
                                if (modal.cbCentro.Checked)
                                {
                                    torneo.Competidores[j].SumarPuntaje(10, true);
                                }
                                else
                                {
                                    torneo.Competidores[j].SumarPuntaje(Convert.ToInt32(modal.nudPuntaje.Value));
                                }
                            }
                        }
                    }
                    ModalGanadorRonda modalRonda = new ModalGanadorRonda();
                    modalRonda.gbRonda.Text = "Resultados Ronda N° " + (i + 1);
                    torneo.OrdenarCompetidores();
                    modalRonda.lNombre1ro.Text = torneo.Competidores[0].Nombre;
                    modalRonda.lPuntaje1ro.Text = torneo.Competidores[0].ObtenerPuntajeTotal().ToString();
                    modalRonda.lCantCentros1ro.Text = torneo.Competidores[0].CantX.ToString();

                    modalRonda.lNombre2do.Text = torneo.Competidores[1].Nombre;
                    modalRonda.lPuntaje2do.Text = torneo.Competidores[1].ObtenerPuntajeTotal().ToString();
                    modalRonda.lCantCentros2do.Text = torneo.Competidores[1].CantX.ToString();

                    modalRonda.lNombre3ero.Text = torneo.Competidores[2].Nombre;
                    modalRonda.lPuntaje3ro.Text = torneo.Competidores[2].ObtenerPuntajeTotal().ToString();
                    modalRonda.lCantCentros3ro.Text = torneo.Competidores[2].CantX.ToString();
                    modalRonda.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Minimo 3 competidores.");
            }
            lbCompetidores.Items.Clear();
            for(int i = 0; i< torneo.CantCompetidores; i++)
            {
                lbCompetidores.Items.Add(torneo.Competidores[i].Nombre);
            }
            modal.Dispose();
        }

        private void btnVerResultados_Click(object sender, EventArgs e)
        {
            int indice = lbCompetidores.SelectedIndex;
            string fila;
            ModalResultados modal = new ModalResultados();
            if (indice != -1)
            {                
                for(int j = 0; j < torneo.CantRondas; j++) {
                    int[] tiros = torneo.Competidores[indice].ObtenerTirosRonda(j);
                    fila = "";
                    for(int i = 0; i < 5; i++) {
                        fila += tiros[i].ToString("00") + " ";
                    }
                    fila += torneo.Competidores[indice].ObtenerTotalRonda(j);
                    modal.lbResultados.Items.Add(fila);
                }
                modal.lCompetidorNombre.Text = torneo.Competidores[indice].Nombre; 
                modal.lbResultados.Items.Add("Total: " + torneo.Competidores[indice].ObtenerPuntajeTotal().ToString());
                modal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un competidor.");
            }
            modal.Dispose();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
