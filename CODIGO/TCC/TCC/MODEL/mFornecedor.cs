using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    public class mFornecedor : ModelPai
    {
        private int? idFornecedor;
        private string nomeFornecedor;
        private string ruaFornecedor;
        private int? nroFornecedor;
        private string complemento;
        private int? cepFornecedor;
        private string bairro;
        private string cidade;
        private string cnpj;
        private DateTime datAtl;
        private bool flgAtivo;
        private string slgEstado;
        private int? ddd;
        private int? telefone;
        private string email;
        private string nom_pais;
        private string nom_erst_inter;

       
        private string nomeTabela = "fornecedor";

        [ColunasBancoDados("slg_est", System.Data.SqlDbType.VarChar, false)]
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

        [ColunasBancoDados("cnpj", System.Data.SqlDbType.VarChar, false)]
        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        [ColunasBancoDados("cid", System.Data.SqlDbType.VarChar, false)]
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        [ColunasBancoDados("bairr", System.Data.SqlDbType.VarChar, false)]
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        [ColunasBancoDados("cep", System.Data.SqlDbType.Int, false)]
        public int? CepFornecedor
        {
            get { return cepFornecedor; }
            set { cepFornecedor = value; }
        }

        [ColunasBancoDados("compl", System.Data.SqlDbType.VarChar, false)]
        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        [ColunasBancoDados("nro_ende", System.Data.SqlDbType.Int, false)]
        public int? NroFornecedor
        {
            get { return nroFornecedor; }
            set { nroFornecedor = value; }
        }

        [ColunasBancoDados("rua", System.Data.SqlDbType.VarChar, false)]
        public string RuaFornecedor
        {
            get { return ruaFornecedor; }
            set { ruaFornecedor = value; }
        }

        [ColunasBancoDados("nom", System.Data.SqlDbType.VarChar, false)]
        public string NomeFornecedor
        {
            get { return nomeFornecedor; }
            set { nomeFornecedor = value; }
        }

        [ColunasBancoDados("id_forn", System.Data.SqlDbType.Int, true)]
        public int? IdFornecedor
        {
            get { return idFornecedor; }
            set { idFornecedor = value; }
        }

        [ColunasBancoDados("ddd", System.Data.SqlDbType.Int, false)]
        public int? Ddd
        {
            get { return ddd; }
            set { ddd = value; }
        }

        [ColunasBancoDados("tel", System.Data.SqlDbType.Int, false)]
        public int? Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        [ColunasBancoDados("mail", System.Data.SqlDbType.VarChar, false)]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        [ColunasBancoDados("Nom_pais", System.Data.SqlDbType.VarChar, false)]
        public string Nom_pais
        {
            get { return nom_pais; }
            set { nom_pais = value; }
        }
        [ColunasBancoDados("Nom_erst_inter", System.Data.SqlDbType.VarChar, false)]
        public string Nom_erst_inter
        {
            get { return nom_erst_inter; }
            set { nom_erst_inter = value; }
        }


        public override string getNomeTabela()
        {
            return this.nomeTabela;
        }
    }
}
