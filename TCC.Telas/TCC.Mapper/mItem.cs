using Kaue.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.Mapper
{
    public class mItem:ModelPai
    {
        private int id_item;
        private string id_item_real;
        private string nom;
        private bool flg_ativo;
        private DateTime? dat_alt;
        private string nometabela = "item";

        [ColunasBancoDados("dat_alt", System.Data.SqlDbType.DateTime, false)]
        public DateTime? Dat_alt
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

        [ColunasBancoDados("Nom", System.Data.SqlDbType.VarChar, false)]
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        [ColunasBancoDados("Id_item", System.Data.SqlDbType.Int, true)]
        public int Id_item
        {
            get { return id_item; }
            set { id_item = value; }
        }
        [ColunasBancoDados("Id_item_real", System.Data.SqlDbType.VarChar, true)]
        public string Id_item_real
        {
            get { return id_item_real; }
            set { id_item_real = value; }
        }
        public override string getNomeTabela()
        {
            return this.nometabela;
        }
    }
}
