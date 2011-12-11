using System;
using System.Collections.Generic;
using System.Text;

namespace TCC.BUSINESS.Exceptions.Validacoes
{
    public class MaskedInvalidaException : Exception
    {
        string _mensagem;

        public string Mensagem
        {
            get { return _mensagem; }
        }

        public MaskedInvalidaException(BUSINESS.UTIL.TipoMasked TipoMasked)
        {
            _mensagem = "Campo " + TipoMasked.ToString() + " incompleto!";
        }
    }
}
