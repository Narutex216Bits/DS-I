namespace AvaliacaoBD_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        clsFuncionario objFuncionario = new clsFuncionario();

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dtGridFuncionario.DataSource = objFuncionario.Consultar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            objFuncionario.NumMatricula = int.Parse(txtMatricula.Text);
            objFuncionario.Excluir();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            objFuncionario.NumMatricula = int.Parse(txtMatricula.Text);
            objFuncionario.Nome = txtNome.Text;
            objFuncionario.Cargo = txtCargo.Text;
            objFuncionario.Email = txtEmail.Text;

            objFuncionario.Incluir();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            objFuncionario.NumMatricula = int.Parse(txtMatricula.Text);
            objFuncionario.Nome = txtNome.Text;
            objFuncionario.Cargo = txtCargo.Text;
            objFuncionario.Email = txtEmail.Text;

            objFuncionario.Alterar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            objFuncionario.NumMatricula = int.Parse(txtMatricula.Text);

            txtNome.Text = $"{objFuncionario.Pesquisar().Rows[0]["nome"]}";
            txtCargo.Text = $"{objFuncionario.Pesquisar().Rows[0]["cargo"]}";
            txtEmail.Text = $"{objFuncionario.Pesquisar().Rows[0]["email"]}";
        }

       
    }
}
