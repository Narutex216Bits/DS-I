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
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            objFuncionario.IDDep = int.Parse($"{cboDepartamento.SelectedValue}");

            objFuncionario.Nome = txtNome.Text;
            objFuncionario.CEP = txtCEP.Text;
            objFuncionario.Endereco = txtEndereco.Text;
            objFuncionario.Complemento = txtComplemento.Text;
            objFuncionario.Numero = txtNumero.Text;
            objFuncionario.Bairro = txtBairro.Text;
            objFuncionario.Cidade = txtCidade.Text;
            objFuncionario.UF = txtUF.Text;
            objFuncionario.Salario = decimal.Parse(txtSalario.Text);

            objFuncionario.Incluir();
        }
    }
}
