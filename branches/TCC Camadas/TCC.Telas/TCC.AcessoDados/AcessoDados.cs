﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace TCC.AcessoDados
{
    public class AcessoDados
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
        public DataTable ExecuteSql(string query)
        {
            DataTable dtRetorno = new DataTable();
            try
            {
                dAdap = new SqlDataAdapter(query, ConexaoBanco.Conexao);
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

        public void ExecutaProcedure(string nomeProc, SqlParameter parametros)
        {
            SqlParameter[] param = new SqlParameter[1];
            try
            {
                param[0] = parametros;
                this.ExecutaProcedure(nomeProc, param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                comando = null;
            }
        }

        public void ExecutaProcedure(string nomeProc, SqlParameter[] parametros)
        {
            try
            {
                comando = new SqlCommand();
                //comando = new SqlCommand(query, ConectaBanco.Conexao);
                comando.Connection = ConexaoBanco.Conexao;
                comando.CommandText = nomeProc;
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddRange(parametros);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                comando = null;
            }
        }

        public DataTable BuscaDados(string nomeProc)
        {
            SqlDataReader dataR;
            DataTable dt = new DataTable();
            try
            {
                comando = new SqlCommand();
                comando.Connection = ConexaoBanco.Conexao;
                comando.CommandText = nomeProc;
                comando.CommandType = CommandType.StoredProcedure;
                dataR = comando.ExecuteReader();
                dt.Load(dataR);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dataR = null;
                dt = null;
            }
        }

        public DataTable BuscaDados(string nomeProc, SqlParameter parametro)
        {
            SqlDataReader dataR;
            DataTable dt = new DataTable();
            try
            {
                comando = new SqlCommand();
                comando.Connection = ConexaoBanco.Conexao;
                comando.CommandText = nomeProc;
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(parametro);
                dataR = comando.ExecuteReader();
                dt.Load(dataR);
                dataR.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dataR = null;
                dt = null;
            }
        }

        public DataTable BuscaDados(string nomeProc, SqlParameter[] parametros)
        {
            SqlDataReader dataR;
            DataTable dt = new DataTable();
            try
            {
                comando = new SqlCommand();
                comando.Connection = ConexaoBanco.Conexao;
                comando.CommandText = nomeProc;
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddRange(parametros);
                dataR = comando.ExecuteReader();
                dt.Load(dataR);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dataR = null;
                dt = null;
            }
        }

        #endregion Metodos
    }
}