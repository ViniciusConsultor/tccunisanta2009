using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    public class mVenda : ModelPai
    {
        private int idVenda;
        private int? idMotor;
        private int id_cli;
        private DateTime datVenda;
        private int? qtd;
        private double? valor;
        private string notaFisc;
        private DateTime datSaida;
        private int idOrdem;
        private int idTipoProduto;
        private int idGrupo;
        private string nomeTabela = "Venda";

        [ColunasBancoDados ("id_venda", System.Data.SqlDbType.Int,true)]
        public int IdVenda
        {
            get { return idVenda; }
            set { idVenda = value; }
        }

        [ColunasBancoDados ("id_motor", System.Data.SqlDbType.Int,false)]
        public int? IdMotor
        {
            get { return idMotor; }
            set { idMotor = value; }
        }

        [ColunasBancoDados ("id_cli", System.Data.SqlDbType.Int,false)]
        public int Id_cli
        {
            get { return id_cli; }
            set { id_cli = value; }
        }

        [ColunasBancoDados ("dat_venda", System.Data.SqlDbType.DateTime,false)]
        public DateTime DatVenda
        {
            get { return datVenda; }
            set { datVenda = value; }
        }

        [ColunasBancoDados ("qtd", System.Data.SqlDbType.Int,false)]
        public int? Qtd
        {
            get { return qtd; }
            set { qtd = value; }
        }

        [ColunasBancoDados ("valor", System.Data.SqlDbType.Int,false)]
        public double? Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        [ColunasBancoDados ("nota_fisc", System.Data.SqlDbType.VarChar,false)]
        public string NotaFisc
        {
            get { return notaFisc; }
            set { notaFisc = value; }
        }

        [ColunasBancoDados ("dat_saida", System.Data.SqlDbType.DateTime,false)]
        public DateTime DatSaida
        {
            get { return datSaida; }
            set { datSaida = value; }
        }

        [ColunasBancoDados ("id_ordem", System.Data.SqlDbType.Int,false)]
        public int IdOrdem
        {
            get { return idOrdem; }
            set { idOrdem = value; }
        }

        [ColunasBancoDados ("id_tipo_produto", System.Data.SqlDbType.Int,false)]
        public int IdTipoProduto
        {
            get { return idTipoProduto; }
            set { idTipoProduto = value; }
        }

        [ColunasBancoDados ("id_grupo", System.Data.SqlDbType.Int,false)]
        public int IdGrupo
        {
            get { return idGrupo; }
            set { idGrupo = value; }
        }

        public override string getNomeTabela()
        {
            return this.nomeTabela;
        }
    }
}
