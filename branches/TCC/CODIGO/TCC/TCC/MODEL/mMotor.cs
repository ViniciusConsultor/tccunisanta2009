﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    class mMotor : ModelPai
    {
        private int idMotor;
        private string dscMotor;
        private bool flgAtivo;
        private string nomeTabela = "motor";

        [ColunasBancoDados("id_motor_compra", System.Data.SqlDbType.Int, true)]
        public int IdMotor
        {
            get { return idMotor; }
            set { idMotor = value; }
        }

        [ColunasBancoDados("dsc_motor_compra", System.Data.SqlDbType.VarChar, false)]
        public string DscMotor
        {
            get { return dscMotor; }
            set { dscMotor = value; }
        }

        [ColunasBancoDados("flg_ativo", System.Data.SqlDbType.Bit, false)]
        public bool FlgAtivo
        {
            get { return flgAtivo; }
            set { flgAtivo = value; }
        }

        public override string getNomeTabela()
        {
            return nomeTabela;
        }
    }
}
