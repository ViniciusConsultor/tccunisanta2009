﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    public class mVenda : ModelPai
    {
        private int? idVenda;
        private int idCli;
        private DateTime? datVenda;
        private double? valor;
        private string notaFisc;
        private DateTime datSaida;
        private string nomeTabela = "Venda";

        [ColunasBancoDados ("id_venda", System.Data.SqlDbType.Int,true)]
        public int? IdVenda
        {
            get { return idVenda; }
            set { idVenda = value; }
        }

        [ColunasBancoDados ("id_cli", System.Data.SqlDbType.Int,false)]
        public int IdCli
        {
            get { return idCli; }
            set { idCli = value; }
        }

        [ColunasBancoDados ("dat_venda", System.Data.SqlDbType.DateTime,false)]
        public DateTime? DatVenda
        {
            get { return datVenda; }
            set { datVenda = value; }
        }

        [ColunasBancoDados ("valor", System.Data.SqlDbType.Decimal,false)]
        public double? Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        [ColunasBancoDados ("nota_fisc", System.Data.SqlDbType.VarChar,false)]
        public string NotaFisc
        {
            get { return notaFisc; }
            set { notaFisc = value; }
        }

        [ColunasBancoDados ("dat_saida", System.Data.SqlDbType.DateTime,false)]
        public DateTime DatSaida
        {
            get { return datSaida; }
            set { datSaida = value; }
        }

        public override string getNomeTabela()
        {
            return this.nomeTabela;
        }
    }
}
