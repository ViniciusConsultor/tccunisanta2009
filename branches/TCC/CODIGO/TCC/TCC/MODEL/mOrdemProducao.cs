using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    public class mOrdemProducao : ModelPai
    {
        private int id_ordem;
        private string dsc_ordem;
        private int id_depto;
        private int id_motor;
        private int id_grupo;
        private int id_tipo_produto;
        private string nomeTabela = "Ordemproducao";

        [ColunasBancoDados ("id_ordem", System.Data.SqlDbType.Int,true)]
        public int Id_ordem
        {
            get { return id_ordem; }
            set { id_ordem = value; }
        }

        [ColunasBancoDados ("dsc_ordem", System.Data.SqlDbType.VarChar,false)]
        public string Dsc_ordem
        {
            get { return dsc_ordem; }
            set { dsc_ordem = value; }
        }

        [ColunasBancoDados ("id_depto", System.Data.SqlDbType.Int,false)]
        public int Id_depto
        {
            get { return id_depto; }
            set { id_depto = value; }
        }

        [ColunasBancoDados ("id_motor", System.Data.SqlDbType.Int,false)]
        public int Id_motor
        {
            get { return id_motor; }
            set { id_motor = value; }
        }

        [ColunasBancoDados ("id_grupo", System.Data.SqlDbType.Int,false)]
        public int Id_grupo
        {
            get { return id_grupo; }
            set { id_grupo = value; }
        }

        [ColunasBancoDados ("id_tipo_produto", System.Data.SqlDbType.Int,false)]
        public int Id_tipo_produto
        {
            get { return id_tipo_produto; }
            set { id_tipo_produto = value; }
        }

        public override string getNomeTabela()
        {
            return this.nomeTabela;
        } 
    }
}
