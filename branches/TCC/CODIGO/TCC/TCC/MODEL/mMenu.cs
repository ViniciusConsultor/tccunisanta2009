using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    class mMenu : ModelPai
    {
        private int idMenu;
        private string dscMenu;
        private string endMenu;
        private DateTime datAtl;
        private bool flgAtivo;
        private string nomeTabela = "menu";

        [ColunasBancoDados("id_menu", System.Data.SqlDbType.Int, true)]
        public int IdMenu
        {
            get { return idMenu; }
            set { idMenu = value; }
        }

        [ColunasBancoDados("dsc_menu", System.Data.SqlDbType.VarChar, false)]
        public string DscMenu
        {
            get { return dscMenu; }
            set { dscMenu = value; }
        }

        [ColunasBancoDados("end_menu", System.Data.SqlDbType.VarChar, false)]
        public string EndMenu
        {
            get { return endMenu; }
            set { endMenu = value; }
        }

        [ColunasBancoDados("dat_atl", System.Data.SqlDbType.DateTime, false)]
        public DateTime DatAtl
        {
            get { return datAtl = DateTime.Now; }
            set { datAtl = value; }
        }
        
        [ColunasBancoDados("flg_ativo", System.Data.SqlDbType.Bit, false)]
        public bool FlgAtivo
        {
            get { return flgAtivo = true; }
            set { flgAtivo = value; }
        }

        public override string getNomeTabela()
        {
            return this.nomeTabela;
        }
    }
}
