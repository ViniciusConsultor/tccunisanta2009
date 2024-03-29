﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelasDesenvolvedor.MODEL
{
    class mCadColaborador
    {
        private int idColab;
        private int idUsuario;
        private int idDepto;
        private string nomeColab;
        private DateTime datNasc;
        private string nomeRua;
        private int nroEnd;
        private string complEnd;
        private string cep;
        private string bairrEnd;
        private string cidade;
        private string estado;
        private string rg;
        private string cpf;
        private char sexo;
        private DateTime datAtl;
        private bool flgAtivo;

        [ColunasBancoDados("id_colab", System.Data.SqlDbType.Int)]
        public int IdColab
        {
            get { return idColab; }
            set { idColab = value; }
        }
       
        [ColunasBancoDados("id_usu", System.Data.SqlDbType.Int)]
        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        [ColunasBancoDados("id_depto", System.Data.SqlDbType.Int)]
        public int IdDepto
        {
            get { return idDepto; }
            set { idDepto = value; }
        }

        [ColunasBancoDados("nom_colab", System.Data.SqlDbType.VarChar)]
        public string NomeColab
        {
            get { return nomeColab; }
            set { nomeColab = value; }
        }

        [ColunasBancoDados("dat_nasc", System.Data.SqlDbType.DateTime)]
        public DateTime DatNasc
        {
            get { return datNasc; }
            set { datNasc = value; }
        }

        [ColunasBancoDados("nom_rua", System.Data.SqlDbType.VarChar)]
        public string NomeRua
        {
            get { return nomeRua; }
            set { nomeRua = value; }
        }

        [ColunasBancoDados("nro_end", System.Data.SqlDbType.Int)]
        public int NroEnd
        {
            get { return nroEnd; }
            set { nroEnd = value; }
        }

        [ColunasBancoDados("compl_end", System.Data.SqlDbType.VarChar)]
        public string ComplEnd
        {
            get { return complEnd; }
            set { complEnd = value; }
        }

        [ColunasBancoDados("cep", System.Data.SqlDbType.VarChar)]
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        [ColunasBancoDados("bairr_end", System.Data.SqlDbType.VarChar)]
        public string BairrEnd
        {
            get { return bairrEnd; }
            set { bairrEnd = value; }
        }

        [ColunasBancoDados("cidade", System.Data.SqlDbType.VarChar)]
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        [ColunasBancoDados("estado", System.Data.SqlDbType.Char)]
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        [ColunasBancoDados("rg", System.Data.SqlDbType.VarChar)]
        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        [ColunasBancoDados("cpf",System.Data.SqlDbType.VarChar)]
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        [ColunasBancoDados("sexo", System.Data.SqlDbType.Char)]
        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        [ColunasBancoDados("dat_atl", System.Data.SqlDbType.DateTime)]
        public DateTime DatAtl
        {
            get { return DateTime.Now; }
            set { datAtl = value; }
        }

        [ColunasBancoDados("flg_ativo", System.Data.SqlDbType.Bit)]
        public bool FlgAtivo
        {
            get { return true; }
            set { flgAtivo = value; }
        }
    }
}
