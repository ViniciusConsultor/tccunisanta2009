using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    class mFornecedor
    {
        private int idFornecedor;
        private string nomeFornecedor;
        private string ruaFornecedor;
        private int nroFornecedor;
        private string complemento;
        private int cepFornecedor;
        private string bairro;
        private string cidade;
        private int cnpj;
        private DateTime datAtl;
        private bool flgAtivo;
        private int idEstado;

        [ColunasBancoDados("id_estado", System.Data.SqlDbType.Int)]
        public int IdEstado
        {
            get { return idEstado; }
            set { idEstado = value; }
        }

        [ColunasBancoDados("flg_ativo", System.Data.SqlDbType.Bit)]
        public bool FlgAtivo
        {
            get { return flgAtivo; }
            set { flgAtivo = value; }
        }

        [ColunasBancoDados("dat_alt", System.Data.SqlDbType.DateTime)]
        public DateTime DatAtl
        {
            get { return datAtl; }
            set { datAtl = value; }
        }

        [ColunasBancoDados("id_cnpj_fornecedor", System.Data.SqlDbType.Int)]
        public int Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        [ColunasBancoDados("cidade_fornecedor", System.Data.SqlDbType.VarChar)]
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        [ColunasBancoDados("bairr_end_fornecedor", System.Data.SqlDbType.VarChar)]
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        [ColunasBancoDados("cep_fornecedor", System.Data.SqlDbType.Int)]
        public int CepFornecedor
        {
            get { return cepFornecedor; }
            set { cepFornecedor = value; }
        }

        [ColunasBancoDados("compl_end_fornecedor", System.Data.SqlDbType.VarChar)]
        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        [ColunasBancoDados("nro_end_fornecedor", System.Data.SqlDbType.Int)]
        public int NroFornecedor
        {
            get { return nroFornecedor; }
            set { nroFornecedor = value; }
        }

        [ColunasBancoDados("nom_rua_fornecedor", System.Data.SqlDbType.VarChar)]
        public string RuaFornecedor
        {
            get { return ruaFornecedor; }
            set { ruaFornecedor = value; }
        }

        [ColunasBancoDados("nom_fornecedor", System.Data.SqlDbType.VarChar)]
        public string NomeFornecedor
        {
            get { return nomeFornecedor; }
            set { nomeFornecedor = value; }
        }

        [ColunasBancoDados("id_fornecedor", System.Data.SqlDbType.Int)]
        public int IdFornecedor
        {
            get { return idFornecedor; }
            set { idFornecedor = value; }
        }
    }
}
