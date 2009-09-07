using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    class mUsuario
    {
        private int idUsuario;
        private string login;
        private string senha;
        private int idTipoUsuario;
        private string obsUsuario;
        private bool flgAtivo;

        [ColunasBancoDados("flg_ativo", System.Data.SqlDbType.Bit)]
        public bool FlgAtivo
        {
            get { return flgAtivo; }
            set { flgAtivo = value; }
        }

        [ColunasBancoDados("obs_usu", System.Data.SqlDbType.VarChar)]
        public string ObsUsuario
        {
            get { return obsUsuario; }
            set { obsUsuario = value; }
        }

        [ColunasBancoDados("senha", System.Data.SqlDbType.VarChar)]
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        [ColunasBancoDados("login", System.Data.SqlDbType.VarChar)]
        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        [ColunasBancoDados("id_usu", System.Data.SqlDbType.Int)]
        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }        
    }
}
