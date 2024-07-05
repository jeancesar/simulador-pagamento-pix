namespace SimuladorPagamentoPix
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblQrCodePix = new Label();
            txtQrCodePix = new TextBox();
            lblResultado = new Label();
            btnPagar = new Button();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // lblQrCodePix
            // 
            lblQrCodePix.AutoSize = true;
            lblQrCodePix.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblQrCodePix.Location = new Point(35, 32);
            lblQrCodePix.Name = "lblQrCodePix";
            lblQrCodePix.Size = new Size(72, 15);
            lblQrCodePix.TabIndex = 0;
            lblQrCodePix.Text = "QrCode Pix:";
            lblQrCodePix.UseMnemonic = false;
            // 
            // txtQrCodePix
            // 
            txtQrCodePix.Location = new Point(35, 50);
            txtQrCodePix.Name = "txtQrCodePix";
            txtQrCodePix.PlaceholderText = "Insira aqui o Pix Copia e Cola";
            txtQrCodePix.Size = new Size(655, 23);
            txtQrCodePix.TabIndex = 2;
            txtQrCodePix.WordWrap = false;
            txtQrCodePix.TextChanged += txtQrCodePix_TextChanged;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblResultado.Location = new Point(35, 101);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(65, 15);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "Resultado:";
            // 
            // btnPagar
            // 
            btnPagar.Enabled = false;
            btnPagar.Location = new Point(696, 50);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(75, 23);
            btnPagar.TabIndex = 3;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // txtResultado
            // 
            txtResultado.BackColor = Color.White;
            txtResultado.Location = new Point(35, 119);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.ScrollBars = ScrollBars.Vertical;
            txtResultado.Size = new Size(736, 299);
            txtResultado.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResultado);
            Controls.Add(btnPagar);
            Controls.Add(lblResultado);
            Controls.Add(txtQrCodePix);
            Controls.Add(lblQrCodePix);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Simulador de Pagamento Pix - Versão 1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQrCodePix;
        private TextBox txtQrCodePix;
        private Label lblResultado;
        private Button btnPagar;
        private TextBox txtResultado;
    }
}
