namespace AvaliacaoBD_CRUD
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
            label1 = new Label();
            txtMatricula = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtCargo = new TextBox();
            label4 = new Label();
            btnPesquisar = new Button();
            btnIncluir = new Button();
            btnConsultar = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            dtGridFuncionario = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtGridFuncionario).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 38);
            label1.Name = "label1";
            label1.Size = new Size(110, 21);
            label1.TabIndex = 0;
            label1.Text = "N° Matrícula:";
            // 
            // txtMatricula
            // 
            txtMatricula.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatricula.Location = new Point(160, 38);
            txtMatricula.Margin = new Padding(3, 2, 3, 2);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(65, 27);
            txtMatricula.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(112, 80);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(284, 27);
            txtNome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 82);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(112, 120);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(284, 27);
            txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 122);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 4;
            label3.Text = "e-mail:";
            // 
            // txtCargo
            // 
            txtCargo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCargo.Location = new Point(483, 80);
            txtCargo.Margin = new Padding(3, 2, 3, 2);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(175, 27);
            txtCargo.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(415, 80);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 6;
            label4.Text = "Cargo:";
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.Yellow;
            btnPesquisar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.ForeColor = Color.Black;
            btnPesquisar.Location = new Point(250, 33);
            btnPesquisar.Margin = new Padding(3, 2, 3, 2);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(123, 28);
            btnPesquisar.TabIndex = 8;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnIncluir
            // 
            btnIncluir.BackColor = Color.Yellow;
            btnIncluir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIncluir.ForeColor = Color.Black;
            btnIncluir.Location = new Point(42, 168);
            btnIncluir.Margin = new Padding(3, 2, 3, 2);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(123, 28);
            btnIncluir.TabIndex = 9;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = false;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.Yellow;
            btnConsultar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar.ForeColor = Color.Black;
            btnConsultar.Location = new Point(205, 168);
            btnConsultar.Margin = new Padding(3, 2, 3, 2);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(123, 28);
            btnConsultar.TabIndex = 10;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.Yellow;
            btnAlterar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterar.ForeColor = Color.Black;
            btnAlterar.Location = new Point(374, 168);
            btnAlterar.Margin = new Padding(3, 2, 3, 2);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(123, 28);
            btnAlterar.TabIndex = 11;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Yellow;
            btnExcluir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.Black;
            btnExcluir.Location = new Point(534, 168);
            btnExcluir.Margin = new Padding(3, 2, 3, 2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(123, 28);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dtGridFuncionario
            // 
            dtGridFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridFuncionario.Location = new Point(50, 217);
            dtGridFuncionario.Margin = new Padding(3, 2, 3, 2);
            dtGridFuncionario.Name = "dtGridFuncionario";
            dtGridFuncionario.RowHeadersWidth = 51;
            dtGridFuncionario.Size = new Size(607, 141);
            dtGridFuncionario.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 380);
            Controls.Add(dtGridFuncionario);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(btnConsultar);
            Controls.Add(btnIncluir);
            Controls.Add(btnPesquisar);
            Controls.Add(txtCargo);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtMatricula);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Cadastro de Funcionarios";
            ((System.ComponentModel.ISupportInitialize)dtGridFuncionario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMatricula;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtCargo;
        private Label label4;
        private Button btnPesquisar;
        private Button btnIncluir;
        private Button btnConsultar;
        private Button btnAlterar;
        private Button btnExcluir;
        private DataGridView dtGridFuncionario;
    }
}
