using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.BUSINESS.Exceptions.Validacoes
{
    public enum TipoErroData
    {
        dia,
        mes,
        ano
    }

    public class DataInvalidaException : Exception
    {
        TipoErroData _tipoErro;
        int[] _data;

        public TipoErroData TipoErro
        {
            get { return _tipoErro; }
        }

        public string DataErrada
        {
            get { return _data[0].ToString() + "/" + _data[1].ToString() + "/" + _data[2].ToString(); }
        }

        public DataInvalidaException(TipoErroData tipo, int[] dataErrada)
        {
            this._tipoErro = tipo;
            this._data = dataErrada;
        }
    }
}
