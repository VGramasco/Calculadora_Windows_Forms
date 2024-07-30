namespace WinFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fibonancciToolStripMenuItem = new ToolStripMenuItem();
            fatorialToolStripMenuItem = new ToolStripMenuItem();
            somaToolStripMenuItem = new ToolStripMenuItem();
            fatoresToolStripMenuItem = new ToolStripMenuItem();
            armstrongToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            numeroPerfeitoToolStripMenuItem = new ToolStripMenuItem();
            mDCToolStripMenuItem = new ToolStripMenuItem();
            mMCToolStripMenuItem = new ToolStripMenuItem();
            númeroPrimoToolStripMenuItem = new ToolStripMenuItem();
            raízCúbicaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fibonancciToolStripMenuItem, fatorialToolStripMenuItem, somaToolStripMenuItem, fatoresToolStripMenuItem, armstrongToolStripMenuItem, numeroPerfeitoToolStripMenuItem, mDCToolStripMenuItem, mMCToolStripMenuItem, númeroPrimoToolStripMenuItem, raízCúbicaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(873, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fibonancciToolStripMenuItem
            // 
            fibonancciToolStripMenuItem.Name = "fibonancciToolStripMenuItem";
            fibonancciToolStripMenuItem.Size = new Size(94, 24);
            fibonancciToolStripMenuItem.Text = "Fibonancci";
            fibonancciToolStripMenuItem.Click += fibonancciToolStripMenuItem_Click;
            // 
            // fatorialToolStripMenuItem
            // 
            fatorialToolStripMenuItem.Name = "fatorialToolStripMenuItem";
            fatorialToolStripMenuItem.Size = new Size(72, 24);
            fatorialToolStripMenuItem.Text = "Fatorial";
            fatorialToolStripMenuItem.Click += fatorialToolStripMenuItem_Click;
            // 
            // somaToolStripMenuItem
            // 
            somaToolStripMenuItem.Name = "somaToolStripMenuItem";
            somaToolStripMenuItem.Size = new Size(61, 24);
            somaToolStripMenuItem.Text = "Soma";
            somaToolStripMenuItem.Click += somaToolStripMenuItem_Click;
            // 
            // fatoresToolStripMenuItem
            // 
            fatoresToolStripMenuItem.Name = "fatoresToolStripMenuItem";
            fatoresToolStripMenuItem.Size = new Size(70, 24);
            fatoresToolStripMenuItem.Text = "Fatores";
            fatoresToolStripMenuItem.Click += fatoresToolStripMenuItem_Click;
            // 
            // armstrongToolStripMenuItem
            // 
            armstrongToolStripMenuItem.Name = "armstrongToolStripMenuItem";
            armstrongToolStripMenuItem.Size = new Size(93, 24);
            armstrongToolStripMenuItem.Text = "Armstrong";
            armstrongToolStripMenuItem.Click += armstrongToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(143, 99);
            label1.Name = "label1";
            label1.Size = new Size(586, 48);
            label1.TabIndex = 1;
            label1.Text = "Escolha a sua opção nos menus acima";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(223, 159);
            label2.Name = "label2";
            label2.Size = new Size(411, 39);
            label2.TabIndex = 2;
            label2.Text = "Desenvolvido por Pororoca's Dev";
            // 
            // numeroPerfeitoToolStripMenuItem
            // 
            numeroPerfeitoToolStripMenuItem.Name = "numeroPerfeitoToolStripMenuItem";
            numeroPerfeitoToolStripMenuItem.Size = new Size(132, 24);
            numeroPerfeitoToolStripMenuItem.Text = "Numero Perfeito";
            numeroPerfeitoToolStripMenuItem.Click += numeroPerfeitoToolStripMenuItem_Click;
            // 
            // mDCToolStripMenuItem
            // 
            mDCToolStripMenuItem.Name = "mDCToolStripMenuItem";
            mDCToolStripMenuItem.Size = new Size(56, 24);
            mDCToolStripMenuItem.Text = "MDC";
            mDCToolStripMenuItem.Click += mDCToolStripMenuItem_Click;
            // 
            // mMCToolStripMenuItem
            // 
            mMCToolStripMenuItem.Name = "mMCToolStripMenuItem";
            mMCToolStripMenuItem.Size = new Size(58, 24);
            mMCToolStripMenuItem.Text = "MMC";
            mMCToolStripMenuItem.Click += mMCToolStripMenuItem_Click;
            // 
            // númeroPrimoToolStripMenuItem
            // 
            númeroPrimoToolStripMenuItem.Name = "númeroPrimoToolStripMenuItem";
            númeroPrimoToolStripMenuItem.Size = new Size(120, 24);
            númeroPrimoToolStripMenuItem.Text = "Número Primo";
            númeroPrimoToolStripMenuItem.Click += númeroPrimoToolStripMenuItem_Click;
            // 
            // raízCúbicaToolStripMenuItem
            // 
            raízCúbicaToolStripMenuItem.Name = "raízCúbicaToolStripMenuItem";
            raízCúbicaToolStripMenuItem.Size = new Size(100, 24);
            raízCúbicaToolStripMenuItem.Text = "Raíz Cúbica";
            raízCúbicaToolStripMenuItem.Click += raízCúbicaToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(873, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fibonancciToolStripMenuItem;
        private ToolStripMenuItem fatorialToolStripMenuItem;
        private ToolStripMenuItem somaToolStripMenuItem;
        private ToolStripMenuItem fatoresToolStripMenuItem;
        private ToolStripMenuItem armstrongToolStripMenuItem;
        private Label label1;
        private Label label2;
        private ToolStripMenuItem numeroPerfeitoToolStripMenuItem;
        private ToolStripMenuItem mDCToolStripMenuItem;
        private ToolStripMenuItem mMCToolStripMenuItem;
        private ToolStripMenuItem númeroPrimoToolStripMenuItem;
        private ToolStripMenuItem raízCúbicaToolStripMenuItem;
    }
}
