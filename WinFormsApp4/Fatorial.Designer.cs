namespace WinFormsApp4
{
    partial class Fatorial
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
            Numero = new Label();
            Salvar = new Button();
            listBoxResult = new ListBox();
            txtNumero = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Numero
            // 
            Numero.AutoSize = true;
            Numero.BorderStyle = BorderStyle.FixedSingle;
            Numero.Font = new Font("Segoe UI", 12F);
            Numero.Location = new Point(12, 9);
            Numero.Name = "Numero";
            Numero.Size = new Size(154, 30);
            Numero.TabIndex = 2;
            Numero.Text = "Insira o número:";
            // 
            // Salvar
            // 
            Salvar.BackColor = Color.LawnGreen;
            Salvar.Location = new Point(319, 13);
            Salvar.Name = "Salvar";
            Salvar.Size = new Size(94, 29);
            Salvar.TabIndex = 2;
            Salvar.Text = "Salvar";
            Salvar.UseVisualStyleBackColor = false;
            Salvar.Click += Salvar_Click;
            // 
            // listBoxResult
            // 
            listBoxResult.BorderStyle = BorderStyle.FixedSingle;
            listBoxResult.FormattingEnabled = true;
            listBoxResult.Location = new Point(122, 68);
            listBoxResult.Name = "listBoxResult";
            listBoxResult.Size = new Size(291, 142);
            listBoxResult.TabIndex = 5;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(172, 13);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 68);
            label1.Name = "label1";
            label1.Size = new Size(104, 30);
            label1.TabIndex = 7;
            label1.Text = "Resultado:";
            // 
            // Fatorial
            // 
            AcceptButton = Salvar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtNumero);
            Controls.Add(listBoxResult);
            Controls.Add(Salvar);
            Controls.Add(Numero);
            Name = "Fatorial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fatorial";
            Load += Fatorial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Numero;
        private Button Salvar;
        private ListBox listBoxResult;
        private TextBox txtNumero;
        private Label label1;
    }
}