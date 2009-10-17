using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    public class mSubMenu : ModelPai
    {
        private int idMenuFilho;
        private int idMenuPai;
        private int idMenu;
        private string nomeTabela = "Submenu";

        [ColunasBancoDados ("id_menu_filho", System.Data.SqlDbType.Int,true)]
        public int IdMenuFilho
        {
            get { return idMenuFilho; }
            set { idMenuFilho = value; }
        }

        [ColunasBancoDados ("id_menu_pai", System.Data.SqlDbType.Int,true)]
        public int IdMenuPai
        {
            get { return idMenuPai; }
            set { idMenuPai = value; }
        }

        [ColunasBancoDados ("id_menu", System.Data.SqlDbType.Int,false)]
        public int IdMenu
        {
            get { return idMenu; }
            set { idMenu = value; }
        }

        public override string getNomeTabela()
        {
            return this.nomeTabela;
        }

    }
}
