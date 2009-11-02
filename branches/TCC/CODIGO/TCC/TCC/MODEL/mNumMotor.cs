using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    public class mNumMotor : ModelPai
    {
        private int? id_num_motor;
        private string idNumMotorReal;
        private string dsc_num_motor;
        private bool flg_ativo;
        private string nomeTabela = "Numeromotor";



        [ColunasBancoDados ("id_num_motor",System.Data.SqlDbType.Int,true)]
        public int? Id_num_motor
        {
            get { return id_num_motor; }
            set { id_num_motor = value; }
        }

        [ColunasBancoDados ("dsc_num_motor", System.Data.SqlDbType.VarChar,false)]
        public string Dsc_num_motor
        {
            get { return dsc_num_motor; }
            set { dsc_num_motor = value; }
        }

        [ColunasBancoDados ("flg_ativo", System.Data.SqlDbType.Bit,false)]
        public bool Flg_ativo
        {
            get { return flg_ativo; }
            set { flg_ativo = value; }
        }

        [ColunasBancoDados("id_num_motor_real", System.Data.SqlDbType.VarChar, false)]
        public string IdNumMotorReal
        {
            get { return idNumMotorReal; }
            set { idNumMotorReal = value; }
        }

        public override string getNomeTabela()
        {
            return this.nomeTabela;
        }
    }
}
