using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    class mFornecedor : ModelPai
    {
        private int idFornecedor;
        private string nomeFornecedor;
        private string ruaFornecedor;
        private int? nroFornecedor;
        private string complemento;
        private int? cepFornecedor;
        private string bairro;
        private string cidade;
        private int? cnpj;
        private DateTime datAtl;
        private bool flgAtivo;
        private string slgEstado;
        private int? ddd;
        private int? telefone;
        private string email;

        private string nomeTabela = "fornecedor";

        [ColunasBancoDados("slg_estado", System.Data.SqlDbType.VarChar, false)]
        public string SlgEstado
        {
            get { return slgEstado; }
            set { slgEstado = value; }
        }

        [ColunasBancoDados("flg_ativo", System.Data.SqlDbType.Bit, false)]
        public bool FlgAtivo
        {
            get { return flgAtivo; }
            set { flgAtivo = value; }
        }

        [ColunasBancoDados("dat_alt", System.Data.SqlDbType.DateTime, false)]
        public DateTime DatAtl
        {
            get { return datAtl; }
            set { datAtl = value; }
        }

        [ColunasBancoDados("id_cnpj_fornecedor", System.Data.SqlDbType.Int, false)]
        public int? Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        [ColunasBancoDados("cidade_fornecedor", System.Data.SqlDbType.VarChar, false)]
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        [ColunasBancoDados("bairr_end_fornecedor", System.Data.SqlDbType.VarChar, false)]
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        [ColunasBancoDados("cep_fornecedor", System.Data.SqlDbType.Int, false)]
        public int? CepFornecedor
        {
            get { return cepFornecedor; }
            set { cepFornecedor = value; }
        }

        [ColunasBancoDados("compl_end_fornecedor", System.Data.SqlDbType.VarChar, false)]
        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        [ColunasBancoDados("nro_end_fornecedor", System.Data.SqlDbType.Int, false)]
        public int? NroFornecedor
        {
            get { return nroFornecedor; }
            set { nroFornecedor = value; }
        }

        [ColunasBancoDados("nom_rua_fornecedor", System.Data.SqlDbType.VarChar, false)]
        public string RuaFornecedor
        {
            get { return ruaFornecedor; }
            set { ruaFornecedor = value; }
        }

        [ColunasBancoDados("nom_fornecedor", System.Data.SqlDbType.VarChar, false)]
        public string NomeFornecedor
        {
            get { return nomeFornecedor; }
            set { nomeFornecedor = value; }
        }

        [ColunasBancoDados("id_fornecedor", System.Data.SqlDbType.Int, true)]
        public int IdFornecedor
        {
            get { return idFornecedor; }
            set { idFornecedor = value; }
        }

        [ColunasBancoDados("DDD", System.Data.SqlDbType.Int, false)]
        public int? Ddd
        {
            get { return ddd; }
            set { ddd = value; }
        }

        [ColunasBancoDados("tel_fornecedor", System.Data.SqlDbType.Int, false)]
        public int? Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        [ColunasBancoDados("Email", System.Data.SqlDbType.VarChar, false)]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public override string getNomeTabela()
        {
            return this.nomeTabela;
        }
    }
}
