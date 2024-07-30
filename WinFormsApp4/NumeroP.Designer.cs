namespace WinFormsApp4
{
    partial class NumeroP
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
            btnVerificar = new Button();
            Numero = new Label();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(172, 23);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 9;
            // 
            // btnVerificar
            // 
            btnVerificar.BackColor = Color.LawnGreen;
            btnVerificar.Location = new Point(319, 23);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(94, 29);
            btnVerificar.TabIndex = 7;
            btnVerificar.Text = "Salvar";
            btnVerificar.UseVisualStyleBackColor = false;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // Numero
            // 
            Numero.AutoSize = true;
            Numero.BorderStyle = BorderStyle.FixedSingle;
            Numero.Font = new Font("Segoe UI", 12F);
            Numero.Location = new Point(12, 19);
            Numero.Name = "Numero";
            Numero.Size = new Size(154, 30);
            Numero.TabIndex = 8;
            Numero.Text = "Insira o número:";
            // 
            // NumeroP
            // 
            AcceptButton = btnVerificar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNumero);
            Controls.Add(btnVerificar);
            Controls.Add(Numero);
            Name = "NumeroP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NumeroP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private Button btnVerificar;
        private Label Numero;
    }
}