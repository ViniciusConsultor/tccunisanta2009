using System;
using System.Collections.Generic;
using System.Text;

namespace TCC.MODEL
{
    public class mProduto : ModelPai
    {
        private int? idProduto;
        private string descProduto;
        private int? idFamMotor;
        private int? idKit;
        private int idTipoProduto;
        private bool flgAtivo;
        private DateTime datAlt;
        private string nomeTabela = "Produto";


        [ColunasBancoDados("id_prdto", System.Data.SqlDbType.Int, true)]
        public int? IdProduto
        {
            get { return idProduto; }
            set { idProduto = value; }
        }

        [ColunasBancoDados ("dsc_prdto", System.Data.SqlDbType.VarChar, false)]
        public string DescProduto
        {
            get { return descProduto; }
            set { descProduto = value; }
        }

        [ColunasBancoDados ("id_fam_motor", System.Data.SqlDbType.Int, false)]
        public int? IdFamMotor
        {
            get { return idFamMotor; }
            set { idFamMotor = value; }
        }


        [ColunasBancoDados ("id_kit", System.Data.SqlDbType.Int, false)]
        public int? IdKit
        {
            get { return idKit; }
            set { idKit = value; }
        }


        [ColunasBancoDados ("id_tipo_produto", System.Data.SqlDbType.Int, false)]
        public int IdTipoProduto
        {
            get { return idTipoProduto; }
            set { idTipoProduto = value; }
        }

        [ColunasBancoDados ("flg_ativo", System.Data.SqlDbType.Bit, false)]
        public bool FlgAtivo
        {
            get { return flgAtivo; }
            set { flgAtivo = value; }
        }

        [ColunasBancoDados ("dat_alt", System.Data.SqlDbType.DateTime, false)]
        public DateTime DatAlt
        {
            get { return datAlt; }
            set { datAlt = value; }
        }

        public override string getNomeTabela()
        {
            return this.nomeTabela;
        } 
    }
}
