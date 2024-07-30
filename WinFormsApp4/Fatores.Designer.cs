namespace WinFormsApp4
{
    partial class Fatores
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
            listFatores = new ListBox();
            label2 = new Label();
            txtNumero = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(232, 28);
            label1.TabIndex = 0;
            label1.Text = "Insira o número desejado";
            // 
            // listFatores
            // 
            listFatores.FormattingEnabled = true;
            listFatores.Location = new Point(12, 138);
            listFatores.Name = "listFatores";
            listFatores.Size = new Size(232, 104);
            listFatores.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(98, 28);
            label2.TabIndex = 2;
            label2.Text = "Resultado";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(12, 49);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(232, 27);
            txtNumero.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.LawnGreen;
            btnCalcular.Location = new Point(275, 47);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Salvar";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Fatores
            // 
            AcceptButton = btnCalcular;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(txtNumero);
            Controls.Add(label2);
            Controls.Add(listFatores);
            Controls.Add(label1);
            Name = "Fatores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fatores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listFatores;
        private Label label2;
        private TextBox txtNumero;
        private Button btnCalcular;
    }
}