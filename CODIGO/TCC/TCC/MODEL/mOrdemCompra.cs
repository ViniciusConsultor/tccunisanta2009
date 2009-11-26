using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
   public class mOrdemCompra: ModelPai
    {
        private int id_peca;
        private decimal? ultim_preco;
        private int? id_ordem_compra;
        private int id_motor;
        private DateTime dat_alt;
        private bool flg_ativo;
        private string nota_fisc;
        private int id_forn;
        private int qtd;
        private string nomeTabela = "Ordemcompra";

        [ColunasBancoDados("Id_peca", System.Data.SqlDbType.Int, false)]
        public int Id_peca
        {
            get { return id_peca; }
            set { id_peca = value; }
        }

        [ColunasBancoDados("Ultim_preco", System.Data.SqlDbType.Decimal, false)]
        public decimal? Ultim_preco
        {
            get { return ultim_preco; }
            set { ultim_preco = value; }
        }

        [ColunasBancoDados("Id_ordem_compra", System.Data.SqlDbType.Int, true)]
        public int? Id_ordem_compra
        {
            get { return id_ordem_compra; }
            set { id_ordem_compra = value; }
        }

        [ColunasBancoDados("Id_motor", System.Data.SqlDbType.Int, false)]
        public int Id_motor
        {
            get { return id_motor; }
            set { id_motor = value; }
        }

        [ColunasBancoDados("Dat_alt", System.Data.SqlDbType.DateTime, false)]
        public DateTime Dat_alt
        {
            get { return dat_alt; }
            set { dat_alt = value; }
        }

        [ColunasBancoDados("id_compra", System.Data.SqlDbType.Int, false)]
        public bool Flg_ativo
        {
            get { return flg_ativo; }
            set { flg_ativo = value; }
        }

        [ColunasBancoDados("Nota_fisc", System.Data.SqlDbType.VarChar, false)]
        public string Nota_fisc
        {
            get { return nota_fisc; }
            set { nota_fisc = value; }
        }

        [ColunasBancoDados("Id_forn", System.Data.SqlDbType.Int, false)]
        public int Id_forn
        {
            get { return id_forn; }
            set { id_forn = value; }
        }

        [ColunasBancoDados("qtd", System.Data.SqlDbType.Int, false)]
        public int Qtd
        {
            get { return qtd; }
            set { qtd = value; }
        }

        public override string getNomeTabela()
        {
            return this.nomeTabela;
        }
     
    }
}
