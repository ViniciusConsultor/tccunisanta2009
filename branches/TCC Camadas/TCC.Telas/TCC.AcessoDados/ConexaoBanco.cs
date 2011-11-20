using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace TCC.AcessoDados
{
    public class ConexaoBanco
    {
        #region Propriedades
        private static SqlConnection conexao = new SqlConnection();

        public static SqlConnection Conexao
        {
            get { return conexao; }
        }
        #endregion Propriedades

        #region Metodos

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
        public static bool DesconectaBanco()
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
                if (conexao != null)
                {
                    conexao.Dispose();
                    conexao = null;
                }
            }
        }
        #endregion Desconecta Banco

        #endregion
    }
}
