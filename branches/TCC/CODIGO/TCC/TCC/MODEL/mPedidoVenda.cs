﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    public class mPedidoVenda : ModelPai
    {
        private int idVenda;
        private int idPedido;
        private int idDepto;
        private string dscVenda;
        private DateTime datAlt;
        private string nomeTabela = "Pedidovenda";
        
        [ColunasBancoDados ("id_pedido", System.Data.SqlDbType.Int,true)]
        public int IdVenda
        {
            get { return idVenda; }
            set { idVenda = value; }
        }

        [ColunasBancoDados ("id_pedido", System.Data.SqlDbType.Int,false)]
        public int IdPedido
        {
            get { return idPedido; }
            set { idPedido = value; }
        }

        [ColunasBancoDados ("id_depto", System.Data.SqlDbType.Int,false)]
        public int IdDepto
        {
            get { return idDepto; }
            set { idDepto = value; }
        }

        [ColunasBancoDados ("dsc_venda", System.Data.SqlDbType.VarChar,false)]
        public string DscVenda
        {
            get { return dscVenda; }
            set { dscVenda = value; }
        }

        [ColunasBancoDados ("dat_alt", System.Data.SqlDbType.DateTime,false)]
        public DateTime DatAlt
        {
            get { return datAlt; }
            set { datAlt = value; }
        }

        public override string getNomeTabela()
        {
            return this.nomeTabela;
        }
    }
}