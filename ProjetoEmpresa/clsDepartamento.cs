using MySql.Data.MySqlClient;
using System.Data;

namespace ProjetoEmpresa
{
    internal class clsDepartamento
    {
        public int IDDep { get; set; }
        public string NomeDep { get; set; }
        public string SiglaDep { get; set; }

        #region Métodos

        Dados objDados = new Dados();

        #region Incluir
        public void Incluir()
        {
            if (objDados.ConvertSqlToInt(@"INSERT INTO DEPARTAMENTO
                (IDDEP,NOMEDEP,SIGLADEP)VALUES(?Id,?Nome,?Sigla)",
                    new MySqlParameter("?Id", IDDep),
                    new MySqlParameter("?Nome", NomeDep),
                    new MySqlParameter("?Sigla", SiglaDep)) != 0)

                MessageBox.Show("Inclusão realizada!");

        }
        #endregion

        #region Consultar
        public DataTable Consultar()
        {
            DataTable tblRecuperada = objDados.ConvertSqlToDataTable(
                "SELECT * FROM DEPARTAMENTO");

            return tblRecuperada;
        }
        #endregion

        #region Pesquisar pelo Código
        public DataTable Pesquisar()
        {
            DataTable tblRecuperada = objDados.ConvertSqlToDataTable(
                "SELECT * FROM DEPARTAMENTO WHERE IDDEP = ?Id",
                new MySqlParameter("?Id", IDDep));

            return tblRecuperada;
        }
        #endregion

        #region Pesquisar pelo Nome Dep
        public DataTable PesquisarNome()
        {
            DataTable tblRecuperada = objDados.ConvertSqlToDataTable(
                "SELECT * FROM DEPARTAMENTO WHERE NOMEDEP LIKE ?Nome",
                new MySqlParameter("?Nome", NomeDep + "%"));

            return tblRecuperada;
        }
        #endregion

        #region Alterar
        public void Alterar()
        {
            if (objDados.ConvertSqlToInt(
                 @"UPDATE DEPARTAMENTO SET NOMEDEP=?Nome,SIGLADEP=?Sigla 
                 WHERE IDDEP = ?Id",
                 new MySqlParameter("?Id", IDDep),
                 new MySqlParameter("?Nome", NomeDep),
                 new MySqlParameter("?Sigla", SiglaDep)) != 0)

                MessageBox.Show("Alteração realizada!");
            else
                MessageBox.Show("Não foi possível realizar a Alteração!");
        }
        #endregion

        #region Excluir
        public void Excluir()
        {
            if (objDados.ConvertSqlToInt("DELETE FROM DEPARTAMENTO WHERE IDDEP = ?Id",
                      new MySqlParameter("?Id", IDDep)) != 0)
                MessageBox.Show("Registro Excluído!");
            else
                MessageBox.Show("Código não encontrado!" +
                    "\nNão foi possível realizar a Exclusão!");
        }
        #endregion

        #endregion

    }
}
