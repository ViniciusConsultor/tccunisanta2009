using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Collections;

namespace LoadProcedures
{
    public class DBAccess : IDisposable
    {
        #region Atributos

        private string _connectionString;
        private OleDbCommand _dbComando;
        private OleDbConnection _dbConexao;
        private OleDbTransaction _dbTransacao;
        private static DBAccess _uniqueInstance = new DBAccess();

        #endregion

        #region Propriedades
        public string ConnectionString
        {
            get { return _connectionString; }
            set
            {
                _connectionString = value;
                try
                {
                    _dbConexao.ConnectionString = _connectionString;
                    Connect();
                    Disconnect();
                }
                catch (OleDbException e)
                {
                    _connectionString = string.Empty;
                    throw e;
                }
            }
        }
        #endregion

        #region Construtor Privado
        private DBAccess()
        {
            _dbConexao = new OleDbConnection();

            _dbComando = new OleDbCommand();
            _dbComando.CommandType = System.Data.CommandType.Text;
            _dbComando.Connection = _dbConexao;
        }
        #endregion

        #region GetInstance retorna Instância da Classe
        public static DBAccess GetInstance()
        {
            return _uniqueInstance;
        }
        #endregion

        #region Métodos
        private void Connect()
        {
            try
            {
                _dbConexao.Open();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void Disconnect()
        {
            try
            {
                _dbConexao.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Execute(string sqlQuery)
        {
            try
            {
                _dbComando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void ExecuteBatch(ArrayList sqlQueryList)
        {
            string[] queryParts = null;
            string[] separator = { "\r\nGO", "\r\nGo", "\r\ngO", "\r\ngo", "\r\n GO", "\r\n Go", "\r\n gO", "\r\n go" };

            try
            {
                Connect();
                foreach (string query in sqlQueryList)
                {
                    queryParts = query.Split(separator, StringSplitOptions.None);
                    _dbTransacao = _dbConexao.BeginTransaction();

                    try
                    {
                        foreach (string queryPart in queryParts)
                        {
                            _dbComando.Transaction = _dbTransacao;
                            _dbComando.CommandText = queryPart;
                            Execute(query);
                        }

                        _dbTransacao.Commit();
                    }
                    catch (Exception e) //debug
                    {
                        _dbTransacao.Rollback();
                    }

                }
                Disconnect();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            if (_dbConexao != null)
            {
                Disconnect();
                _dbConexao.Dispose();
            }

            if (_dbComando != null)
            {
                _dbComando.Dispose();
            }

        }

        #endregion
    }
}
