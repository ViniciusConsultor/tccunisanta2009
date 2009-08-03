using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace TelasDesenvolvedor.DAL
{
    class ConectaBanco
    {
        private static SqlConnection conexao = new SqlConnection(@"Data Source=Kaue-PC\;Initial Catalog=Megatechdatabase;Integrated Security=True");

        public static SqlConnection Conexao
        {
            get { return conexao; }
        }

        #region Conecta Banco
        /// <summary>
        /// Abre a conexão com o banco de dados.
        /// </summary>
        /// <returns>Caso true a conexão foi aberta com sucesso. Caso contrário false</returns>
        public static bool ConectaBancoDados()
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
