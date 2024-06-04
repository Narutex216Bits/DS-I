using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoBD_CRUD
{
    internal class clsFuncionario
    {


        public int NumMatricula { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Email { get; set; }


        Dados objDados = new Dados();


        public void Incluir()
        {
            if (objDados.ConvertSqlToInt(@"INSERT INTO FUNCIONARIO(NUMMATRICULA,NOME,CARGO,EMAIL)
                VALUES(?NumMatricula,?Nome,?Cargo,?Email)",
                 new MySqlParameter("?NumMatricula", NumMatricula),
                 new MySqlParameter("?Nome", Nome),
                 new MySqlParameter("?Cargo", Cargo),
                 new MySqlParameter("?Email", Email)) != 0)

                MessageBox.Show("Inclusão realizada!");
        }


        public DataTable Consultar()
        {
            return objDados.ConvertSqlToDataTable("SELECT * FROM FUNCIONARIO");
        }

        public DataTable Pesquisar()
        {
            return objDados.ConvertSqlToDataTable(@"SELECT * FROM FUNCIONARIO
                WHERE NUMMATRICULA = ?NumMatricula",
                new MySqlParameter("?NumMatricula", NumMatricula));
        }

        public void Alterar()
        {

            if (objDados.ConvertSqlToInt(@"UPDATE FUNCIONARIO SET NOME = ?Nome, 
                CARGO = ?Cargo,EMAIL = ?Email WHERE NUMMATRICULA = ?NumMatricula",
                new MySqlParameter("?NumMatricula", NumMatricula),
                new MySqlParameter("?Nome", Nome),
                new MySqlParameter("?Cargo", Cargo),
                new MySqlParameter("?Email", Email)) != 0)

                MessageBox.Show("Alteração realizada!");
        }



        public void Excluir()
        {
            objDados.ConvertSqlToInt(@"DELETE FROM FUNCIONARIO
            WHERE NUMMATRICULA = ?NumMatricula",
            new MySqlParameter("?NumMatricula", NumMatricula));
        }



    }
}
