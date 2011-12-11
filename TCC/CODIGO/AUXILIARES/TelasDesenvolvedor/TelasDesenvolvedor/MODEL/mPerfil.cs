using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelasDesenvolvedor.MODEL
{
    class mPerfil
    {
        private int idPerfil;
        private string descPerfil;
        private DateTime datAtl;
        private bool flgAtivo;

        [ColunasBancoDados("id_perfil", System.Data.SqlDbType.Int)]
        public int IdPerfil
        {
            get { return idPerfil; }
            set { idPerfil = value; }
        }

        [ColunasBancoDados("dsc_perfil", System.Data.SqlDbType.VarChar)]
        public string DescPerfil
        {
            get { return descPerfil; }
            set { descPerfil = value; }
        }

        [ColunasBancoDados("dat_atl", System.Data.SqlDbType.DateTime)]
        public DateTime DatAtl
        {
            get { return DateTime.Now; }
            set { datAtl = value; }
        }

        [ColunasBancoDados("flg_ativo", System.Data.SqlDbType.Bit)]
        public bool FlgAtivo
        {
            get { return true; }
            set { flgAtivo = value; }
        }
    }
}
