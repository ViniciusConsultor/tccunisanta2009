using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.Regra.Exceptions.Busca
{
    public class CadastrarDadoException : Exception
    {
        string _mensagem;

        public string Mensagem
        {
            get { return _mensagem; }
        }

        public CadastrarDadoException(string nomeTabela)
        {
            this._mensagem = "É necessário cadastrar um " + nomeTabela;
        }
    }
}
