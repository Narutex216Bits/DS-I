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

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            objFuncionario.IDDEP = int.Parse(txtID_Dep.Text);
            objFuncionario.Nome = txtNomeDep.Text;
            objFuncionario.Sigla = txtSiglaDep.Text;

            objFuncionario.Incluir();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            return objDados.ConvertSqlToDataTable("SELECT * FROM FUNCIONARIO");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            objFuncionario.IDDEP = int.Parse(txtID_Dep.Text);
            objFuncionario.Nome = txtNomeDep.Text;
            objFuncionario.Sigla = txtSiglaDep.Text;

            objFuncionario.Alterar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            objFuncionario.IDDEP = int.Parse(txtID_Dep.Text);
            objFuncionario.Excluir();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            objFuncionario.IDDEP = int.Parse(txtID_Dep.Text);
            txtID_Dep.Text = $"{objFuncionario.Pesquisar().Rows[1]["IDDEP"]}";
            txtNomeDep.Text = $"{objFuncionario.Pesquisar().Rows[2]["NOMEDEP"]}";
            txtSiglaDep.Text = $"{objFuncionario.Pesquisar().Rows[3]["SIGLADEP"]}";
         }

        private void txtID_Dep_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeDep_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSiglaDep_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
