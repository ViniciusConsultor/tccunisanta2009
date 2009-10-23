using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    public class mCompra : ModelPai
    {
        private int idDepto;
        private int idCompra;
        private DateTime dat;
        private string obs;
        private int idFornecedor;
        private int idMotorCompra;
        private int idPeca;
        private int qtd;
        private double valor;
        private string notaFiscal;
        private int idTipoProduto;
        private string nomeTabela = "compra";

        [ColunasBancoDados("id_depto", System.Data.SqlDbType.Int,false)]
        public int IdDepto
        {
            get { return idDepto; }
            set { idDepto = value; }
        }

        [ColunasBancoDados ("id_compra", System.Data.SqlDbType.Int,true)]
        public int IdCompra
        {
            get { return idCompra; }
            set { idCompra = value; }
        }

        [ColunasBancoDados ("dat", System.Data.SqlDbType.DateTime,false)]
        public DateTime Dat
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

        [ColunasBancoDados ("id_forn", System.Data.SqlDbType.Int,false)]
        public int IdFornecedor
        {
            get { return idFornecedor; }
            set { idFornecedor = value; }
        }

        [ColunasBancoDados ("id_motor", System.Data.SqlDbType.Int,false)]
        public int IdMotorCompra
        {
            get { return idMotorCompra; }
            set { idMotorCompra = value; }
        }

        [ColunasBancoDados ("qtd", System.Data.SqlDbType.Int,false)]
        public int Qtd
        {
            get { return qtd; }
            set { qtd = value; }
        }

        [ColunasBancoDados ("valor", System.Data.SqlDbType.Int,false)]
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        [ColunasBancoDados ("nota_fisc", System.Data.SqlDbType.VarChar,false)]
        public string NotaFiscal
        {
            get { return notaFiscal; }
            set { notaFiscal = value; }
        }

        [ColunasBancoDados ("id_tipo_produto", System.Data.SqlDbType.Int,false)]
        public int IdTipoProduto
        {
            get { return idTipoProduto; }
            set { idTipoProduto = value; }
        }

        [ColunasBancoDados("id_peca", System.Data.SqlDbType.Int, false)]
        public int IdPeca
        {
            get { return idPeca; }
            set { idPeca = value; }
        }

        public override string  getNomeTabela()
        {
 	        return this.nomeTabela;
        }
    }
}
