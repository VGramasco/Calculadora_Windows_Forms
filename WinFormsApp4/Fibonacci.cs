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
    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
        }

        private void Fibonacci_Load(object sender, EventArgs e)
        {

        }

        private bool IsFibonacci(int num)
        {
            int numero = int.Parse(Numero.Text);
            int a = 0;
            int b = 1;

            if (numero == a || numero == b)
            {
                return true;
            }

            while (b < numero)
            {
                int temp = b;
                b = a + b;
                a = temp;

                if (b == numero)
                {
                    return true;
                }
            }

            return false;
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            int numero;

            if (int.TryParse(Numero.Text, out numero))
            {
                if (IsFibonacci(numero))
                {
                    MessageBox.Show($"{numero} pertence à sequência de Fibonacci.");
                }
                else
                {
                    MessageBox.Show($"{numero} não pertence à sequência de Fibonacci.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um número inteiro válido.");
            }
        }

       
    }
}