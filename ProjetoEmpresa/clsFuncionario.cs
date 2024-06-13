using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjetoEmpresa
{
    internal class clsFuncionario
    {
        public int IDFunc { get; set; }
        public string Nome { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Numero { get; set; }
        public decimal Salario { get; set; }
        public int IDDep { get; set; }


        Dados objDados = new Dados();

        public DataTable ConsultarDepartamento()
        {
            return objDados.ConvertSqlToDataTable(
                "SELECT IDDEP, SIGLADEP FROM DEPARTAMENTO ORDER BY SIGLADEP");
        }

        public void Incluir()
        {
            if (objDados.ConvertSqlToInt(@"INSERT INTO FUNCIONARIO
        (NOME,CEP,ENDERECO,COMPLEMENTO,NUMERO,BAIRRO,CIDADE,
        UF,SALARIO,IDDEP)VALUES(?Nome,?Cep,?Endereco,
        ?Complemento,?Numero,?Bairro,?Cidade,?UF,
        ?Salario,?IdDep)",
                new MySqlParameter("?Nome", Nome),
                new MySqlParameter("?Cep", CEP),
                new MySqlParameter("?Endereco", Endereco),
                new MySqlParameter("?Complemento", Complemento),
                new MySqlParameter("?Numero", Numero),
                new MySqlParameter("?Bairro", Bairro),
                new MySqlParameter("?Cidade", Cidade),
                new MySqlParameter("?UF", UF),
                new MySqlParameter("?Salario", Salario),
                new MySqlParameter("?IdDep", IDDep)) != 0)

                MessageBox.Show("Inclusão realizada!");
        }
    }
}
