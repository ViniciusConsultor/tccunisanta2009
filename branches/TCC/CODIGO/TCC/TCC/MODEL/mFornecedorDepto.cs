using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    public class mFornecedorDepto : ModelPai
    {
        private int idDepto;
        private int idFornecedor;
        private DateTime datAtl;
        private bool flgAtivo;
        private string nomeTabela = "Fornecedordepto";

        [ColunasBancoDados ("id_depto", System.Data.SqlDbType.Int,true)]
        public int IdDepto
        {
            get { return idDepto; }
            set { idDepto = value; }
        }

        [ColunasBancoDados ("id_forn", System.Data.SqlDbType.Int,true)]
        public int IdFornecedor
        {
            get { return idFornecedor; }
            set { idFornecedor = value; }
        }

        [ColunasBancoDados ("dat_alt", System.Data.SqlDbType.DateTime,false)]
        public DateTime DatAtl
        {
            get { return datAtl; }
            set { datAtl = value; }
        }

        [ColunasBancoDados ("flg_ativo", System.Data.SqlDbType.Bit,false)]
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
