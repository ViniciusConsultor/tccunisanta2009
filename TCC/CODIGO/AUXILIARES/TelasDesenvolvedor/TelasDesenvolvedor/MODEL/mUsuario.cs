using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelasDesenvolvedor.MODEL
{
    class mUsuario
    {
        private int idUsuario;
        private string LoginUsuario;
        private string DescUsuario;
        private string Senha;
        private char tipoUsuario;
        private string descTipoUsuario;
        private bool flagAdm;
        private bool flagAtivo;

        [ColunasBancoDados("id_usu", System.Data.SqlDbType.Int)]
        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        
        [ColunasBancoDados("login", System.Data.SqlDbType.VarChar)]
        public string LoginUsuario1
        {
            get { return LoginUsuario; }
            set { LoginUsuario = value; }
        }

        [ColunasBancoDados("desc_usu", System.Data.SqlDbType.Char)]
        public string DescUsuario1
        {
            get { return DescUsuario; }
            set { DescUsuario = value; }
        }

        [ColunasBancoDados("senha", System.Data.SqlDbType.VarChar)]
        public string Senha1
        {
            get { return Senha; }
            set { Senha = value; }
        }

        [ColunasBancoDados("tipo", System.Data.SqlDbType.Char)]
        public char TipoUsuario
        {
            get { return tipoUsuario; }
            set { tipoUsuario = value; }
        }

        [ColunasBancoDados("desc_tipo", System.Data.SqlDbType.VarChar)]
        public string DescTipoUsuario
        {
            get { return descTipoUsuario; }
            set { descTipoUsuario = value; }
        }

        [ColunasBancoDados("flg_admin", System.Data.SqlDbType.Bit)]
        public bool FlagAdm
        {
            get { return flagAdm; }
            set { flagAdm = value; }
        }

        [ColunasBancoDados("flg_ativo", System.Data.SqlDbType.Bit)]
        public bool FlagAtivo
        {
            get { return flagAtivo; }
            set { flagAtivo = value; }
        }
  
    
    }
}
