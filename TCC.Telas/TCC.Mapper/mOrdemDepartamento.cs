using Kaue.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.Mapper
{
   public class mOrdemDepartamento:ModelPai
    {
        private int? id_depto;
        private int? id_ordem;
        private bool flg_ativo;
        private DateTime dat_alt;
        private string nomeTabela = "Ordemdepartamento";

        [ColunasBancoDados("Id_depto", System.Data.SqlDbType.Int, true)]
        public int? Id_depto
        {
            get { return id_depto; }
            set { id_depto = value; }
        }

        [ColunasBancoDados("Id_ordem", System.Data.SqlDbType.Int, true)]
        public int? Id_ordem
        {
            get { return id_ordem; }
            set { id_ordem = value; }
        }

        [ColunasBancoDados("Flg_ativo", System.Data.SqlDbType.Bit, false)]
        public bool Flg_ativo
        {
            get { return flg_ativo; }
            set { flg_ativo = value; }
        }

        [ColunasBancoDados("Dat_alt", System.Data.SqlDbType.DateTime, false)]
        public DateTime Dat_alt
        {
            get { return dat_alt; }
            set { dat_alt = value; }
        }
        public override string getNomeTabela()
        {
            return this.nomeTabela;
        }
       
    }
}
