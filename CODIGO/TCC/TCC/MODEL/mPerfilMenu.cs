using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    class mPerfilMenu
    {
        private int idPerfil;
        private int idMenu;
        private DateTime datTrans;
        private bool flgAtivo;

        [ColunasBancoDados("flg_ativo", System.Data.SqlDbType.Bit)]
        public bool FlgAtivo
        {
            get { return flgAtivo; }
            set { flgAtivo = value; }
        }

        [ColunasBancoDados("dat_trans", System.Data.SqlDbType.DateTime)]
        public DateTime DatTrans
        {
            get { return datTrans; }
            set { datTrans = value; }
        }

        [ColunasBancoDados("id_menu", System.Data.SqlDbType.Int)]
        public int IdMenu
        {
            get { return idMenu; }
            set { idMenu = value; }
        }

        [ColunasBancoDados("id_perfil", System.Data.SqlDbType.Int)]
        public int IdPerfil
        {
            get { return idPerfil; }
            set { idPerfil = value; }
        }
    }
}
