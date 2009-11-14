using System;
using System.Collections.Generic;
using System.Text;

namespace TCC.MODEL
{
    public class mDepartamento : ModelPai
    {
        private int? _idDepto;
        private string _nmDepto;
        private string _dscDepto;
        private DateTime _datAtl;
        private bool _flgAtivo;
        private string _nomeDepto;
        private string nomeTabela = "departamento";

        [ColunasBancoDados("flg_ativo", System.Data.SqlDbType.VarChar, false)]
        public bool FlgAtivo
        {
            get { return true; }
            set { _flgAtivo = value; }
        }

        [ColunasBancoDados("nom_depto", System.Data.SqlDbType.VarChar, false)]
        public string NmDepto
        {
            get { return _nmDepto; }
            set { _nmDepto = value; }
        }

        [ColunasBancoDados("dat_atl", System.Data.SqlDbType.VarChar, false)]
        public DateTime DatAtl
        {
            get { return DateTime.Now; }
            set { _datAtl = value; }
        }

        [ColunasBancoDados("dsc_depto", System.Data.SqlDbType.VarChar, false)]
        public string DscDepto
        {
            get { return _dscDepto; }
            set { _dscDepto = value; }
        }

        [ColunasBancoDados("id_depto", System.Data.SqlDbType.Int, true)]
        public int? IdDepto
        {
            get { return _idDepto; }
            set { _idDepto = value; }
        }

        [ColunasBancoDados("nom", System.Data.SqlDbType.VarChar, false)]
        public string NomeDepto
        {
            get { return _nomeDepto; }
            set { _nomeDepto = value; }
        }

        public override string getNomeTabela()
        {
            return nomeTabela;
        }
    }
}
