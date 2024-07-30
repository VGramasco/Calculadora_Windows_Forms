using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class mmc : Form
    {
        public mmc()
        {
            InitializeComponent();
        }

        private void btnCalcularMMC_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero1.Text, out int numero1) && int.TryParse(txtNumero2.Text, out int numero2))
            {
                int mmc = CalcularMMC(numero1, numero2);
                MessageBox.Show($"O MMC de {numero1} e {numero2} é: {mmc}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, insira números inteiros válidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int CalcularMMC(int a, int b)
        {
            return (a / CalcularMDC(a, b)) * b;
        }

        private int CalcularMDC(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}