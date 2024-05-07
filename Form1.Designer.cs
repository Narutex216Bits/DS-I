namespace BancoDidatico
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
            txbSaldo = new TextBox();
            label1 = new Label();
            btnSacar = new Button();
            btnDepositar = new Button();
            txbAgencia = new TextBox();
            txbNumeroConta = new TextBox();
            txbValor = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txbSaldo
            // 
            txbSaldo.BackColor = SystemColors.Info;
            txbSaldo.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbSaldo.Location = new Point(571, 93);
            txbSaldo.Name = "txbSaldo";
            txbSaldo.Size = new Size(194, 39);
            txbSaldo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(90, 49);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 1;
            label1.Text = "Agência:";
            // 
            // btnSacar
            // 
            btnSacar.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSacar.Location = new Point(128, 329);
            btnSacar.Name = "btnSacar";
            btnSacar.Size = new Size(190, 90);
            btnSacar.TabIndex = 2;
            btnSacar.Text = "Sacar";
            btnSacar.UseVisualStyleBackColor = true;
            btnSacar.Click += btnSacar_Click;
            // 
            // btnDepositar
            // 
            btnDepositar.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDepositar.Location = new Point(474, 329);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(190, 90);
            btnDepositar.TabIndex = 3;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // txbAgencia
            // 
            txbAgencia.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbAgencia.Location = new Point(207, 42);
            txbAgencia.Name = "txbAgencia";
            txbAgencia.Size = new Size(169, 39);
            txbAgencia.TabIndex = 4;
            // 
            // txbNumeroConta
            // 
            txbNumeroConta.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbNumeroConta.Location = new Point(207, 123);
            txbNumeroConta.Name = "txbNumeroConta";
            txbNumeroConta.Size = new Size(169, 39);
            txbNumeroConta.TabIndex = 5;
            // 
            // txbValor
            // 
            txbValor.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbValor.Location = new Point(207, 201);
            txbValor.Name = "txbValor";
            txbValor.Size = new Size(251, 39);
            txbValor.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 123);
            label2.Name = "label2";
            label2.Size = new Size(198, 32);
            label2.TabIndex = 7;
            label2.Text = "Número Conta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(128, 208);
            label3.Name = "label3";
            label3.Size = new Size(82, 32);
            label3.TabIndex = 8;
            label3.Text = "Valor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(474, 100);
            label4.Name = "label4";
            label4.Size = new Size(91, 32);
            label4.TabIndex = 9;
            label4.Text = "Saldo:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txbValor);
            Controls.Add(txbNumeroConta);
            Controls.Add(txbAgencia);
            Controls.Add(btnDepositar);
            Controls.Add(btnSacar);
            Controls.Add(label1);
            Controls.Add(txbSaldo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbSaldo;
        private Label label1;
        private Button btnSacar;
        private Button btnDepositar;
        private TextBox txbAgencia;
        private TextBox txbNumeroConta;
        private TextBox txbValor;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
