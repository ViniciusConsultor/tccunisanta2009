using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace TCC.DAL
{
    class ConectaBanco
    {
        #region Propriedades
        private static SqlConnection conexao = new SqlConnection();

        public static SqlConnection Conexao
        {
            get { return conexao; }
        } 
        #endregion Propriedades

        #region Conecta Banco
        /// <summary>
        /// Abre a conexão com o banco de dados.
        /// </summary>
        /// <returns>Caso true a conexão foi aberta com sucesso. Caso contrário false</returns>
        public static bool ConectaBancoDados()
        {
            ConnectionStringSettings settConex = ConfigurationManager.ConnectionStrings["TCC.Properties.Settings.MegatechConnectionString"];
            try
            {
                conexao.ConnectionString = settConex.ConnectionString;
                //TODO: Descobrir forma melhor de abrir uma conexão com o banco de dados.
                //-----------------------------------------------------------------------
                conexao.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                settConex = null;
            }
        }
        #endregion Conecta Banco

        #region Desconecta Banco
        /// <summary>
        /// Desconecta do Banco de dados.
        /// </summary>
        /// <returns>Caso true que a desconecção foi feita com sucesso.</returns>
        protected static bool DesconectaBanco()
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

    }
}
