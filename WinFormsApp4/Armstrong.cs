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
    public partial class Armstrong : Form
    {
        public Armstrong()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                if (IsArmstrong(numero))
                {
                    MessageBox.Show($"{numero} pertence à família de Armstrong.");
                }
                else
                {
                    MessageBox.Show($"{numero} não pertence à família de Armstrong.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um número inteiro válido.");
            }
        }

        private bool IsArmstrong(int num)
        {
            int totalDigitos = CountDigits(num);
            int soma = 0;
            int numeroOriginal = num;

            while (num != 0)
            {
                int digito = num % 10;
                soma += (int)Math.Pow(digito, totalDigitos);
                num /= 10;
            }

            return soma == numeroOriginal;
        }

        private int CountDigits(int num)
        {
            int contador = 0;
            while (num != 0)
            {
                num /= 10;
                contador++;
            }
            return contador;
        }
    }
}