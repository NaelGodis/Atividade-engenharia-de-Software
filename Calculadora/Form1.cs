using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textNr2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btdividir_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (float.Parse(txtNr1.Text) / (float.Parse(txtNr2))toString();
        }

        private void btSomar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (float.Parse(txtNr1.Text) + (float.Parse(txtNr2))toString();
        }
        private void btSubtrair_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (float.Parse(txtNr1.Text) - (float.Parse(txtNr2))toString();
        }


        private void btMultiplicar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (float.Parse(txtNr1.Text) * (float.Parse(txtNr2))toString();
        }

        private void textNr1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
