namespace WinFormsApp4
{
    partial class Fibonacci
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Numero = new TextBox();
            Salvar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DimGray;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(148, 28);
            label1.TabIndex = 0;
            label1.Text = "Insira o número";
            // 
            // Numero
            // 
            Numero.BackColor = Color.White;
            Numero.BorderStyle = BorderStyle.FixedSingle;
            Numero.ForeColor = SystemColors.WindowText;
            Numero.Location = new Point(166, 14);
            Numero.Name = "Numero";
            Numero.Size = new Size(125, 27);
            Numero.TabIndex = 1;
            Numero.TextAlign = HorizontalAlignment.Center;
            // 
            // Salvar
            // 
            Salvar.BackColor = Color.LawnGreen;
            Salvar.Location = new Point(179, 47);
            Salvar.Name = "Salvar";
            Salvar.Size = new Size(94, 29);
            Salvar.TabIndex = 2;
            Salvar.Text = "Salvar";
            Salvar.UseVisualStyleBackColor = false;
            Salvar.Click += Salvar_Click;
            // 
            // Fibonacci
            // 
            AcceptButton = Salvar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(Salvar);
            Controls.Add(Numero);
            Controls.Add(label1);
            Name = "Fibonacci";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fibonacci";
            Load += Fibonacci_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Numero;
        private Button Salvar;
    }
}