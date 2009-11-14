﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    public class mCliente : ModelPai
    {
        private int idCliente;
        private string nomeCliente;
        private int? telefoneCliente;
        private string nomeRua;
        private string slgEstado;
        private int? numeroEndereco;
        private string complementoEndereco;
        private int? cep;
        private string bairro;
        private string cidade;
        private string cpf;
        private decimal? cnpj;
        private DateTime datAtl;
        private bool flgAtivo;
        private string email;
        private int? ddd;
        private string nom_pais;
        private string nom_est_inter;
        private string nomeTabela = "cliente";

        [ColunasBancoDados("flg_ativo", System.Data.SqlDbType.Bit, false)]
        public bool FlgAtivo
        {
            get { return flgAtivo; }
            set { flgAtivo = value; }
        }

        [ColunasBancoDados("dat_atl", System.Data.SqlDbType.DateTime, false)]
        public DateTime DatAtl
        {
            get { return datAtl; }
            set { datAtl = value; }
        }

        [ColunasBancoDados("cnpj", System.Data.SqlDbType.Decimal, false)]
        public decimal? Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        //troquei de rg para cpf
        [ColunasBancoDados("cpf", System.Data.SqlDbType.VarChar, false)]
        public string  Cpf
        {
            get { return cpf; }
            set { cpf = value; }
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
        public int? Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        [ColunasBancoDados("compl", System.Data.SqlDbType.VarChar, false)]
        public string ComplementoEndereco
        {
            get { return complementoEndereco; }
            set { complementoEndereco = value; }
        }

        [ColunasBancoDados("nro_ende", System.Data.SqlDbType.Int, false)]
        public int? NumeroEndereco
        {
            get { return numeroEndereco; }
            set { numeroEndereco = value; }
        }

        [ColunasBancoDados("slg_est", System.Data.SqlDbType.VarChar, false)]
        public string SlgEstado
        {
            get { return slgEstado; }
            set { slgEstado = value; }
        }

        [ColunasBancoDados("rua", System.Data.SqlDbType.VarChar, false)]
        public string NomeRua
        {
            get { return nomeRua; }
            set { nomeRua = value; }
        }

        [ColunasBancoDados("tel", System.Data.SqlDbType.Int, false)]
        public int? TelefoneCliente
        {
            get { return telefoneCliente; }
            set { telefoneCliente = value; }
        }

        [ColunasBancoDados("nom", System.Data.SqlDbType.VarChar, false)]
        public string NomeCliente
        {
            get { return nomeCliente; }
            set { nomeCliente = value; }
        }

        [ColunasBancoDados("id_cli", System.Data.SqlDbType.Int, true)]
        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        [ColunasBancoDados("mail", System.Data.SqlDbType.VarChar, false)]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        [ColunasBancoDados("ddd", System.Data.SqlDbType.Int, false)]
        public int? Ddd
        {
            get { return ddd; }
            set { ddd = value; }
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

        public override string getNomeTabela()
        {
            return this.nomeTabela;
        }
    }
}
