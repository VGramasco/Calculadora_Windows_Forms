using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Fatorial : Form
    {
        public Fatorial()
        {
            InitializeComponent();
        }

        private void Fatorial_Load(object sender, EventArgs e)
        {

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            BigInteger numero;

            if (BigInteger.TryParse(txtNumero.Text, out numero))
            {
                listBoxResult.Items.Clear();
                listBoxResult.Items.Add($"A sequência fatorial até {numero} é:");

                for (BigInteger i = 0; i <= numero; i++)
                {
                    listBoxResult.Items.Add($"{i}! = {Fatorialn(i)}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um número inteiro válido.");
            }
        }

        private BigInteger Fatorialn(BigInteger n)
        {
            if (n == 0)
                return 1;
            else
                return n * Fatorialn(n - 1);
        }
    }
}