using System;
using System.Collections.Generic;
using System.Text;

namespace TelasDesenvolvedor.MODEL
{
    class mDepartamento
    {
        private int _idDepto;
        private string _dscDepto;
        private DateTime _datAtl;
        private bool _flgAtivo;

        [ColunasBancoDados("flg_ativo", System.Data.SqlDbType.VarChar)]
        public bool FlgAtivo
        {
            get { return true; }
            set { _flgAtivo = value; }
        }

        [ColunasBancoDados("dat_atl", System.Data.SqlDbType.VarChar)]
        public DateTime DatAtl
        {
            get { return DateTime.Now; }
            set { _datAtl = value; }
        }

        [ColunasBancoDados("dsc_depto", System.Data.SqlDbType.VarChar)]
        public string DscDepto
        {
            get { return _dscDepto; }
            set { _dscDepto = value; }
        }

        [ColunasBancoDados("id_depto", System.Data.SqlDbType.Int)]
        public int IdDepto
        {
            get { return _idDepto; }
            set { _idDepto = value; }
        }
    }
}
