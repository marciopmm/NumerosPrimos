using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosPrimos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            int meio = numero / 2;
            bool naoPrimo = false;

            while (naoPrimo || meio > 1)
            {
                if (numero % meio == 0)
                {
                    naoPrimo = true;
                    break;
                }
                else
                {
                    meio = meio / 2;
                }
            }

            if (naoPrimo)
                MessageBox.Show("O número não é primo. " + numero.ToString() + " é divisível por " + meio.ToString() + ".", "Primo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("O número é primo.", "Primo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
