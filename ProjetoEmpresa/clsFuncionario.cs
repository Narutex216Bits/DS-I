using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmpresa
{
    internal class clsFuncionario
    {
        public int IDDP { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }


        Dados objDados = new Dados();


        public void Incluir()
        {
            if (objDados.ConvertSqlToInt(@"INSERT INTO DEPARTAMENTO(IDDEP,NOMEDEP,SIGLADEP)
                VALUES(?IdDep,?NomeDep,?SiglaDep)",
                 new MySqlParameter("?IdDep", IDDP),
                 new MySqlParameter("?NomeDep", Nome),
                 new MySqlParameter("?SiglaDep", Sigla)

                MessageBox.Show("Inclusão realizada!");
        }


        public DataTable Consultar()
        {
            return objDados.ConvertSqlToDataTable("SELECT * FROM FUNCIONARIO");
        }

        public DataTable Pesquisar()
        {
            return objDados.ConvertSqlToDataTable(@"SELECT * FROM FUNCIONARIO
                WHERE IDDEP = ?IdDep",
                new MySqlParameter("?IdDep", IdDep));
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
