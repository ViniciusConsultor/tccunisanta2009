using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    public class mMotorEstoque : ModelPai
    {
        private int id_estoq;
        private int? id_motor;
        private DateTime dat_alt;
        private int? qtd;
        private bool flg_ativo;
        private string nometabela = "Motorestoque";



        [ColunasBancoDados("Id_estoq", System.Data.SqlDbType.Int, true)]
        public int Id_estoq
        {
            get { return id_estoq; }
            set { id_estoq = value; }
        }

        [ColunasBancoDados("Id_motor", System.Data.SqlDbType.Int, true)]
        public int? Id_motor
        {
            get { return id_motor; }
            set { id_motor = value; }
        }

        [ColunasBancoDados("Dat_alt", System.Data.SqlDbType.DateTime, false)]
        public DateTime Dat_alt
        {
            get { return dat_alt; }
            set { dat_alt = value; }
        }

        [ColunasBancoDados("Qtd", System.Data.SqlDbType.Int, false)]
        public int? Qtd
        {
            get { return qtd; }
            set { qtd = value; }
        }

        [ColunasBancoDados("Flg_ativo", System.Data.SqlDbType.Bit, false)]
        public bool Flg_ativo
        {
            get { return flg_ativo; }
            set { flg_ativo = value; }
        }

        public override string getNomeTabela()
        {
            return nometabela;
        }
    }
}
