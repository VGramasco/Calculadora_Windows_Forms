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
    public partial class NumeroP : Form
    {
        public NumeroP()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                if (EhNumeroPerfeito(numero))
                {
                    MessageBox.Show($"{numero} é um número perfeito.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{numero} não é um número perfeito.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um número inteiro válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EhNumeroPerfeito(int numero)
        {
            int soma = 0;
            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    soma += i;
                }
            }
            return soma == numero;
        }
    }
}