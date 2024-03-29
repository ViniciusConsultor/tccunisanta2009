﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;
using Kaue.Reflection;
using TCC.AcessoDados;
using TCC.Mapper;

namespace TCC.Regra
{
    public enum TipoComando
    {
        insert,
        delete,
        update
    }

    public abstract class ComandoSql
    {
        private AcessoDados.AcessoDados objAcesso = new TCC.AcessoDados.AcessoDados();

        public abstract void ValidarInsere(ModelPai model);
        public abstract void ValidarDeleta(ModelPai model);
        public abstract void ValidarAltera(ModelPai model);

        private const string INICIO_PROC_INSERIR = "sp_insert_";
        private const string INICIO_PROC_ALTERAR = "sp_update_";
        private const string INICIO_PROC_EXCLUIR = "sp_delete_";
        private const string INICIO_PROC_BUSCAR = "sp_select_";

        #region Busca Id Maximo Tabelas

        /// <summary>
        /// Busca o id Maximo da tabela passada por parametro.
        /// </summary>
        /// <param name="idTabela">campo que é o id da Tabela</param>
        /// <param name="tabela">nome da tabela que vai ser buscada</param>
        /// <returns>DataTable com o número do id(max); Caso id não exista retorna nulo</returns>
        public string BuscaIdMaximoTabelas(string idTabela, string tabela)
        {
            SqlParameter[] param = new SqlParameter[2];
            DataTable dtId;
            int id;
            try
            {
                param[0] = new SqlParameter("@nome_tabela", tabela);
                param[0].SqlDbType = SqlDbType.VarChar;
                param[1] = new SqlParameter("@campo_tabela", idTabela);
                param[1].SqlDbType = SqlDbType.VarChar;
                dtId = objAcesso.BuscaDados("sp_busca_maxId", param);
                if (dtId.Rows[0]["max"] == DBNull.Value || dtId.Rows[0]["max"] == null)
                {
                    id = 0;
                }
                else
                {
                    id = Convert.ToInt32(dtId.Rows[0]["max"]);
                }
                ++id;
                return id.ToString();
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


        #region Busca Nome Parametros

        /// <summary>
        /// Varre o nome dos Parametros que estão no model através dos atributos
        /// </summary>
        /// <returns>Array de SqlParameter com os parametros para as procedures</returns>
        protected SqlParameter[] BuscaNomeParametros(ModelPai modelo, TipoComando tipoCom)
        {
            Type tipo = modelo.GetType();
            SqlParameter[] param = new SqlParameter[tipo.GetProperties().Length];
            object[] cols;
            object valor;
            PropertyInfo[] prop;
            try
            {
                prop = tipo.GetProperties();
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
                        if (tipoCom == TipoComando.insert)
                        {
                            if (colunas.ChavePrimaria == true && prop[contador].GetValue(modelo, null) == null)
                            {
                                continue;
                            }
                        }
                        valor = prop[contador].GetValue(modelo, null);
                        if (valor == null)
                            valor = DBNull.Value;
                        param[contador] = new SqlParameter("@" + colunas.NomeColuna, valor);
                    }
                }
                return this.AjustaTamanhoArray(param);
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
                valor = null;
            }
        }

        #endregion Busca Nome Parametros

        #region Busca Nome Parametros Chave Primaria

