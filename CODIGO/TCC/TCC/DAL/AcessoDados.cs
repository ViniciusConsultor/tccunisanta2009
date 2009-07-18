using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace TCC.DAL
{
    class AcessoDados
    {
        #region Atributos

        private SqlConnection conexao = new SqlConnection(@"Data Source=KAUE-PC\;Initial Catalog=Megatechdatabase;Integrated Security=True");
        private SqlDataAdapter dAdap;

        #endregion Atributos

        #region Metodos

        #region Conecta Banco
        /// <summary>
        /// Abre a conexão com o banco de dados.
        /// </summary>
        /// <returns>Caso true a conexão foi aberta com sucesso.</returns>
        public bool ConectaBanco()
        {
            try
            {
                //TODO: Descobrir forma melhor de abrir uma conexão com o banco de dados.
                //-----------------------------------------------------------------------
                conexao.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion Conecta Banco

        #region Desconecta Banco
        /// <summary>
        /// Desconecta do Banco de dados.
        /// </summary>
        /// <returns>Caso true que a desconecção foi feita com sucesso.</returns>
        public bool DesconectaBanco()
        {
            try
            {
                conexao.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conexao.Dispose();
                conexao = null;
            }
        }
        #endregion Desconecta Banco

        #region Execute Sql
        /// <summary>
        /// Executa a query
        /// </summary>
        /// <param name="query">query desejada</param>
        /// <returns>DataTable populado com o retorno do banco de dados</returns>
        public DataTable ExecuteSql(string query)
        {
            DataTable dtRetorno = new DataTable();
            try
            {
                dAdap = new SqlDataAdapter(query, conexao);
                dAdap.Fill(dtRetorno);
                return dtRetorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dtRetorno.Dispose();
                dtRetorno = null;
                dAdap.Dispose();
                dAdap = null;
            }
        }
        #endregion Execute Sql

        #endregion Metodos
    }
}
