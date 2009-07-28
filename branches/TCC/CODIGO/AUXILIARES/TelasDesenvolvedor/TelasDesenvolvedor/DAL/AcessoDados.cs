using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace TelasDesenvolvedor.DAL
{
    class AcessoDados
    {
        #region Atributos

        
        private SqlDataAdapter dAdap;
        private SqlCommand comando;

        #endregion Atributos

        #region Metodos

        #region Execute Sql
        /// <summary>
        /// Executa a query
        /// </summary>
        /// <param name="query">query desejada</param>
        /// <returns>DataTable populado com o retorno do banco de dados</returns>
        protected DataTable ExecuteSql(string query)
        {
            DataTable dtRetorno = new DataTable();
            try
            {
                dAdap = new SqlDataAdapter(query, ConectaBanco.Conexao);
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

        protected bool InsereDados(string query)
        {
            try
            {
                comando = new SqlCommand(query, ConectaBanco.Conexao);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                comando = null;
            }
        }

        #endregion Metodos
    }
}