        /// <summary>
        /// Busca os parametros que são Chave Primaria
        /// </summary>
        /// <param name="tipo">Tipo do model</param>
        /// <param name="modelo">Model</param>
        /// <returns>os Parametros que são chave primaria</returns>
        private SqlParameter[] BuscaNomeParametrosChavePrimaria(ModelPai modelo)
        {
            Type tipo = modelo.GetType();
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            SqlParameter[] param = null;
            object[] cols;
            PropertyInfo[] prop;
            try
            {
                prop = tipo.GetProperties();
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
                        if (colunas.ChavePrimaria == true)
                        {
                            listaParametros.Add(new SqlParameter("@" + colunas.NomeColuna, prop[contador].GetValue(modelo, null)));
                        }
                    }
                }
                param = new SqlParameter[listaParametros.Count];
                for (int con = 0; con < listaParametros.Count; con++)
                {
                    param[con] = listaParametros[con];
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

        #endregion Busca Nome Parametros Chave Primaria

        #region Insere

        /// <summary>
        /// Insere os dados no banco.
        /// </summary>
        /// <param name="model">Model com os dados e a tabela a ser inserido</param>
        public void Insere(ModelPai model)
        {
            this.ExecutaComandoSql(model, TipoComando.insert);
        }

        #endregion Insere

        #region Deleta
        /// <summary>
        /// Delete os dados no banco.
        /// </summary>
        /// <param name="model">Model com os dados e a tabela a ser Deletado</param>
        public void Deleta(ModelPai model)
        {
            this.ExecutaComandoSql(model, TipoComando.delete);
        }
        #endregion Deleta

        #region Altera
        /// <summary>
        /// Altera os dados no banco.
        /// </summary>
        /// <param name="model">Model com os dados e a tabela a ser Alterado</param>
        public void Altera(ModelPai model)
        {
            this.ExecutaComandoSql(model, TipoComando.update);
        }
        #endregion Altera

        #region Busca

        /// <summary>
        /// Busca apenas um registro do banco
        /// </summary>
        /// <param name="model">Model com os dados e a tabela a ser buscado</param>
        public DataTable BuscaUmRegistro(ModelPai model)
        {
            SqlParameter[] parametros = null;
            try
            {
                parametros = this.BuscaNomeParametrosChavePrimaria(model);
                string nomeProc = INICIO_PROC_BUSCAR + model.getNomeTabela();
                return this.objAcesso.BuscaDados(nomeProc, parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion Busca

        #region Executa Comando Sql
        public void ExecutaComandoSql(ModelPai model, TipoComando com)
        {
            string nomeProc = "";
            SqlParameter[] parametros = null;
            try
            {
                switch (com)
                {
                    case TipoComando.insert:
                        parametros = this.BuscaNomeParametros(model, com);
                        nomeProc = INICIO_PROC_INSERIR + model.getNomeTabela();
                        break;
                    case TipoComando.update:
                        parametros = this.BuscaNomeParametros(model, com);
                        nomeProc = INICIO_PROC_ALTERAR + model.getNomeTabela();
                        break;

                    case TipoComando.delete:
                        parametros = this.BuscaNomeParametrosChavePrimaria(model);
                        nomeProc = INICIO_PROC_EXCLUIR + model.getNomeTabela();
                        break;



                }
                this.objAcesso.ExecutaProcedure(nomeProc, parametros);
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
        #endregion Executa Comando Sql

        private SqlParameter[] AjustaTamanhoArray(SqlParameter[] parametros)
        {
            SqlParameter[] param;
            try
            {
                int tamanhoArrayCorreto = 0;
                int contadorCorreto = 0;
                //Varre o parametro para verificar o tamanho correto dele
                //-------------------------------------------------------
                for (int contador = 0; contador < parametros.Length; contador++)
                {
                    if (parametros[contador] != null)
                    {
                        tamanhoArrayCorreto++;
                    }
                }
                param = new SqlParameter[tamanhoArrayCorreto];
                //Varre atribuindo os valores de um para outro tirando o valor nulo
                for (int con = 0; con < parametros.Length; con++)
                {
                    if (parametros[con] != null)
                    {
                        param[contadorCorreto] = parametros[con];
                        contadorCorreto++;
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
            }
        }

        public DataTable BuscaDados(string nomeProc)
        {
            try
            {
                return this.objAcesso.BuscaDados(nomeProc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable BuscaDados(string nomeProc, SqlParameter parametro)
        {
            try
            {
                return this.objAcesso.BuscaDados(nomeProc, parametro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable BuscaDados(string nomeProc, SqlParameter[] parametros)
        {
            try
            {
                return this.objAcesso.BuscaDados(nomeProc, parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
