using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    public class mVendaProduto : ModelPai
    {
        private int? idVenda;
        private bool flgAtivo;
        private DateTime datAlt;
        private int qtd;
        private int idProduto;
        private string nomeTabela = "Vendaproduto";

        [ColunasBancoDados("id_venda", System.Data.SqlDbType.Int, true)]
        public int? IdVenda
        {
            get { return idVenda; }
            set { idVenda = value; }
        }

        [ColunasBancoDados("flg_ativo", System.Data.SqlDbType.Bit, false)]
        public bool FlgAtivo
        {
            get { return flgAtivo; }
            set { flgAtivo = value; }
        }

        [ColunasBancoDados("dat_alt", System.Data.SqlDbType.DateTime, false)]
        public DateTime DatAlt
        {
            get { return datAlt; }
            set { datAlt = value; }
        }

        [ColunasBancoDados("qtd", System.Data.SqlDbType.Int, true)]
        public int Qtd
        {
            get { return qtd; }
            set { qtd = value; }
        }

        [ColunasBancoDados("id_prdto", System.Data.SqlDbType.Int, false)]
        public int IdProduto
        {
            get { return idProduto; }
            set { idProduto = value; }
        }

        public override string getNomeTabela()
        {
            return nomeTabela;
        }
    }
}
