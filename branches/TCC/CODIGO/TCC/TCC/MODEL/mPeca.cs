using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    public class mPeca : ModelPai
    {
        private int idPeca;
        private string idPecaReal;
        private string nom;
        private DateTime datAlt;
        private double? peso;
        private bool flgAtivo;
        private string dscPeca;
        private int idEstoque;
        private int? qtdMin;
        private int idTipoPeca;
        private string nomeTabela = "peca";

        [ColunasBancoDados ("id_peca", System.Data.SqlDbType.Int,true)]
        public int IdPeca
        {
            get { return idPeca; }
            set { idPeca = value; }
        }

        [ColunasBancoDados ("id_peca_real", System.Data.SqlDbType.VarChar,false)]
        public string IdPecaReal
        {
            get { return idPecaReal; }
            set { idPecaReal = value; }
        }

        [ColunasBancoDados ("nom", System.Data.SqlDbType.VarChar,false)]
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        [ColunasBancoDados ("dat_alt", System.Data.SqlDbType.DateTime,false)]
        public DateTime DatAlt
        {
            get { return datAlt; }
            set { datAlt = value; }
        }

        [ColunasBancoDados ("peso", System.Data.SqlDbType.Decimal,false)]
        public double? Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        [ColunasBancoDados ("flg_ativo", System.Data.SqlDbType.Bit,false)]
        public bool FlgAtivo
        {
            get { return flgAtivo; }
            set { flgAtivo = value; }
        }

        [ColunasBancoDados ("dsc_peca", System.Data.SqlDbType.VarChar,false)]
        public string DscPeca
        {
            get { return dscPeca; }
            set { dscPeca = value; }
        }

        [ColunasBancoDados ("id_estoque", System.Data.SqlDbType.Int,false)]
        public int IdEstoque
        {
            get { return idEstoque; }
            set { idEstoque = value; }
        }

        [ColunasBancoDados ("qtd_min", System.Data.SqlDbType.Int,false)]
        public int? QtdMin
        {
            get { return qtdMin; }
            set { qtdMin = value; }
        }

        [ColunasBancoDados ("id_tipo_peca", System.Data.SqlDbType.Int,false)]
        public int IdTipoPeca
        {
            get { return idTipoPeca; }
            set { idTipoPeca = value; }
        }

        public override string getNomeTabela()
        {
            return this.nomeTabela;
        }
    }
}
