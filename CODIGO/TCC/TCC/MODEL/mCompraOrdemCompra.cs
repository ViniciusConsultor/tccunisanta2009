﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
   public class mCompraOrdemCompra: ModelPai
    {
        private int? id_compra;
        private int qtd;
        private int? id_ordem_compra;
        private DateTime dar_alt;
        private bool flg_ativo;
        private string nomeTabela = "Compraordemcompra";

        [ColunasBancoDados("Id_compra", System.Data.SqlDbType.Int, true)]
        public int? Id_compra
        {
          get { return id_compra; }
          set { id_compra = value; }
        }

       [ColunasBancoDados("Qtd", System.Data.SqlDbType.Int, false)]
        public int Qtd
        {
          get { return qtd; }
          set { qtd = value; }
        }

       [ColunasBancoDados("Id_ordem_compra", System.Data.SqlDbType.Int, true)]
        public int? Id_ordem_compra
        {
          get { return id_ordem_compra; }
          set { id_ordem_compra = value; }
        }

       [ColunasBancoDados("Dar_alt", System.Data.SqlDbType.DateTime, false)]
        public DateTime Dar_alt
        {
          get { return dar_alt; }
          set { dar_alt = value; }
        }

       [ColunasBancoDados("Flg_ativo", System.Data.SqlDbType.Bit, false)]
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
