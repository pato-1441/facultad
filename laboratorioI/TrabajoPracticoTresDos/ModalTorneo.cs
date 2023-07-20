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
    public partial class ModalTorneo : Form
    {
        public ModalTorneo()
        {
            InitializeComponent();
        }

        private void cbCentro_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCentro.Checked)
            {
                nudPuntaje.Value = 10;
                nudPuntaje.Enabled = false;
            } else
            {
                nudPuntaje.Value = 0;
                nudPuntaje.Enabled = true;
            }
        }
    }
}
