using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace LoadProcedures
{
    public class Dispatcher
    {
        private DBAccess _dbAccess;
        private FileSearcher _fileSearcher;

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="dbConnectionString">String de conexão com o banco de dados incluindo Initial Catalog</param>
        public Dispatcher(string dbConnectionString)
        {
            try
            {
                _dbAccess = DBAccess.GetInstance();
                _dbAccess.ConnectionString = dbConnectionString;

                _fileSearcher = new FileSearcher();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="dbConnectionString">String de conexão com o banco de dados incluindo Initial Catalog</param>
        /// <param name="procedureFilesDirectory">Diretório que contém os arquivos .sql das procedures</param>
        public Dispatcher(string dbConnectionString, string procedureFilesDirectory)
        {
            try
            {
                _dbAccess = DBAccess.GetInstance();
                _dbAccess.ConnectionString = dbConnectionString;

                _fileSearcher = new FileSearcher(procedureFilesDirectory);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Inicia o processo de carregamento dos arquivos
        /// </summary>
        public void Start()
        {
            try
            {
                _dbAccess.ExecuteBatch(_fileSearcher.GetProcedureQueries());
                _dbAccess.Dispose();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
