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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            label1.Location = new Point(136, 32);
            label1.Name = "label1";
            label1.Size = new Size(42, 32);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // txtID_Dep
            // 
            txtID_Dep.Font = new Font("Segoe UI", 12F);
            txtID_Dep.Location = new Point(193, 32);
            txtID_Dep.Name = "txtID_Dep";
            txtID_Dep.Size = new Size(133, 39);
            txtID_Dep.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(93, 100);
            label2.Name = "label2";
            label2.Size = new Size(85, 32);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // txtNomeDep
            // 
            txtNomeDep.Font = new Font("Segoe UI", 12F);
            txtNomeDep.Location = new Point(193, 97);
            txtNomeDep.Name = "txtNomeDep";
            txtNomeDep.Size = new Size(463, 39);
            txtNomeDep.TabIndex = 3;
            txtNomeDep.TextChanged += txtNomeDep_TextChanged;
            // 
            // txtSiglaDep
            // 
            txtSiglaDep.Font = new Font("Segoe UI", 12F);
            txtSiglaDep.Location = new Point(193, 153);
            txtSiglaDep.Name = "txtSiglaDep";
            txtSiglaDep.Size = new Size(133, 39);
            txtSiglaDep.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(108, 157);
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
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(134, 57);
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
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(147, 57);
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
            btnAlterar.Location = new Point(373, 220);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(134, 57);
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
            btnExcluir.Location = new Point(523, 220);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(134, 57);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 255, 128);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtDepartamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtDepartamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtDepartamento.DefaultCellStyle = dataGridViewCellStyle2;
            dtDepartamento.EnableHeadersVisualStyles = false;
            dtDepartamento.Location = new Point(67, 293);
            dtDepartamento.Name = "dtDepartamento";
            dtDepartamento.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 128);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtDepartamento.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtDepartamento.RowHeadersWidth = 62;
            dtDepartamento.Size = new Size(589, 225);
            dtDepartamento.TabIndex = 10;
            dtDepartamento.DoubleClick += dtDepartamento_DoubleClick;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.FromArgb(255, 255, 192);
            btnPesquisar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPesquisar.ForeColor = Color.Black;
            btnPesquisar.Location = new Point(351, 27);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(151, 48);
            btnPesquisar.TabIndex = 11;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // FrmDepartamento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 532);
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

