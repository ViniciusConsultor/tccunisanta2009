using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    class mTipoPeca : ModelPai
    {
        private int idTipoPeca;
        private string dscTipoPeca;
        private bool flgAtivo;
        private string nomeTabela = "Tipodepeca";

        [ColunasBancoDados("id_tipo_peca", System.Data.SqlDbType.Int, true)]
        public int IdTipoPeca
        {
            get { return idTipoPeca; }
            set { idTipoPeca = value; }
        }

        [ColunasBancoDados("dsc_tipo_peca", System.Data.SqlDbType.VarChar, false)]
        public string DscTipoPeca
        {
            get { return dscTipoPeca; }
            set { dscTipoPeca = value; }
        }

        [ColunasBancoDados("flg_ativo", System.Data.SqlDbType.Bit, false)]
        public bool FlgAtivo
        {
            get { return flgAtivo; }
            set { flgAtivo = value; }
        }

        public override string getNomeTabela()
        {
            return this.nomeTabela;
        }
    }
}
