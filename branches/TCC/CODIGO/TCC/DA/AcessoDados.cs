using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace TCC.DA
{
    public class AcessoDados
    {
        #region Atributos

        private SqlConnection conexao;
        private SqlDataAdapter dAdap;

        #endregion Atributos

        #region Metodos
        
        #region Conecta Banco
        /// <summary>
        /// Instancia e abre a conexão com o banco de dados.
        /// </summary>
        /// <returns>Caso true a conexão foi aberta com sucesso.</returns>
        public bool ConectaBanco()
        {
            bool retorno = true;
            try
            {
                conexao = new SqlConnection(@"Data Source=KAUE-PC\SQLEXPRESS;Initial Catalog=TesteMenu;Integrated Security=True;Pooling=False");
                //TODO: Descobrir forma melhor de abrir uma conexão com o banco de dados.
                //-----------------------------------------------------------------------
                conexao.Open();
            }
            catch (Exception ex)
            {
                throw ex;
                retorno = false;
            }
            return retorno;
        }
        #endregion Conecta Banco

        #region Desconecta Banco
        /// <summary>
        /// Desconecta do Banco de dados.
        /// </summary>
        /// <returns>Caso true que a desconecção foi feita com sucesso.</returns>
        public bool DesconectaBanco()
        {
            bool retorno = true;
            try
            {
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw ex;
                retorno = false;
            }
            finally
            {
                conexao.Dispose();
                conexao = null;
            }
            return retorno;
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
