using Kaue.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.Mapper
{
   public class mCompraOrdemCompra: ModelPai
    {
        private int? id_compra;
        private int? id_ordem_compra;
        private DateTime dat_alt;
        private bool flg_ativo;
        private string nomeTabela = "Compraordemcompra";

        [ColunasBancoDados("Id_compra", System.Data.SqlDbType.Int, true)]
        public int? Id_compra
        {
          get { return id_compra; }
          set { id_compra = value; }
        }

       [ColunasBancoDados("Id_ordem_compra", System.Data.SqlDbType.Int, true)]
        public int? Id_ordem_compra
        {
          get { return id_ordem_compra; }
          set { id_ordem_compra = value; }
        }

       [ColunasBancoDados("Dat_alt", System.Data.SqlDbType.DateTime, false)]
        public DateTime Dat_alt
        {
          get { return dat_alt; }
          set { dat_alt = value; }
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
