using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Reflection;
using TCC.DAL;
using TCC.MODEL;

namespace TCC.BUSINESS
{
    abstract class ComandosSql : AcessoDados
    {
        public abstract void ValidarInsere(ModelPai model);
        public abstract void ValidarDeleta(ModelPai model);
        public abstract void ValidarAltera(ModelPai model);

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

        Type _tipo;
        object _modelo;

        #region Busca Nome Parametros
        /// <summary>
        /// Varre o nome dos Parametros que estão no model através dos atributos
        /// </summary>
        /// <returns>Array de SqlParameter com os parametros para as procedures</returns>
        public SqlParameter[] BuscaNomeParametros(Type tipo, object modelo)
        {
            this._tipo = tipo;
            this._modelo = modelo;
            SqlParameter[] param = new SqlParameter[this._tipo.GetProperties().Length];
            object[] cols;
            PropertyInfo[] prop;
            try
            {
                prop = this._tipo.GetProperties();
                //Varre as propriedades
                //---------------------
                for (int contador = 0; contador < prop.Length; contador++)
                {
                    //Atribui os atributos de uma propriedade ao Array cols
                    //-----------------------------------------------------
                    cols = prop[contador].GetCustomAttributes(typeof(ColunasBancoDados), true);
                    if (cols.Length > 0)
                    {
                        ColunasBancoDados colunas = (ColunasBancoDados)cols[0];
                        param[contador] = new SqlParameter("@" + colunas.NomeColuna, prop[contador].GetValue(this._modelo, null));
                    }
                }
                return param;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                param = null;
                cols = null;
                prop = null;
            }
        }
        #endregion Busca Nome Parametros

        public void Insere(ModelPai model)
        {
            const string INICIONOMEPROC = "sp_insert_";
            string nomeProc;
            SqlParameter[] parametros = null;
            try
            {
                nomeProc = INICIONOMEPROC + model.getNomeTabela();
                parametros = this.BuscaNomeParametros(model.GetType(), model);
                base.ExecutaProcedure(nomeProc, parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                parametros = null;
            }
        }
    }
}
