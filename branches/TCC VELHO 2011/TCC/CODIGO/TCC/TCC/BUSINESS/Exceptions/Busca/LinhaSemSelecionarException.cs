using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.BUSINESS.Exceptions.Busca
{
    public class LinhaSemSelecionarException : Exception
    {
        string _mensagem;

        public string Mensagem
        {
            get { return _mensagem; }
        }

        public LinhaSemSelecionarException()
        {
            this._mensagem = "É Necessário Selecionar uma Linha";
        }
    }
}
