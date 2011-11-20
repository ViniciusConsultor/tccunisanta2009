using Kaue.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.Mapper
{
    public class mPerfilMenu : ModelPai
    {
        private int? idPerfil;
        private int? idMenu;
        private DateTime datTrans;
        private bool flgAtivo;
        private string nomeTabela = "perfilMenu";

        [ColunasBancoDados("flg_ativo", System.Data.SqlDbType.Bit, false)]
        public bool FlgAtivo
        {
            get { return flgAtivo; }
            set { flgAtivo = value; }
        }

        [ColunasBancoDados("dat_alt", System.Data.SqlDbType.DateTime, false)]
        public DateTime DatTrans
        {
            get { return datTrans; }
            set { datTrans = value; }
        }

        [ColunasBancoDados("id_menu", System.Data.SqlDbType.Int, true)]
        public int? IdMenu
        {
            get { return idMenu; }
            set { idMenu = value; }
        }

        [ColunasBancoDados("id_perfil", System.Data.SqlDbType.Int, true)]
        public int? IdPerfil
        {
            get { return idPerfil; }
            set { idPerfil = value; }
        }

        public override string getNomeTabela()
        {
            return this.nomeTabela;
        }
    }
}
