using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_Lacamoire_Ferrocarril
{
    public partial class frmFerrocarril : Form
    {
        public frmFerrocarril()
        {
            InitializeComponent();
        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {
            if (txtDistancia.Text != "")
            {
                cmdCalcular.Enabled = true;
            }
            else
            {
                cmdCalcular.Enabled = false;
            }
        }

        private void txtDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDistancia.Clear();
                e.Handled = true;
                return;

                
            }
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            // Obtiener distancia ida y vuelta

            int Dias;
            Dias = int.Parse(numericudDias.Text);
            int km;
            km = int.Parse(txtDistancia.Text);
            int Precio;
            Precio = int.Parse(txtDistancia.Text) * 5;





            if (km >= 100 && Dias >= 7)
            {
                Precio = Precio / 2;
                MessageBox.Show("Total = $ " + Precio.ToString());
            }
            else
            {
                MessageBox.Show("Total = $ " + Precio.ToString());
            }



            

        }

        private void frmFerrocarril_Load(object sender, EventArgs e)
        {
            
            
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void lblFerrocarrilFerro_Click(object sender, EventArgs e)
        {

        }
    }
}
