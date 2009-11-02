using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    class mItemKit : ModelPai
    {

        private int? id_item;
        private int? id_kit;
        private DateTime dat_alt;
        private bool flg_ativo;
        private string nomeTabela = "Itemkit";

        [ColunasBancoDados("Dat_alt", System.Data.SqlDbType.Int, false)]
        public DateTime Dat_alt
        {
            get { return dat_alt; }
            set { dat_alt = value; }
        }

        [ColunasBancoDados("Flg_ativo", System.Data.SqlDbType.Int, false)]
        public bool Flg_ativo
        {
            get { return flg_ativo; }
            set { flg_ativo = value; }
        }

        [ColunasBancoDados("Id_kit", System.Data.SqlDbType.Int, true)]
        public int? Id_kit
        {
            get { return id_kit; }
            set { id_kit = value; }
        }

        [ColunasBancoDados("Id_item", System.Data.SqlDbType.Int, true)]
        public int? Id_item
        {
            get { return id_item; }
            set { id_item = value; }
        }



        public override string getNomeTabela()
        {
            return this.nomeTabela;
        }
    }
}
