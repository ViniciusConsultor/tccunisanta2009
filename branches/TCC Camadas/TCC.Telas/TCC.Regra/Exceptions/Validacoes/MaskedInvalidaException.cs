using System;
using System.Collections.Generic;
using System.Text;

namespace TCC.Regra.Exceptions.Validacoes
{
    public class MaskedInvalidaException : Exception
    {
        string _mensagem;

        public string Mensagem
        {
            get { return _mensagem; }
        }

        public MaskedInvalidaException(Regra.Util.TipoMasked TipoMasked)
        {
            _mensagem = "Campo " + TipoMasked.ToString() + " incompleto!";
        }
    }
}
