using Kaue.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.Mapper
{
    public class mPecaFornecedor : ModelPai
    {
        private int? id_peca;
        private int? id_forn;
        private DateTime datInc;
        private bool flgAtivo;
        private string nomeTabela = "Pecafornecedor";


        [ColunasBancoDados ("id_peca", System.Data.SqlDbType.Int,true)]
        public int? Id_peca
        {
            get { return id_peca; }
            set { id_peca = value; }
        }

        [ColunasBancoDados ("id_forn", System.Data.SqlDbType.Int,true)]
        public int? Id_forn
        {
            get { return id_forn; }
            set { id_forn = value; }
        }

        [ColunasBancoDados ("dat_inc", System.Data.SqlDbType.DateTime,false)]
        public DateTime DatInc
        {
            get { return datInc; }
            set { datInc = value; }
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
