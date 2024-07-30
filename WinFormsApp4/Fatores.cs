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
    public partial class Fatores : Form
    {
        public Fatores()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            listFatores.Items.Clear();
            int numero;

            if (int.TryParse(txtNumero.Text, out numero))
            {
                for (int i = 1; i <= numero; i++)
                {
                    if (numero % i == 0)
                    {
                        listFatores.Items.Add(i);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um número inteiro válido.");
            }
        }
    }
}