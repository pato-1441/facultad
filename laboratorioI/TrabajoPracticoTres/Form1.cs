using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPracticoTres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SistemaVehiculos sistema = new SistemaVehiculos();

        private void btnAñadirVehiculo_Click(object sender, EventArgs e)
        {
            ModalAñadirVehiculo modal = new ModalAñadirVehiculo();
            if (modal.ShowDialog() == DialogResult.OK)
            {
                if (modal.rbFurgon.Checked == true)
                {                    
                    sistema.AñadirVehiculo(Convert.ToInt32(modal.tbPatente.Text), 1, Convert.ToInt32(modal.tbCapacidadVehiculo.Text));
                    lbVehiculos.Items.Add(modal.tbPatente.Text);
                } else
                {
                    sistema.AñadirVehiculo(Convert.ToInt32(modal.tbPatente.Text), 2, Convert.ToInt32(modal.tbCapacidadVehiculo.Text));
                    lbVehiculos.Items.Add(modal.tbPatente.Text);
                }
            }
            modal.Dispose();
        }

        private void btnFinalizarPrograma_Click(object sender, EventArgs e)
        {
            ModalFinalizar modal = new ModalFinalizar();            
            int[] patentesMultadas = new int[sistema.CantVehiculosMultados];
            for(int i =0; i < sistema.CantVehiculosMultados; i++)
            {
                patentesMultadas[i] = sistema.VehiculosMultados[i].Patente;
            }
            sistema.OrdenarPatentes(patentesMultadas);
            for (int i = 0; i < sistema.CantVehiculosMultados; i++)
            {
                modal.lbVehiculosMultados.Items.Add(patentesMultadas[i].ToString());
            }
            modal.ShowDialog();
        }

        private void btnGenerarCobro_Click(object sender, EventArgs e)
        { 
            ModalGenerarCobro modal = new ModalGenerarCobro();
            if (modal.ShowDialog() == DialogResult.OK)
            {
                int seleccionado = lbVehiculos.SelectedIndex;
                sistema.AñadirPaquetes(Convert.ToInt32(lbVehiculos.SelectedIndex),
                                       Convert.ToInt32(modal.tbPaquetesA.Text),
                                       Convert.ToInt32(modal.tbPaquetesB.Text),
                                       Convert.ToInt32(modal.tbPaquetesC.Text));
                if (modal.rbSi.Checked)
                {
                    sistema.AñadirFechaPartida(Convert.ToInt32(lbVehiculos.SelectedIndex),
                                               Convert.ToInt32(modal.nudHoraPartida.Value),
                                               true,
                                               Convert.ToInt32(modal.nudDia.Value),
                                               Convert.ToInt32(modal.nudMes.Value),
                                               Convert.ToInt32(modal.nudAño.Value));
                } else
                {
                    sistema.AñadirFechaPartida(Convert.ToInt32(lbVehiculos.SelectedIndex),
                                               Convert.ToInt32(modal.nudHoraPartida.Value),
                                               false,
                                               Convert.ToInt32(modal.nudDia.Value),
                                               Convert.ToInt32(modal.nudMes.Value),
                                               Convert.ToInt32(modal.nudAño.Value));
                }
                sistema.GenerarCobro(sistema.Vehiculos[seleccionado]);

            }
        }
    }
}
