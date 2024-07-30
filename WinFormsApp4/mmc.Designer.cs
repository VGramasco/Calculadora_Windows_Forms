namespace WinFormsApp4
{
    partial class mmc
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
            txtNumero2 = new TextBox();
            txtNumero1 = new TextBox();
            btnCalcularMMC = new Button();
            Numero = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(10, 65);
            label1.Name = "label1";
            label1.Size = new Size(235, 30);
            label1.TabIndex = 16;
            label1.Text = "Insira o segundo número:";
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(253, 68);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(125, 27);
            txtNumero2.TabIndex = 15;
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(253, 23);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(125, 27);
            txtNumero1.TabIndex = 14;
            // 
            // btnCalcularMMC
            // 
            btnCalcularMMC.BackColor = Color.LawnGreen;
            btnCalcularMMC.Location = new Point(268, 110);
            btnCalcularMMC.Name = "btnCalcularMMC";
            btnCalcularMMC.Size = new Size(94, 29);
            btnCalcularMMC.TabIndex = 12;
            btnCalcularMMC.Text = "Salvar";
            btnCalcularMMC.UseVisualStyleBackColor = false;
            btnCalcularMMC.Click += btnCalcularMMC_Click;
            // 
            // Numero
            // 
            Numero.AutoSize = true;
            Numero.BorderStyle = BorderStyle.FixedSingle;
            Numero.Font = new Font("Segoe UI", 12F);
            Numero.Location = new Point(10, 19);
            Numero.Name = "Numero";
            Numero.Size = new Size(234, 30);
            Numero.TabIndex = 13;
            Numero.Text = "Insira o primeiro número:";
            // 
            // mmc
            // 
            AcceptButton = btnCalcularMMC;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(btnCalcularMMC);
            Controls.Add(Numero);
            Name = "mmc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mmc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero2;
        private TextBox txtNumero1;
        private Button btnCalcularMMC;
        private Label Numero;
    }
}