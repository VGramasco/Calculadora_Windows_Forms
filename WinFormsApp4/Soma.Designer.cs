namespace WinFormsApp4
{
    partial class Soma
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
            lblSoma = new Label();
            Salvar = new Button();
            txtNumero = new TextBox();
            SuspendLayout();
            // 
            // lblSoma
            // 
            lblSoma.AutoSize = true;
            lblSoma.Font = new Font("Segoe UI", 12F);
            lblSoma.Location = new Point(12, 18);
            lblSoma.Name = "lblSoma";
            lblSoma.Size = new Size(323, 28);
            lblSoma.TabIndex = 0;
            lblSoma.Text = "Insira quantos números quer somar:";
            // 
            // Salvar
            // 
            Salvar.BackColor = Color.LawnGreen;
            Salvar.Location = new Point(356, 55);
            Salvar.Name = "Salvar";
            Salvar.Size = new Size(94, 29);
            Salvar.TabIndex = 1;
            Salvar.Text = "Salvar";
            Salvar.UseVisualStyleBackColor = false;
            Salvar.Click += Salvar_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(341, 22);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 2;
            // 
            // Soma
            // 
            AcceptButton = Salvar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNumero);
            Controls.Add(Salvar);
            Controls.Add(lblSoma);
            Name = "Soma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Soma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSoma;
        private Button Salvar;
        private TextBox txtNumero;
    }
}