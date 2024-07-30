namespace WinFormsApp4
{
    partial class Primo
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
            txtNumero = new TextBox();
            btnVerificarPrimo = new Button();
            Numero = new Label();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(167, 12);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 12;
            // 
            // btnVerificarPrimo
            // 
            btnVerificarPrimo.BackColor = Color.LawnGreen;
            btnVerificarPrimo.Location = new Point(314, 12);
            btnVerificarPrimo.Name = "btnVerificarPrimo";
            btnVerificarPrimo.Size = new Size(94, 29);
            btnVerificarPrimo.TabIndex = 10;
            btnVerificarPrimo.Text = "Salvar";
            btnVerificarPrimo.UseVisualStyleBackColor = false;
            btnVerificarPrimo.Click += btnVerificarPrimo_Click;
            // 
            // Numero
            // 
            Numero.AutoSize = true;
            Numero.BorderStyle = BorderStyle.FixedSingle;
            Numero.Font = new Font("Segoe UI", 12F);
            Numero.Location = new Point(7, 8);
            Numero.Name = "Numero";
            Numero.Size = new Size(154, 30);
            Numero.TabIndex = 11;
            Numero.Text = "Insira o número:";
            // 
            // Primo
            // 
            AcceptButton = btnVerificarPrimo;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNumero);
            Controls.Add(btnVerificarPrimo);
            Controls.Add(Numero);
            Name = "Primo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Primo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private Button btnVerificarPrimo;
        private Label Numero;
    }
}