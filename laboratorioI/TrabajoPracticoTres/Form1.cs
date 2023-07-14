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
            while (modal.ShowDialog() == DialogResult.OK)
            {
                if (modal.rbFurgon.Checked == true)
                {
                    if (modal.rbSi.Checked == true)
                    {
                        Vehiculo vehiculo = new Vehiculo(Convert.ToInt32(modal.tbPatente.Text), 1, Convert.ToInt32(modal.tbCapacidadVehiculo.Text),
                                                        Convert.ToInt32(modal.tbPaquetesTipoA.Text), Convert.ToInt32(modal.tbPaquetesTipoB.Text),
                                                        Convert.ToInt32(modal.tbPaquetesTipoC.Text), Convert.ToInt32(modal.nudHoraPartida.Value),
                                                        0, Convert.ToInt32(modal.nudDia.Value), Convert.ToInt32(modal.nudMes.Value),
                                                        Convert.ToInt32(modal.nudAño.Value), true);
                        sistema.GenerarCobro(vehiculo);
                    }
                    else if (modal.rbSi.Checked == false)
                    {
                        Vehiculo vehiculo = new Vehiculo(Convert.ToInt32(modal.tbPatente.Text), 1, Convert.ToInt32(modal.tbCapacidadVehiculo.Text),
                                                        Convert.ToInt32(modal.tbPaquetesTipoA.Text), Convert.ToInt32(modal.tbPaquetesTipoB.Text),
                                                        Convert.ToInt32(modal.tbPaquetesTipoC.Text), Convert.ToInt32(modal.nudHoraPartida.Value),
                                                        0, Convert.ToInt32(modal.nudDia.Value), Convert.ToInt32(modal.nudMes.Value),
                                                        Convert.ToInt32(modal.nudAño.Value), false);
                        sistema.GenerarCobro(vehiculo);
                    }
                }
                else if (modal.rbCamion.Checked == true)
                {
                    if (modal.rbSi.Checked == true)
                    {
                        Vehiculo vehiculo = new Vehiculo(Convert.ToInt32(modal.tbPatente.Text), 2, Convert.ToInt32(modal.tbCapacidadVehiculo.Text),
                                                        Convert.ToInt32(modal.tbPaquetesTipoA.Text), Convert.ToInt32(modal.tbPaquetesTipoB.Text),
                                                        Convert.ToInt32(modal.tbPaquetesTipoC.Text), Convert.ToInt32(modal.nudHoraPartida.Value),
                                                        0, Convert.ToInt32(modal.nudDia.Value), Convert.ToInt32(modal.nudMes.Value),
                                                        Convert.ToInt32(modal.nudAño.Value), true);
                        sistema.GenerarCobro(vehiculo);
                    }
                    else if (modal.rbSi.Checked == false)
                    {
                        Vehiculo vehiculo = new Vehiculo(Convert.ToInt32(modal.tbPatente.Text), 2, Convert.ToInt32(modal.tbCapacidadVehiculo.Text),
                                                        Convert.ToInt32(modal.tbPaquetesTipoA.Text), Convert.ToInt32(modal.tbPaquetesTipoB.Text),
                                                        Convert.ToInt32(modal.tbPaquetesTipoC.Text), Convert.ToInt32(modal.nudHoraPartida.Value),
                                                        0, Convert.ToInt32(modal.nudDia.Value), Convert.ToInt32(modal.nudMes.Value),
                                                        Convert.ToInt32(modal.nudAño.Value), false);
                        sistema.GenerarCobro(vehiculo);
                    }
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
    }
}
