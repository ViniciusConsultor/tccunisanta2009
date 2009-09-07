using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    class mUsuarioPerfil
    {
        private int idUsuario;
        private int idPerfil;
        private DateTime datTrans;
        private bool flgAtivo;

        [ColunasBancoDados("id_usu", System.Data.SqlDbType.Int)]
        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        [ColunasBancoDados("id_perfil", System.Data.SqlDbType.Int)]
        public int IdPerfil
        {
            get { return idPerfil; }
            set { idPerfil = value; }
        }

        [ColunasBancoDados("dat_trans", System.Data.SqlDbType.DateTime)]
        public DateTime DatTrans
        {
            get { return datTrans; }
            set { datTrans = value; }
        }

        [ColunasBancoDados("flg_ativo", System.Data.SqlDbType.Bit)]
        public bool FlgAtivo
        {
            get { return flgAtivo; }
            set { flgAtivo = value; }
        }
    }
}
