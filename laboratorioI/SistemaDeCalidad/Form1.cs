using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeCalidad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ClassSistemaDeCalidad sistema = new ClassSistemaDeCalidad();
        private void btnEncuestar_Click(object sender, EventArgs e)
        {

            ModalEncuesta modal = new ModalEncuesta();
            if (modal.ShowDialog() == DialogResult.OK)
            {
                int calidad = 0;
                string email = "";
                if (modal.rbMalo.Checked == true)
                {
                    calidad = 0;
                }
                else
                {
                    calidad = 1;
                }
                if (modal.tbEmail.Text != "") email = modal.tbEmail.Text;
                sistema.RegistrarCalidad(calidad, email);
            }
            lbInsatisfechos.Items.Clear();
            lbInsatisfechos.Items.Add("Porcentaje: %" + sistema.PorcInsatisfechos.ToString("0.00"));
        }

        private void btnVerInsatisfechos_Click(object sender, EventArgs e)
        {
            ModalInstatisfechos modal = new ModalInstatisfechos();
            for (int i = 0; i < sistema.Cantidad; i++)
            {
                modal.lbEmails.Items.Add(sistema.VerInsatisfecho(i));
            }
            modal.ShowDialog();
        }
    }
}
