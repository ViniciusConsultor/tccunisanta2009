using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    class mOrdemProducaoo : ModelPai
    {
        private int idOrdemProd;
        private int idStatOrdem;
        private int idVenda;
        private int idUsu;


        [ColunasBancoDados("id_ordem_prod", System.Data.SqlDbType.Int, true)]
        public int IdOrdemProd
        {
            get { return idOrdemProd; }
            set { idOrdemProd = value; }
        }

        [ColunasBancoDados("id_stat_ordem", System.Data.SqlDbType.Int, true)]
        public int IdStatOrdem
        {
            get { return idStatOrdem; }
            set { idStatOrdem = value; }
        }

        [ColunasBancoDados("id_venda", System.Data.SqlDbType.Int, true)]
        public int IdVenda
        {
            get { return idVenda; }
            set { idVenda = value; }
        }

        [ColunasBancoDados("id_usu", System.Data.SqlDbType.Int, true)]
        public int IdUsu
        {
            get { return idUsu; }
            set { idUsu = value; }
        }


        public override string getNomeTabela()
        {
            return "Ordemproducao";
        }
    }
}
