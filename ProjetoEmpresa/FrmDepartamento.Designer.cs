namespace ProjetoEmpresa
{
    partial class FrmDepartamento
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtID_Dep = new TextBox();
            label2 = new Label();
            txtNomeDep = new TextBox();
            txtSiglaDep = new TextBox();
            label3 = new Label();
            btnIncluir = new Button();
            btnConsultar = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            dtDepartamento = new DataGridView();
            btnPesquisar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtDepartamento).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(92, 34);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 32);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // txtID_Dep
            // 
            txtID_Dep.Font = new Font("Segoe UI", 12F);
            txtID_Dep.Location = new Point(192, 31);
            txtID_Dep.Margin = new Padding(2);
            txtID_Dep.Name = "txtID_Dep";
            txtID_Dep.Size = new Size(133, 39);
            txtID_Dep.TabIndex = 1;
            txtID_Dep.TextChanged += txtID_Dep_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(92, 100);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 32);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // txtNomeDep
            // 
            txtNomeDep.Font = new Font("Segoe UI", 12F);
            txtNomeDep.Location = new Point(192, 98);
            txtNomeDep.Margin = new Padding(2);
            txtNomeDep.Name = "txtNomeDep";
            txtNomeDep.Size = new Size(463, 39);
            txtNomeDep.TabIndex = 3;
            txtNomeDep.TextChanged += txtNomeDep_TextChanged;
            // 
            // txtSiglaDep
            // 
            txtSiglaDep.Font = new Font("Segoe UI", 12F);
            txtSiglaDep.Location = new Point(192, 154);
            txtSiglaDep.Margin = new Padding(2);
            txtSiglaDep.Name = "txtSiglaDep";
            txtSiglaDep.Size = new Size(133, 39);
            txtSiglaDep.TabIndex = 5;
            txtSiglaDep.TextChanged += txtSiglaDep_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(92, 156);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 32);
            label3.TabIndex = 4;
            label3.Text = "Sigla:";
            // 
            // btnIncluir
            // 
            btnIncluir.BackColor = Color.FromArgb(255, 255, 192);
            btnIncluir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnIncluir.ForeColor = Color.Black;
            btnIncluir.Location = new Point(74, 220);
            btnIncluir.Margin = new Padding(2);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(134, 58);
            btnIncluir.TabIndex = 6;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = false;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.FromArgb(255, 255, 192);
            btnConsultar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnConsultar.ForeColor = Color.Black;
            btnConsultar.Location = new Point(216, 220);
            btnConsultar.Margin = new Padding(2);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(148, 58);
            btnConsultar.TabIndex = 7;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.FromArgb(255, 255, 192);
            btnAlterar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAlterar.ForeColor = Color.Black;
            btnAlterar.Location = new Point(372, 220);
            btnAlterar.Margin = new Padding(2);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(134, 58);
            btnAlterar.TabIndex = 8;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(255, 255, 192);
            btnExcluir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExcluir.ForeColor = Color.Black;
            btnExcluir.Location = new Point(522, 220);
            btnExcluir.Margin = new Padding(2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(134, 58);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dtDepartamento
            // 
            dtDepartamento.AllowUserToAddRows = false;
            dtDepartamento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtDepartamento.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtDepartamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtDepartamento.Location = new Point(68, 294);
            dtDepartamento.Margin = new Padding(2);
            dtDepartamento.Name = "dtDepartamento";
            dtDepartamento.RowHeadersWidth = 62;
            dtDepartamento.Size = new Size(589, 225);
            dtDepartamento.TabIndex = 10;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.FromArgb(255, 255, 192);
            btnPesquisar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPesquisar.ForeColor = Color.Black;
            btnPesquisar.Location = new Point(351, 28);
            btnPesquisar.Margin = new Padding(2);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(151, 49);
            btnPesquisar.TabIndex = 11;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // FrmDepartamento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 531);
            Controls.Add(btnPesquisar);
            Controls.Add(dtDepartamento);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(btnConsultar);
            Controls.Add(btnIncluir);
            Controls.Add(txtSiglaDep);
            Controls.Add(label3);
            Controls.Add(txtNomeDep);
            Controls.Add(label2);
            Controls.Add(txtID_Dep);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "FrmDepartamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ":.DEPARTAMENTOS.: - lado 1";
            ((System.ComponentModel.ISupportInitialize)dtDepartamento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID_Dep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeDep;
        private System.Windows.Forms.TextBox txtSiglaDep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dtDepartamento;
        private System.Windows.Forms.Button btnPesquisar;
    }
}

