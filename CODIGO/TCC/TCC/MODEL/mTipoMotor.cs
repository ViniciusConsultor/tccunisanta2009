using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    public class mTipoMotor : ModelPai
    {
        private string idTipoMotor;
        private string dscTipoMotor;
        private bool flgAtivo;
        private string nomeTabela = "Tipomotor";

        [ColunasBancoDados ("id_tipo_motor", System.Data.SqlDbType.Int,true)]
        public string IdTipoMotor
        {
            get { return idTipoMotor; }
            set { idTipoMotor = value; }
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
