using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace TCC.MODEL
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    class ColunasBancoDados : Attribute
    {
        #region Propriedades
        private string _nomeColuna;
        private SqlDbType _tipoColuna;
        private bool _chavePrimaria;
        
        /// <summary>
        /// Se é chave primária ou não
        /// </summary>
        public bool ChavePrimaria
        {
            get { return _chavePrimaria; }
            set { _chavePrimaria = value; }
        }

        /// <summary>
        /// Tipo da coluna
        /// </summary>
        public SqlDbType TipoColuna
        {
            get { return _tipoColuna; }
            set { _tipoColuna = value; }
        }

        /// <summary>
        /// Nome da coluna no banco de dados
        /// </summary>
        public string NomeColuna
        {
            get { return _nomeColuna; }
            set { _nomeColuna = value; }
        }

        
        

        #endregion Propriedades

        #region Construtor
        public ColunasBancoDados(string nomeColuna, SqlDbType tipoColuna, bool chavePrimaria)
        {
            this._nomeColuna = nomeColuna;
            this._tipoColuna = tipoColuna;
            this._chavePrimaria = chavePrimaria;
        }
        #endregion Construtor
    }
}
