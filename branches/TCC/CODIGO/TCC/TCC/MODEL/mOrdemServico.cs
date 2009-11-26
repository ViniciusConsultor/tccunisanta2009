using System;
using System.Collections.Generic;
using System.Text;

namespace TCC.MODEL
{
    public class mOrdemServico : ModelPai
    {
        private int idOrdemServ;
        private int? idVenda;
        private int? idCompra;
        private string nomeTabela = "Ordemservico";

        [ColunasBancoDados ("id_ordem_serv", System.Data.SqlDbType.Int, true)]
        public int IdOrdemServ
        {
            get { return idOrdemServ; }
            set { idOrdemServ = value; }
        }

        [ColunasBancoDados ("id_venda", System.Data.SqlDbType.Int, false)]
        public int? IdVenda
        {
            get { return idVenda; }
            set { idVenda = value; }
        }

        [ColunasBancoDados ("id_compra", System.Data.SqlDbType.Int, false)]
        public int? IdCompra
        {
            get { return idCompra; }
            set { idCompra = value; }
        }

        public override string getNomeTabela()
        {
            return this.nomeTabela;
        }
    }
}
