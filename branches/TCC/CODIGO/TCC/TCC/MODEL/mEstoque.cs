using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    class mEstoque
    {
        private int id_estoque;
        private string nom_estoque;
        private DateTime dat_alt;
        private bool flg_ativo;
        private int id_depto;

        [ColunasBancoDados("id_estoque", System.Data.SqlDbType.Int)]
        public int Id_estoque
        {
            get { return id_estoque; }
            set { id_estoque = value; }
        }

        [ColunasBancoDados("nom_estoque", System.Data.SqlDbType.VarChar)]
        public string Nom_estoque
        {
            get { return nom_estoque; }
            set { nom_estoque = value; }
        }

        [ColunasBancoDados("dat_alt", System.Data.SqlDbType.DateTime)]
        public DateTime Dat_alt
        {
            get { return dat_alt; }
            set { dat_alt = value; }
        }

        [ColunasBancoDados("flg_ativo", System.Data.SqlDbType.Bit)]
        public bool Flg_ativo
        {
            get { return flg_ativo; }
            set { flg_ativo = value; }
        }

        [ColunasBancoDados("id_depto", System.Data.SqlDbType.Int)]
        public int Id_depto
        {
            get { return id_depto; }
            set { id_depto = value; }
        }

    }
}
