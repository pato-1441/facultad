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
        }
    }
}
