using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    public class mColaborador : ModelPai
    {
        private int idColab;
        private int idUsuario;
        private int idDepto;
        private string nomeColab;
        private DateTime datNasc;
        private string nomeRua;
        private int? nroEnd;
        private string complEnd;
        private string cep;
        private string bairrEnd;
        private string cidade;
        private string estado;
        private string rg;
        private string cpf;
        private string sexo;
        private DateTime datAtl;
        private bool flgAtivo;
        private int? ddd;
        private int? telefone;
        private string email;
        private string nomeTabela = "colaborador";

        [ColunasBancoDados("id_colab", System.Data.SqlDbType.Int, true)]
        public int IdColab
        {
            get { return idColab; }
            set { idColab = value; }
        }
       
        [ColunasBancoDados("id_usu", System.Data.SqlDbType.Int, false)]
        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        [ColunasBancoDados("id_depto", System.Data.SqlDbType.Int, false)]
        public int IdDepto
        {
            get { return idDepto; }
            set { idDepto = value; }
        }

        [ColunasBancoDados("nom", System.Data.SqlDbType.VarChar, false)]
        public string NomeColab
        {
            get { return nomeColab; }
            set { nomeColab = value; }
        }

        [ColunasBancoDados("dat_nasc", System.Data.SqlDbType.DateTime, false)]
        public DateTime DatNasc
        {
            get { return datNasc; }
            set { datNasc = value; }
        }

        [ColunasBancoDados("rua", System.Data.SqlDbType.VarChar, false)]
        public string NomeRua
        {
            get { return nomeRua; }
            set { nomeRua = value; }
        }

        [ColunasBancoDados("nro_ende", System.Data.SqlDbType.Int, false)]
        public int? NroEnd
        {
            get { return nroEnd; }
            set { nroEnd = value; }
        }

        [ColunasBancoDados("compl", System.Data.SqlDbType.VarChar, false)]
        public string ComplEnd
        {
            get { return complEnd; }
            set { complEnd = value; }
        }

        [ColunasBancoDados("cep", System.Data.SqlDbType.VarChar, false)]
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        [ColunasBancoDados("bairr", System.Data.SqlDbType.VarChar, false)]
        public string BairrEnd
        {
            get { return bairrEnd; }
            set { bairrEnd = value; }
        }

        [ColunasBancoDados("cid", System.Data.SqlDbType.VarChar, false)]
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        [ColunasBancoDados("slg_est", System.Data.SqlDbType.Int, false)]
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        [ColunasBancoDados("rg", System.Data.SqlDbType.VarChar, false)]
        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        [ColunasBancoDados("cpf", System.Data.SqlDbType.VarChar, false)]
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        [ColunasBancoDados("sex", System.Data.SqlDbType.Char, false)]
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        [ColunasBancoDados("dat_atl", System.Data.SqlDbType.DateTime, false)]
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

        public override string getNomeTabela()
        {
            return nomeTabela;
        }
    }
}
