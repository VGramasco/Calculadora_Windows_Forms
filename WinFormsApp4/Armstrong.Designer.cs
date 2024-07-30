namespace WinFormsApp4
{
    partial class Armstrong
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
            txtNumero = new TextBox();
            btnVerificar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(153, 28);
            label1.TabIndex = 0;
            label1.Text = "Insira o número ";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(12, 50);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 1;
            // 
            // btnVerificar
            // 
            btnVerificar.BackColor = Color.LawnGreen;
            btnVerificar.Location = new Point(27, 83);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(94, 29);
            btnVerificar.TabIndex = 2;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = false;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // Armstrong
            // 
            AcceptButton = btnVerificar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerificar);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "Armstrong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Armstrong";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Button btnVerificar;
    }
}