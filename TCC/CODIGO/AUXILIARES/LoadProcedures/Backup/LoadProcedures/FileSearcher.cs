using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace LoadProcedures
{
    public class FileSearcher
    {
        #region Atributos
        private string[] _procedureFiles;
        private ArrayList _procedureQueries;
        private string _procedureDirectory;
        #endregion

        #region Propriedades
        public string[] ProcedureFiles
        {
            get { return _procedureFiles; }
        }

        public string ProcedureDirectory
        {
            get { return _procedureDirectory; }
            set { _procedureDirectory = value; }
        }
        #endregion

        #region Construtores
        public FileSearcher()
        {
            _procedureDirectory = Directory.GetCurrentDirectory();
            InitializeVariables();
        }

        public FileSearcher(string procedureFilesDirectory)
        {
            _procedureDirectory = procedureFilesDirectory;
            InitializeVariables();
        }
        #endregion

        #region Métodos

        private void InitializeVariables()
        {
            _procedureQueries = new ArrayList();

            try
            {
                LoadFiles();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Seach for files in input directory and keep them in this class
        /// </summary>
        private void LoadFiles()
        {
            try
            {
                this._procedureFiles = Directory.GetFiles(_procedureDirectory, "*.sql");

                foreach (string file in _procedureFiles)
                {
                    StreamReader reader = new StreamReader(file);
                    _procedureQueries.Add(reader.ReadToEnd());
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Get all files
        /// </summary>
        /// <returns>Returns all file names that belongs to the input directory</returns>
        public string[] GetProceduresFiles()
        {
            return this._procedureFiles;
        }

        public ArrayList GetProcedureQueries()
        {

            return this._procedureQueries;
        }
        #endregion
    }
}
