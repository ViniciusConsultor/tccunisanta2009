using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    public class mItemPeca : ModelPai
    {
        private int id_item_peca;
        private string nom_item_peca;
        private int id_peca;
        private bool flg_ativo;
        private string nomeTabela = "Itempeca";

        [ColunasBancoDados("id_item_peca", System.Data.SqlDbType.Int,true)]
        public int Id_item_peca
        {
            get { return id_item_peca; }
            set { id_item_peca = value; }
        }

        [ColunasBancoDados("nom", System.Data.SqlDbType.VarChar,false)]
        public string Nom_item_peca
        {
            get { return nom_item_peca; }
            set { nom_item_peca = value; }
        }

        [ColunasBancoDados("id_peca", System.Data.SqlDbType.VarChar,true)]
        public int Id_peca
        {
            get { return id_peca; }
            set { id_peca = value; }
        }

        [ColunasBancoDados("flg_ativo", System.Data.SqlDbType.Bit,false)]
        public bool Flg_ativo
        {
            get { return flg_ativo; }
            set { flg_ativo = value; }
        }

        public override string getNomeTabela()
        {
            return this.nomeTabela;
        }
    }
}
