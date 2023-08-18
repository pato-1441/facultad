using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUBUTN
{
    public partial class RegistroLogueo : Form
    {
        public RegistroLogueo()
        {
            InitializeComponent();
        }

        private void RegistroLogueo_Load(object sender, EventArgs e)
        {

        }

        private void rbIngresar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIngresar.Checked )
            {
                tbDireccion.Enabled = false;
                tbNombre.Enabled = false;
            }
            else
            {
                tbDireccion.Enabled = true;
                tbNombre.Enabled = true;
            }
        }
    }
}
