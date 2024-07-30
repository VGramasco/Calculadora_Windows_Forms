namespace WinFormsApp4
{
    partial class raizC
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
            lblResultado = new Label();
            txtNumero = new TextBox();
            btnCalcularRaizCubica = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BorderStyle = BorderStyle.FixedSingle;
            lblResultado.Font = new Font("Segoe UI", 12F);
            lblResultado.Location = new Point(171, 65);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(100, 30);
            lblResultado.TabIndex = 15;
            lblResultado.Text = "Resultado";
            // 
            // txtNumero
            // 
            txtNumero.BorderStyle = BorderStyle.FixedSingle;
            txtNumero.Location = new Point(171, 22);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 18;
            // 
            // btnCalcularRaizCubica
            // 
            btnCalcularRaizCubica.BackColor = Color.LawnGreen;
            btnCalcularRaizCubica.BackgroundImageLayout = ImageLayout.None;
            btnCalcularRaizCubica.Location = new Point(318, 22);
            btnCalcularRaizCubica.Name = "btnCalcularRaizCubica";
            btnCalcularRaizCubica.Size = new Size(94, 29);
            btnCalcularRaizCubica.TabIndex = 16;
            btnCalcularRaizCubica.Text = "Salvar";
            btnCalcularRaizCubica.UseVisualStyleBackColor = false;
            btnCalcularRaizCubica.Click += btnCalcularRaizCubica_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(11, 18);
            label1.Name = "label1";
            label1.Size = new Size(154, 30);
            label1.TabIndex = 17;
            label1.Text = "Insira o número:";
            // 
            // raizC
            // 
            AcceptButton = btnCalcularRaizCubica;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNumero);
            Controls.Add(btnCalcularRaizCubica);
            Controls.Add(label1);
            Controls.Add(lblResultado);
            Name = "raizC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "raizC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private TextBox txtNumero;
        private Button btnCalcularRaizCubica;
        private Label label1;
    }
}