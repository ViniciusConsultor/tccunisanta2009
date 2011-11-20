using Kaue.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.Mapper
{
    public class mCompraPeca : ModelPai
    {
        private int? idPeca;
        private double ultimoPreco;
        private int? idCompra;
        private string nomeTabela = "Comprapeca";

        [ColunasBancoDados("id_peca", System.Data.SqlDbType.Int,true)]
        public int? IdPeca
        {
            get { return idPeca; }
            set { idPeca = value; }
        }

        [ColunasBancoDados("ultim_preco", System.Data.SqlDbType.Decimal,false)]
        public double UltimoPreco
        {
            get { return ultimoPreco; }
            set { ultimoPreco = value; }
        }

        [ColunasBancoDados ("id_compra", System.Data.SqlDbType.Int,false)]
        public int? IdCompra
        {
            get { return idCompra; }
            set { idCompra = value; }
        }

        public override string getNomeTabela()
        {
            return this.nomeTabela;
        }
    }
}
