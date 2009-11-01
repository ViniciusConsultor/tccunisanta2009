using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    public class mUsinagem : ModelPai
    {
        private int? idUsinagem;
        private bool flgStatus;
        private int idPeca;
        private DateTime dtaEnvio;
        private string nomeTabela = "Usinagem";

        [ColunasBancoDados ("id_usinagem", System.Data.SqlDbType.Int,true)]
        public int? IdUsinagem
        {
            get { return idUsinagem; }
            set { idUsinagem = value; }
        }

        [ColunasBancoDados ("flg_status", System.Data.SqlDbType.Bit,false)]
        public bool FlgStatus
        {
            get { return flgStatus; }
            set { flgStatus = value; }
        }

        [ColunasBancoDados ("id_peca", System.Data.SqlDbType.Int,false)]
        public int IdPeca
        {
            get { return idPeca; }
            set { idPeca = value; }
        }

        [ColunasBancoDados ("dta_envio", System.Data.SqlDbType.DateTime,false)]
        public DateTime DtaEnvio
        {
            get { return dtaEnvio; }
            set { dtaEnvio = value; }
        }

        public override string getNomeTabela()
        {
            return this.nomeTabela;
        }
    }
}
