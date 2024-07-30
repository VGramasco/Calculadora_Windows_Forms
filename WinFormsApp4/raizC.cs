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
    public partial class raizC : Form
    {
        public raizC()
        {
            InitializeComponent();
        }

        private void btnCalcularRaizCubica_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero.Text, out double numero))
            {
                // Calcula a raiz cúbica
                double raizCubica = Math.Pow(numero, 1.0 / 3.0);

                // Exibe o resultado
                lblResultado.Text = $"A raiz cúbica de {numero} é: {raizCubica}";
            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
