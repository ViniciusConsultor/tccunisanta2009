﻿using Kaue.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.Mapper
{
    public class mItemPeca : ModelPai
    {
        private int? id_item;
        private int? id_peca;
        private bool flg_ativo;
        private DateTime dat_alt;
        private int qtd_peca;
        private string nomeTabela = "Itempeca";

        [ColunasBancoDados("Dat_alt", System.Data.SqlDbType.DateTime, false)]
        public DateTime Dat_alt
        {
            get { return dat_alt; }
            set { dat_alt = value; }
        }

        [ColunasBancoDados("id_item", System.Data.SqlDbType.Int,true)]
        public int? Id_item
        {
            get { return id_item; }
            set { id_item = value; }
        }


        [ColunasBancoDados("id_peca", System.Data.SqlDbType.Int,false)]
        public int? Id_peca
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
        [ColunasBancoDados("Qtd_peca", System.Data.SqlDbType.Int, false)]
        public int Qtd_peca
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
