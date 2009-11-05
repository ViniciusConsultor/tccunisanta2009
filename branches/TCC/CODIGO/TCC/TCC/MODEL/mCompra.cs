using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    public class mCompra : ModelPai
    {
        private int? idCompra;
        private DateTime? dat;
        private string obs;
      //  private int idFornecedor;
        private double valor;
       // private string notaFiscal;
        private string nomeTabela = "compra";

        
        [ColunasBancoDados ("id_compra", System.Data.SqlDbType.Int,true)]
        public int? IdCompra
        {
            get { return idCompra; }
            set { idCompra = value; }
        }

        [ColunasBancoDados ("dat", System.Data.SqlDbType.DateTime,false)]
        public DateTime? Dat
        {
            get { return dat; }
            set { dat = value; }
        }

        [ColunasBancoDados("obs", System.Data.SqlDbType.VarChar,false)]
        public string Obs
        {
            get { return obs; }
            set { obs = value; }
        }

      /* 
        [ColunasBancoDados ("id_forn", System.Data.SqlDbType.Int,false)]
        public int IdFornecedor
        {
            get { return idFornecedor; }
            set { idFornecedor = value; }
        }
      */
        [ColunasBancoDados ("valor", System.Data.SqlDbType.Decimal,false)]
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    /*
        [ColunasBancoDados ("nota_fisc", System.Data.SqlDbType.VarChar,false)]
        public string NotaFiscal
        {
            get { return notaFiscal; }
            set { notaFiscal = value; }
        }

    */
        public override string  getNomeTabela()
        {
 	        return this.nomeTabela;
        }
    }
}
