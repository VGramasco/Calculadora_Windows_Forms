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
    public partial class Soma : Form
    {

        private int soma;
        public Soma()
        {
            InitializeComponent();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                soma += numero;
                lblSoma.Text = $"Soma atual: {soma}";
                txtNumero.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido.");
            }
        }
    }
}