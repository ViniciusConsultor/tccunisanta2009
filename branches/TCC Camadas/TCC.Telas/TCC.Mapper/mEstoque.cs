﻿using Kaue.Reflection;
using System;
using System.Collections.Generic;
using System.Text;

namespace TCC.Mapper
{
    public class mEstoque : ModelPai
    {
        private int? id_estoque;
        private string dsc_estoque;
        private DateTime dat_alt;
        private bool flg_ativo;
        private int id_depto;
        private bool flag_negativo;
        private string nomeTabela = "estoque";

        [ColunasBancoDados("id_estoq", System.Data.SqlDbType.Int, true)]
        public int? Id_estoque
        {
            get { return id_estoque; }
            set { id_estoque = value; }
        }

        [ColunasBancoDados("dsc_estoq", System.Data.SqlDbType.VarChar, false)]
        public string Dsc_estoque
        {
            get { return dsc_estoque; }
            set { dsc_estoque = value; }
        }

        [ColunasBancoDados("dat_alt", System.Data.SqlDbType.DateTime, false)]
        public DateTime Dat_alt
        {
            get { return dat_alt; }
            set { dat_alt = value; }
        }

        [ColunasBancoDados("flg_ativo", System.Data.SqlDbType.Bit, false)]
        public bool Flg_ativo
        {
            get { return flg_ativo; }
            set { flg_ativo = value; }
        }

        [ColunasBancoDados("id_depto", System.Data.SqlDbType.Int, false)]
        public int Id_depto
        {
            get { return id_depto; }
            set { id_depto = value; }
        }

        [ColunasBancoDados("flg_negativo", System.Data.SqlDbType.Bit, false)]
        public bool Flg_negativo
        {
            get { return flag_negativo; }
            set { flag_negativo = value; }
        }

        public override string getNomeTabela()
        {
            return this.nomeTabela;
        }
    }
}
