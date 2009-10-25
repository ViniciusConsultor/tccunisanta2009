using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.BUSINESS.Exceptions.Busca
{
    public class SemBuscaESelecionarException : Exception
    {
        string _mensagem;

        public string Mensagem
        {
            get { return _mensagem; }
        }

        public SemBuscaESelecionarException(string nomeTabela)
        {
            this._mensagem = "É necessário buscar e selecionar um " + nomeTabela;
        }
    }
}
