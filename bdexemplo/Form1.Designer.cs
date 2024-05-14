namespace bdexemplo
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
            btnIncluir = new Button();
            txtCodigo = new TextBox();
            dtGridAluno = new DataGridView();
            btnExcluir = new Button();
            btnConsultar = new Button();
            btnAlterar = new Button();
            btnPesquisar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtGridAluno).BeginInit();
            SuspendLayout();
            // 
            // btnIncluir
            // 
            btnIncluir.Font = new Font("Arial", 14.25F);
            btnIncluir.Location = new Point(21, 149);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(100, 50);
            btnIncluir.TabIndex = 0;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigo.Location = new Point(135, 21);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(234, 39);
            txtCodigo.TabIndex = 1;
            // 
            // dtGridAluno
            // 
            dtGridAluno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridAluno.Location = new Point(21, 215);
            dtGridAluno.Name = "dtGridAluno";
            dtGridAluno.Size = new Size(470, 299);
            dtGridAluno.TabIndex = 2;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(391, 149);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(100, 50);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Arial", 14.25F);
            btnConsultar.Location = new Point(148, 149);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(100, 50);
            btnConsultar.TabIndex = 4;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            btnAlterar.Font = new Font("Arial", 14.25F);
            btnAlterar.Location = new Point(269, 149);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(100, 50);
            btnAlterar.TabIndex = 5;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(391, 26);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(100, 30);
            btnPesquisar.TabIndex = 6;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 24);
            label1.Name = "label1";
            label1.Size = new Size(108, 32);
            label1.TabIndex = 7;
            label1.Text = "Código:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 96);
            label2.Name = "label2";
            label2.Size = new Size(93, 32);
            label2.TabIndex = 8;
            label2.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(135, 89);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(356, 39);
            txtNome.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 535);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnPesquisar);
            Controls.Add(btnAlterar);
            Controls.Add(btnConsultar);
            Controls.Add(btnExcluir);
            Controls.Add(dtGridAluno);
            Controls.Add(txtCodigo);
            Controls.Add(btnIncluir);
            Name = "Form1";
            Text = "Exemplo C.R.U.D.";
            ((System.ComponentModel.ISupportInitialize)dtGridAluno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIncluir;
        private TextBox txtCodigo;
        private DataGridView dtGridAluno;
        private Button btnExcluir;
        private Button btnConsultar;
        private Button btnAlterar;
        private Button btnPesquisar;
        private Label label1;
        private Label label2;
        private TextBox txtNome;
    }
}
