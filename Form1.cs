namespace BancoDidatico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Instanciando a classe da conta - criando objeto conta1 criado
        clsConta conta = new clsConta();

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void btnSacar_Click(object sender, EventArgs e)
        {
            try
            {
                conta.agencia = int.Parse(txbAgencia.Text);
                conta.NumeroConta = int.Parse(txbNumeroConta.Text);
                conta.valor = int.Parse(txbValor.Text);
                conta.saldo = int.Parse(txbSaldo.Text);
            } 
            catch (Exception) 
            {
            
            }
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {

        }
    }
}
