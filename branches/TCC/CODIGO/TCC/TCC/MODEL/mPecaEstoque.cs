using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    class mPecaEstoque
    {
        private int id_peca;
        private int id_estoq;
        private bool flg_alt;
        private DateTime dat_alt;
        private int? qtd_peca;
        private string nometabela = "PecaEstoque";

        [ColunasBancoDados("Id_peca", System.Data.SqlDbType.Int, true)]
        public int Id_peca
        {
            get { return id_peca; }
            set { id_peca = value; }
        }
        [ColunasBancoDados("Id_estoq", System.Data.SqlDbType.Int, true)]
        public int Id_estoq
        {
            get { return id_estoq; }
            set { id_estoq = value; }
        }
        [ColunasBancoDados("Flg_alt", System.Data.SqlDbType.Bit, false)]
        public bool Flg_alt
        {
            get { return flg_alt; }
            set { flg_alt = value; }
        }
        [ColunasBancoDados("Dat_alt", System.Data.SqlDbType.DateTime, false)]
        public DateTime Dat_alt
        {
            get { return dat_alt; }
            set { dat_alt = value; }
        }
        [ColunasBancoDados("Qtd_peca", System.Data.SqlDbType.Int, false)]
        public int? Qtd_peca
        {
            get { return qtd_peca; }
            set { qtd_peca = value; }
        }
        public override string getNomeTabela()
        {
            return this.nomeTabela;
        }
    }
}
