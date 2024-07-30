namespace WinFormsApp4
{
    partial class mdc
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
            txtNumero1 = new TextBox();
            btnCalcularMDC = new Button();
            Numero = new Label();
            txtNumero2 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(252, 22);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(125, 27);
            txtNumero1.TabIndex = 9;
            // 
            // btnCalcularMDC
            // 
            btnCalcularMDC.BackColor = Color.LawnGreen;
            btnCalcularMDC.Location = new Point(267, 109);
            btnCalcularMDC.Name = "btnCalcularMDC";
            btnCalcularMDC.Size = new Size(94, 29);
            btnCalcularMDC.TabIndex = 7;
            btnCalcularMDC.Text = "Salvar";
            btnCalcularMDC.UseVisualStyleBackColor = false;
            btnCalcularMDC.Click += btnCalcularMDC_Click;
            // 
            // Numero
            // 
            Numero.AutoSize = true;
            Numero.BorderStyle = BorderStyle.FixedSingle;
            Numero.Font = new Font("Segoe UI", 12F);
            Numero.Location = new Point(9, 18);
            Numero.Name = "Numero";
            Numero.Size = new Size(234, 30);
            Numero.TabIndex = 8;
            Numero.Text = "Insira o primeiro número:";
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(252, 67);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(125, 27);
            txtNumero2.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(9, 64);
            label1.Name = "label1";
            label1.Size = new Size(235, 30);
            label1.TabIndex = 11;
            label1.Text = "Insira o segundo número:";
            // 
            // mdc
            // 
            AcceptButton = btnCalcularMDC;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(btnCalcularMDC);
            Controls.Add(Numero);
            Name = "mdc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mdc";
            Click += btnCalcularMDC_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero1;
        private Button btnCalcularMDC;
        private Label Numero;
        private TextBox txtNumero2;
        private Label label1;
    }
}