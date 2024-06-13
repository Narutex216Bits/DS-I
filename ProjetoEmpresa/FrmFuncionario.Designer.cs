﻿namespace ProjetoEmpresa
{
    partial class FrmFuncionario
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
            components = new System.ComponentModel.Container();
            btnExcluir = new Button();
            btnAlterar = new Button();
            btnConsultar = new Button();
            btnIncluir = new Button();
            dtFuncionario = new DataGridView();
            cboDepartamento = new ComboBox();
            label2 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            txtBairro = new TextBox();
            label4 = new Label();
            txtEndereco = new TextBox();
            label5 = new Label();
            txtCidade = new TextBox();
            label6 = new Label();
            txtSalario = new TextBox();
            label7 = new Label();
            label1 = new Label();
            txtID_Func = new TextBox();
            label8 = new Label();
            txtComplemento = new TextBox();
            label9 = new Label();
            txtUF = new TextBox();
            label10 = new Label();
            btnPesquisar = new Button();
            txtNumero = new TextBox();
            label11 = new Label();
            txtCEP = new MaskedTextBox();
            btnNovoRegistro = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dtFuncionario).BeginInit();
            SuspendLayout();
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(255, 255, 192);
            btnExcluir.Enabled = false;
            btnExcluir.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnExcluir.ForeColor = Color.Black;
            btnExcluir.Location = new Point(842, 442);
            btnExcluir.Margin = new Padding(2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(194, 72);
            btnExcluir.TabIndex = 23;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.FromArgb(255, 255, 192);
            btnAlterar.Enabled = false;
            btnAlterar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAlterar.ForeColor = Color.Black;
            btnAlterar.Location = new Point(610, 442);
            btnAlterar.Margin = new Padding(2);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(194, 72);
            btnAlterar.TabIndex = 22;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.FromArgb(255, 255, 192);
            btnConsultar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnConsultar.ForeColor = Color.Black;
            btnConsultar.Location = new Point(372, 442);
            btnConsultar.Margin = new Padding(2);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(194, 72);
            btnConsultar.TabIndex = 21;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            // 
            // btnIncluir
            // 
            btnIncluir.BackColor = Color.FromArgb(255, 255, 192);
            btnIncluir.Enabled = false;
            btnIncluir.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnIncluir.ForeColor = Color.Black;
            btnIncluir.Location = new Point(125, 442);
            btnIncluir.Margin = new Padding(2);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(192, 72);
            btnIncluir.TabIndex = 20;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = false;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // dtFuncionario
            // 
            dtFuncionario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtFuncionario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtFuncionario.Location = new Point(98, 541);
            dtFuncionario.Margin = new Padding(5, 6, 5, 6);
            dtFuncionario.Name = "dtFuncionario";
            dtFuncionario.RowHeadersWidth = 62;
            dtFuncionario.Size = new Size(994, 279);
            dtFuncionario.TabIndex = 19;
            // 
            // cboDepartamento
            // 
            cboDepartamento.Font = new Font("Segoe UI", 12F);
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(89, 154);
            cboDepartamento.Margin = new Padding(5, 6, 5, 6);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(199, 40);
            cboDepartamento.TabIndex = 0;
            toolTip1.SetToolTip(cboDepartamento, "Selecione o departamento");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(310, 116);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 32);
            label2.TabIndex = 4;
            label2.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F);
            txtNome.Location = new Point(310, 155);
            txtNome.Margin = new Padding(5, 6, 5, 6);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(550, 39);
            txtNome.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(415, 326);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 32);
            label3.TabIndex = 6;
            label3.Text = "Bairro:";
            // 
            // txtBairro
            // 
            txtBairro.Font = new Font("Segoe UI", 12F);
            txtBairro.Location = new Point(415, 364);
            txtBairro.Margin = new Padding(5, 6, 5, 6);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(288, 39);
            txtBairro.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(310, 216);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(118, 32);
            label4.TabIndex = 8;
            label4.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Segoe UI", 12F);
            txtEndereco.Location = new Point(310, 254);
            txtEndereco.Margin = new Padding(5, 6, 5, 6);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(550, 39);
            txtEndereco.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(738, 326);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 32);
            label5.TabIndex = 10;
            label5.Text = "Cidade:";
            // 
            // txtCidade
            // 
            txtCidade.Font = new Font("Segoe UI", 12F);
            txtCidade.Location = new Point(738, 364);
            txtCidade.Margin = new Padding(5, 6, 5, 6);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(250, 39);
            txtCidade.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(889, 116);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(90, 32);
            label6.TabIndex = 12;
            label6.Text = "Salário:";
            // 
            // txtSalario
            // 
            txtSalario.Font = new Font("Segoe UI", 12F);
            txtSalario.Location = new Point(896, 155);
            txtSalario.Margin = new Padding(5, 6, 5, 6);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(176, 39);
            txtSalario.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(89, 116);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(173, 32);
            label7.TabIndex = 14;
            label7.Text = "Departamento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(340, 11);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 32);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // txtID_Func
            // 
            txtID_Func.Font = new Font("Segoe UI", 12F);
            txtID_Func.Location = new Point(340, 54);
            txtID_Func.Margin = new Padding(5, 6, 5, 6);
            txtID_Func.Name = "txtID_Func";
            txtID_Func.ReadOnly = true;
            txtID_Func.Size = new Size(138, 39);
            txtID_Func.TabIndex = 12;
            toolTip1.SetToolTip(txtID_Func, "Tecle ENTER para pesquisar");
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(89, 216);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(59, 32);
            label8.TabIndex = 24;
            label8.Text = "CEP:";
            // 
            // txtComplemento
            // 
            txtComplemento.Font = new Font("Segoe UI", 12F);
            txtComplemento.Location = new Point(89, 364);
            txtComplemento.Margin = new Padding(5, 6, 5, 6);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(305, 39);
            txtComplemento.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(89, 326);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(172, 32);
            label9.TabIndex = 26;
            label9.Text = "Complemento:";
            // 
            // txtUF
            // 
            txtUF.Font = new Font("Segoe UI", 12F);
            txtUF.Location = new Point(1006, 364);
            txtUF.Margin = new Padding(5, 6, 5, 6);
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(63, 39);
            txtUF.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(1006, 326);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(47, 32);
            label10.TabIndex = 28;
            label10.Text = "UF:";
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.FromArgb(255, 255, 192);
            btnPesquisar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPesquisar.ForeColor = Color.Black;
            btnPesquisar.Location = new Point(491, 48);
            btnPesquisar.Margin = new Padding(2);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(188, 52);
            btnPesquisar.TabIndex = 30;
            btnPesquisar.Text = "Pesquisar";
            toolTip1.SetToolTip(btnPesquisar, "Cique para habilitar ID");
            btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Segoe UI", 12F);
            txtNumero.Location = new Point(896, 254);
            txtNumero.Margin = new Padding(5, 6, 5, 6);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(86, 39);
            txtNumero.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(892, 216);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(46, 32);
            label11.TabIndex = 31;
            label11.Text = "N°.";
            // 
            // txtCEP
            // 
            txtCEP.Font = new Font("Segoe UI", 12F);
            txtCEP.Location = new Point(89, 254);
            txtCEP.Margin = new Padding(2);
            txtCEP.Mask = "00000-000";
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(199, 39);
            txtCEP.TabIndex = 3;
            toolTip1.SetToolTip(txtCEP, "Tecle ENTER para pesquisar");
            // 
            // btnNovoRegistro
            // 
            btnNovoRegistro.AutoSize = true;
            btnNovoRegistro.BackColor = Color.Red;
            btnNovoRegistro.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnNovoRegistro.ForeColor = Color.White;
            btnNovoRegistro.Location = new Point(84, 41);
            btnNovoRegistro.Margin = new Padding(2);
            btnNovoRegistro.Name = "btnNovoRegistro";
            btnNovoRegistro.Size = new Size(235, 60);
            btnNovoRegistro.TabIndex = 32;
            btnNovoRegistro.Text = "Novo Registro";
            toolTip1.SetToolTip(btnNovoRegistro, "Clique para Incluir");
            btnNovoRegistro.UseVisualStyleBackColor = false;
            // 
            // FrmFuncionario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 838);
            Controls.Add(btnNovoRegistro);
            Controls.Add(txtCEP);
            Controls.Add(txtNumero);
            Controls.Add(label11);
            Controls.Add(btnPesquisar);
            Controls.Add(txtUF);
            Controls.Add(label10);
            Controls.Add(txtComplemento);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(btnConsultar);
            Controls.Add(btnIncluir);
            Controls.Add(dtFuncionario);
            Controls.Add(label7);
            Controls.Add(txtSalario);
            Controls.Add(label6);
            Controls.Add(txtCidade);
            Controls.Add(label5);
            Controls.Add(txtEndereco);
            Controls.Add(label4);
            Controls.Add(txtBairro);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtID_Func);
            Controls.Add(label1);
            Controls.Add(cboDepartamento);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FrmFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ":. FUNCIONÁRIO .: - lado N";
            ((System.ComponentModel.ISupportInitialize)dtFuncionario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.DataGridView dtFuncionario;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID_Func;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Button btnNovoRegistro;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}