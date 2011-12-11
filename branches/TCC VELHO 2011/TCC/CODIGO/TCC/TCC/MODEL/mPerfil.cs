using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    public class mPerfil : ModelPai
    {
        private int? idPerfil;
        private string descPerfil;
        private DateTime datAtl;
        private bool flgAtivo;
        private string nomeTabela = "perfil";

        [ColunasBancoDados("id_perfil", System.Data.SqlDbType.Int, true)]
        public int? IdPerfil
        {
            get { return idPerfil; }
            set { idPerfil = value; }
        }

        [ColunasBancoDados("dsc_perfil", System.Data.SqlDbType.VarChar, false)]
        public string DescPerfil
        {
            get { return descPerfil; }
            set { descPerfil = value; }
        }

        [ColunasBancoDados("dat_atl", System.Data.SqlDbType.DateTime, false)]
        public DateTime DatAtl
        {
            get { return DateTime.Now; }
            set { datAtl = value; }
        }

        [ColunasBancoDados("flg_ativo", System.Data.SqlDbType.Bit, false)]
        public bool FlgAtivo
        {
            get { return true; }
            set { flgAtivo = value; }
        }

        public override string getNomeTabela()
        {
            return this.nomeTabela;
        }
    }
}
