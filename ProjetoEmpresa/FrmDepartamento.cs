using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEmpresa
{
    public partial class FrmDepartamento : Form
    {
        public FrmDepartamento()
        {
            InitializeComponent();
        }

        clsDepartamento objDep = new clsDepartamento();

        private bool RecuperarDados()
        {
            try
            {
                objDep.IDDep = int.Parse(txtID_Dep.Text);
                objDep.NomeDep = txtNomeDep.Text;
                objDep.SiglaDep = txtSiglaDep.Text;
                return true;
            }
            catch (FormatException) // erro de formato
            {
                MessageBox.Show("Preencha todos os campos corretamente!");
                return false;
            }
        }

        private void RedefinirCampos()
        {
            txtID_Dep.Clear();
            txtNomeDep.Clear();
            txtSiglaDep.Clear();
            dtDepartamento.Columns.Clear();
            txtID_Dep.Focus();
        }

        #region Botoes/Eventos
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (RecuperarDados())
            {
                objDep.Incluir();
                RedefinirCampos();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var dadosDepartamentos = objDep.Consultar();

            // se qtde de linha  maior q zero
            if (dadosDepartamentos.Rows.Count > 0)

                // exibe os dados se  existir registro na consulta
                dtDepartamento.DataSource = dadosDepartamentos;
            else
            {
                MessageBox.Show("Não há registros no banco!");
                dtDepartamento.Columns.Clear(); // limpa o GRID para que as colunas não apareçam
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                // recuperando o código para a propriedade
                objDep.IDDep = int.Parse(txtID_Dep.Text);

                // Chamada do método pesquisar
                var tblDados = objDep.Pesquisar();

                if (tblDados.Rows.Count > 0)
                {
                    // exibe no textbox o valor contido nas colunas da tabela (originada da consulta)
                    txtNomeDep.Text = tblDados.Rows[0]["NomeDep"].ToString();
                    txtSiglaDep.Text = tblDados.Rows[0]["SiglaDep"].ToString();
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Digite o Código antes de pesquisar");
                txtID_Dep.Focus();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (RecuperarDados())
            {
                objDep.Alterar();
                RedefinirCampos();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                objDep.IDDep = int.Parse(txtID_Dep.Text);

                if (MessageBox.Show("Deseja excluir esse registro?",
                    "Exclusão", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objDep.Excluir();
                    RedefinirCampos();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe o número do Código para a exclusão!");
                txtID_Dep.Clear();
            }
        }

        // dublo clique na linha do grid
        private void dtDepartamento_DoubleClick(object sender, EventArgs e)
        {
            //linha selecionada.TextBox recebe o valor (conteúdo) contido nas colunas(Cells[0] e [1])
            txtID_Dep.Text = $"{dtDepartamento.CurrentRow.Cells[0].Value}";
            txtNomeDep.Text = $"{dtDepartamento.CurrentRow.Cells[1].Value}";

            //Modo 2: Nome da coluna o invés do índice
            txtSiglaDep.Text = $"{dtDepartamento.CurrentRow.Cells["SIGLADEP"].Value}";
        }

        // pesquisa por inicial nome dep
        private void txtNomeDep_TextChanged(object sender, EventArgs e)
        {
            objDep.NomeDep = txtNomeDep.Text;

            if (objDep.PesquisarNome().Rows.Count > 0)
                dtDepartamento.DataSource = objDep.PesquisarNome();

            if (txtNomeDep.Text == "")
            {
                dtDepartamento.Columns.Clear();
            }
        }

        #endregion
    }
}
