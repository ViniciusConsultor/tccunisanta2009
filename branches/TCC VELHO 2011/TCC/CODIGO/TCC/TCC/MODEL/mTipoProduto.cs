using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    public class mTipoProduto : ModelPai
    {
        private int? idTipoProd;
        private string nom;
        private bool flgAtivo;
        private DateTime datAlt;
        private string nomeTabela = "Tipoproduto";

        [ColunasBancoDados ("id_tipo_prod", System.Data.SqlDbType.Int,true)]
        public int? IdTipoProd
        {
            get { return idTipoProd; }
            set { idTipoProd = value; }
        }

        [ColunasBancoDados ("nom", System.Data.SqlDbType.VarChar,false)]
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        [ColunasBancoDados ("flg_ativo", System.Data.SqlDbType.Bit,false)]
        public bool FlgAtivo
        {
            get { return flgAtivo; }
            set { flgAtivo = value; }
        }

        [ColunasBancoDados ("dat_alt", System.Data.SqlDbType.DateTime,false)]
        public DateTime DatAlt
        {
            get { return datAlt; }
            set { datAlt = value; }
        }

        public override string getNomeTabela()
        {
            return this.nomeTabela;
        }
    }
}
