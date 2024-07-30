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
    public partial class Primo : Form
    {
        public Primo()
        {
            InitializeComponent();
        }

        private void btnVerificarPrimo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                bool ehPrimo = EhPrimo(numero);
                if (ehPrimo)
                {
                    MessageBox.Show($"{numero} é um número primo.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{numero} não é um número primo.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um número inteiro válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EhPrimo(int numero)
        {
            if (numero <= 1) return false;
            if (numero == 2) return true;
            if (numero % 2 == 0) return false;

            var limite = (int)Math.Sqrt(numero);
            for (int i = 3; i <= limite; i += 2)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }
    }
}