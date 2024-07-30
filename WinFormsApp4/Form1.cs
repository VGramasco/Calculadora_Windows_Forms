using System.Drawing.Text;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fibonancciToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Fibonacci frm = new Fibonacci();
            frm.Show();

        }

        private void fatorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fatorial frm = new Fatorial();
            frm.Show();
        }

        private void somaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Soma frm = new Soma();
            frm.Show();
        }

        private void fatoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fatores frm = new Fatores();
            frm.Show();
        }

        private void armstrongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Armstrong frm = new Armstrong();
            frm.Show();
        }

        private void numeroPerfeitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NumeroP frm = new NumeroP();
            frm.Show();
        }

        private void mDCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mdc frm = new mdc();
            frm.Show();
        }

        private void mMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mmc frm = new mmc();
            frm.Show();
        }

        private void númeroPrimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Primo frm = new Primo();
            frm.Show();
        }

        private void raízCúbicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            raizC frm = new raizC();
            frm.Show();
        }
    }
}
