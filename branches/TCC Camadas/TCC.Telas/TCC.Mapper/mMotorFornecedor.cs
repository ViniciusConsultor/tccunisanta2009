using Kaue.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.Mapper
{
  public  class mMotorFornecedor: ModelPai
    {
        private int? id_motor;
        private int? id_forn;
        private DateTime dat_alt;
        private bool flg_ativo;
        private string nomeTabela = "Motorfornecedor";

        [ColunasBancoDados("Id_motor", System.Data.SqlDbType.Int, true)]
        public int? Id_motor
        {
            get { return id_motor; }
            set { id_motor = value; }
        }

        [ColunasBancoDados("Id_forn", System.Data.SqlDbType.Int, true)]
        public int? Id_forn
        {
            get { return id_forn; }
            set { id_forn = value; }
        }

        [ColunasBancoDados("Dat_alt", System.Data.SqlDbType.DateTime, false)]
        public DateTime Dat_alt
        {
            get { return dat_alt; }
            set { dat_alt = value; }
        }

        [ColunasBancoDados("Flg_ativo", System.Data.SqlDbType.Bit, false)]
        public bool Flg_ativo
        {
            get { return flg_ativo; }
            set { flg_ativo = value; }
        }
 
        public override string getNomeTabela()
        {
            return this.nomeTabela;
        }
    }
}
