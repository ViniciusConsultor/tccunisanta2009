using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    public class mUsuario : ModelPai
    {
        private int? idUsuario;
        private string login;
        private string senha;
        private string obsUsuario;
        private bool flgAtivo;
        private string nomeTabela = "usuario";

        [ColunasBancoDados("flg_ativo", System.Data.SqlDbType.Bit, false)]
        public bool FlgAtivo
        {
            get { return flgAtivo; }
            set { flgAtivo = value; }
        }

        [ColunasBancoDados("obs_usu", System.Data.SqlDbType.VarChar, false)]
        public string ObsUsuario
        {
            get { return obsUsuario; }
            set { obsUsuario = value; }
        }

        [ColunasBancoDados("senha", System.Data.SqlDbType.VarChar, false)]
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        [ColunasBancoDados("log_usu", System.Data.SqlDbType.VarChar, false)]
        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        [ColunasBancoDados("id_usu", System.Data.SqlDbType.Int, true)]
        public int? IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public override string getNomeTabela()
        {
            return this.nomeTabela;
        }
    }
}
