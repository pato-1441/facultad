using System;
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
                    lbVehiculos.Items.Add(Convert.ToInt32(modal.tbPatente.Text).ToString("000"));
                } else
                {
                    sistema.AñadirVehiculo(Convert.ToInt32(modal.tbPatente.Text), 2, Convert.ToInt32(modal.tbCapacidadVehiculo.Text));
                    lbVehiculos.Items.Add(Convert.ToInt32(modal.tbPatente.Text).ToString("000"));
                }
            }
            modal.Dispose();
        }

        private void btnFinalizarPrograma_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            ModalFinalizar modal = new ModalFinalizar();
            int[] patentesMultadas = new int[sistema.CantVehiculosMultados];
            for (int i = 0; i < sistema.CantVehiculosMultados; i++)
            {
                patentesMultadas[i] = sistema.VehiculosMultados[i].Patente;
            }
            sistema.OrdenarPatentes(patentesMultadas);
            for (int i = 0; i < sistema.CantVehiculosMultados; i++)
            {
                modal.lbVehiculosMultados.Items.Add(patentesMultadas[i].ToString("000"));
            }
            while (bandera == false)
            {                
                if (modal.ShowDialog() == DialogResult.Yes )
                {
                    if (modal.lbVehiculosMultados.SelectedIndex != -1)
                    {
                        ModalConsultarDatos modalDatos = new ModalConsultarDatos();
                        int posicion = sistema.BuscarVehiculo(sistema.VehiculosMultados, Convert.ToInt32(modal.lbVehiculosMultados.SelectedItem));
                        modalDatos.tbFechaRegistro.Text = sistema.VehiculosMultados[posicion].Dia.ToString() +"/"+
                                                            sistema.VehiculosMultados[posicion].Mes.ToString() + "/" +
                                                            sistema.VehiculosMultados[posicion].Año.ToString();
                        if (sistema.Vehiculos[posicion].TipoVehiculo == 1)
                        {
                            modalDatos.tbTipoVehiculo.Text = "Furgón";
                        } else
                        {
                            modalDatos.tbTipoVehiculo.Text = "Camión";
                        }
                        modalDatos.tbCostoAbonado.Text = "$" + sistema.Vehiculos[posicion].Abonado.ToString();
                        if(modalDatos.ShowDialog() == DialogResult.Cancel)
                        {
                            modalDatos.Dispose();
                        }
                    } else
                    {                        
                        MessageBox.Show("Seleccione un vehiculo por favor.");
                    }
                } else if (modal.DialogResult == DialogResult.Cancel)
                {
                    bandera = true;
                    modal.Dispose();
                }
            }
        }
        private void btnGenerarCobro_Click(object sender, EventArgs e)
        { 
            ModalGenerarCobro modal = new ModalGenerarCobro();
            int seleccionado = lbVehiculos.SelectedIndex;
            if (seleccionado != -1)
            {
                if (sistema.Vehiculos[seleccionado].TipoVehiculo == 1)
                {
                    modal.nudHoraPartida.Enabled = false;    
                } else
                {
                    modal.nudHoraPartida.Enabled = true;
                }
                if (modal.ShowDialog() == DialogResult.OK)
                {                
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
            else
            {
                MessageBox.Show("Seleccione un vehiculo por favor.");
            }
            modal.Dispose();
        }
    }
}
