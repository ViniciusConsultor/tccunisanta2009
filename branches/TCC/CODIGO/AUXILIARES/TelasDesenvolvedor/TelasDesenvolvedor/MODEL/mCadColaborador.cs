using System;
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
        private char estado;
        private string rg;
        private string cpf;
        private char sexo;
        private DateTime datAtl;
        private bool flgAtivo;

        public int IdColab
        {
            get { return idColab; }
            set { idColab = value; }
        }
       

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
       

        public int IdDepto
        {
            get { return idDepto; }
            set { idDepto = value; }
        }
        

        public string NomeColab
        {
            get { return nomeColab; }
            set { nomeColab = value; }
        }
        

        public DateTime DatNasc
        {
            get { return datNasc; }
            set { datNasc = value; }
        }
        

        public string NomeRua
        {
            get { return nomeRua; }
            set { nomeRua = value; }
        }
        

        public int NroEnd
        {
            get { return nroEnd; }
            set { nroEnd = value; }
        }
        

        public string ComplEnd
        {
            get { return complEnd; }
            set { complEnd = value; }
        }
        

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        

        public string BairrEnd
        {
            get { return bairrEnd; }
            set { bairrEnd = value; }
        }
        

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        

        public char Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
       

        public DateTime DatAtl
        {
            get { return datAtl; }
            set { datAtl = value; }
        }
       

        public bool FlgAtivo
        {
            get { return flgAtivo; }
            set { flgAtivo = value; }
        }
    }
}
