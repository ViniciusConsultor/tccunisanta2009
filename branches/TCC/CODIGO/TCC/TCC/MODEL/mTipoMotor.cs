using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    public class mTipoMotor : ModelPai
    {
        private int? idTipoMotor;
        private string idTipoMotorReal;
        private string dscTipoMotor;
        private bool flgAtivo;
        private string nomeTabela = "Tipomotor";

        [ColunasBancoDados ("id_tipo_motor", System.Data.SqlDbType.Int,true)]
        public int? IdTipoMotor
        {
            get { return idTipoMotor; }
            set { idTipoMotor = value; }
        }

        [ColunasBancoDados("id_tipo_motor_real", System.Data.SqlDbType.VarChar, false)]
        public string IdTipoMotorReal
        {
            get { return idTipoMotorReal; }
            set { idTipoMotorReal = value; }
        }

        [ColunasBancoDados ("dsc_tipo_motor", System.Data.SqlDbType.VarChar,false)]
        public string DscTipoMotor
        {
            get { return dscTipoMotor; }
            set { dscTipoMotor = value; }
        }

        [ColunasBancoDados ("flg_ativo", System.Data.SqlDbType.Bit,false)]
        public bool FlgAtivo
        {
            get { return flgAtivo; }
            set { flgAtivo = value; }
        }

        public override string getNomeTabela()
        {
            return this.nomeTabela;
        }
    }
}
