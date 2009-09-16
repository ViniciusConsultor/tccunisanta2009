using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using TCC.DAL;

namespace TCC.BUSINESS
{
    abstract class ComandosSql : AcessoDados
    {
        #region Busca Id Maximo Tabelas
        /// <summary>
        /// Busca o id Maximo da tabela passada por parametro.
        /// </summary>
        /// <param name="idTabela">campo que é o id da Tabela</param>
        /// <param name="tabela">nome da tabela que vai ser buscada</param>
        /// <returns>DataTable com o número do id(max); Caso id não exista retorna nulo</returns>
        public DataTable BuscaIdMaximoTabelas(string idTabela, string tabela)
        {
            SqlParameter[] param = new SqlParameter[2];
            try
            {
                param[0] = new SqlParameter("@nome_tabela", tabela);
                param[0].SqlDbType = SqlDbType.VarChar;
                param[1] = new SqlParameter("@campo_tabela", idTabela);
                param[1].SqlDbType = SqlDbType.VarChar;
                return base.BuscaDados("sp_busca_maxId", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                param = null;
            }
        }
        #endregion Busca Id Maximo Tabelas

        public abstract void Insere(object model);
        public abstract void ValidarInsere(object model);
        public abstract void Deleta(object model);
        public abstract void ValidarDeleta(object model);
        public abstract void Altera(object model);
        public abstract void ValidarAltera(object model);
    }
}
