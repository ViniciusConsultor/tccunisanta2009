using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    public class mKitGrupoPeca : ModelPai
    {
        private int id_grupo;
        private string nom_grupo;
        private bool flg_ativo;
        private int id_item_peca;
        private string id_peca;
        private DateTime dat_alt;
        private string nomeTabela = "Kitgrupopeca";

        [ColunasBancoDados ("id_grupo", System.Data.SqlDbType.Int,true)]
        public int Id_grupo
        {
            get { return id_grupo; }
            set { id_grupo = value; }
        }

        [ColunasBancoDados ("nom", System.Data.SqlDbType.VarChar,false)]
        public string Nom_grupo
        {
            get { return nom_grupo; }
            set { nom_grupo = value; }
        }

        [ColunasBancoDados ("flg_ativo", System.Data.SqlDbType.Bit,false)]
        public bool Flg_ativo
        {
            get { return flg_ativo; }
            set { flg_ativo = value; }
        }

        [ColunasBancoDados ("id_item_peca", System.Data.SqlDbType.Int,false)]
        public int Id_item_peca
        {
            get { return id_item_peca; }
            set { id_item_peca = value; }
        }

        [ColunasBancoDados ("id_peca", System.Data.SqlDbType.Int,false)]
        public string Id_peca
        {
            get { return id_peca; }
            set { id_peca = value; }
        }

        [ColunasBancoDados ("dat_alt", System.Data.SqlDbType.DateTime,false)]
        public DateTime Dat_alt
        {
            get { return dat_alt; }
            set { dat_alt = value; }
        }

        public override string getNomeTabela()
        {
            return this.nomeTabela;
        }
    }
}
