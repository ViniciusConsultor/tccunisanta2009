using Kaue.Reflection;
using System;
using System.Collections.Generic;
using System.Text;

namespace TCC.Mapper
{
    public class mFornecedor : ModelPai
    {
        private int? idFornecedor;
        private string nomeFornecedor;
        private string ruaFornecedor;
        private int? nroFornecedor;
        private string complemento;
        private string codPostal;
        private int? ddd;
        private string bairro;
        private int? telefone;
        private string cidade;
        private string email;
        private string cnpj;
        private DateTime datAtl;
        private bool flgAtivo;
        private string slgEstado;
        private string nom_pais;
        private string nom_est_inter;
        private string ddi;
        private string identInter;
        private string nomeTabela = "fornecedor";

        [ColunasBancoDados("id_forn", System.Data.SqlDbType.Int, true)]
        public int? IdFornecedor
        {
            get { return idFornecedor; }
            set { idFornecedor = value; }
        }

        [ColunasBancoDados("nom", System.Data.SqlDbType.VarChar, false)]
        public string NomeFornecedor
        {
            get { return nomeFornecedor; }
            set { nomeFornecedor = value; }
        }

        [ColunasBancoDados("rua", System.Data.SqlDbType.VarChar, false)]
        public string RuaFornecedor
        {
            get { return ruaFornecedor; }
            set { ruaFornecedor = value; }
        }

        [ColunasBancoDados("nro_ende", System.Data.SqlDbType.Int, false)]
        public int? NroFornecedor
        {
            get { return nroFornecedor; }
            set { nroFornecedor = value; }
        }

        [ColunasBancoDados("compl", System.Data.SqlDbType.VarChar, false)]
        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        [ColunasBancoDados("cod_post", System.Data.SqlDbType.VarChar, false)]
        public string CodPostal
        {
            get { return codPostal; }
            set { codPostal = value; }
        }

        [ColunasBancoDados("ddd", System.Data.SqlDbType.Int, false)]
        public int? Ddd
        {
            get { return ddd; }
            set { ddd = value; }
        }

        [ColunasBancoDados("bairr", System.Data.SqlDbType.VarChar, false)]
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        [ColunasBancoDados("tel", System.Data.SqlDbType.Int, false)]
        public int? Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        [ColunasBancoDados("cid", System.Data.SqlDbType.VarChar, false)]
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        [ColunasBancoDados("mail", System.Data.SqlDbType.VarChar, false)]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        [ColunasBancoDados("cnpj", System.Data.SqlDbType.VarChar, false)]
        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        [ColunasBancoDados("dat_alt", System.Data.SqlDbType.DateTime, false)]
        public DateTime DatAtl
        {
            get { return datAtl; }
            set { datAtl = value; }
        }

        [ColunasBancoDados("flg_ativo", System.Data.SqlDbType.Bit, false)]
        public bool FlgAtivo
        {
            get { return flgAtivo; }
            set { flgAtivo = value; }
        }

        [ColunasBancoDados("slg_est", System.Data.SqlDbType.VarChar, false)]
        public string SlgEstado
        {
            get { return slgEstado; }
            set { slgEstado = value; }
        }

        [ColunasBancoDados("Nom_pais", System.Data.SqlDbType.VarChar, false)]
        public string Nom_pais
        {
            get { return nom_pais; }
            set { nom_pais = value; }
        }

        [ColunasBancoDados("Nom_est_inter", System.Data.SqlDbType.VarChar, false)]
        public string Nom_est_inter
        {
            get { return nom_est_inter; }
            set { nom_est_inter = value; }
        }

        [ColunasBancoDados("ddi", System.Data.SqlDbType.Char,false)]
        public string Ddi
        {
            get { return ddi; }
            set { ddi = value; }
        }

        [ColunasBancoDados("ident_inter", System.Data.SqlDbType.VarChar,false)]
        public string IdentInter
        {
            get { return identInter; }
            set { identInter = value; }
        }       

        public override string getNomeTabela()
        {
            return this.nomeTabela;
        }
    }
}
