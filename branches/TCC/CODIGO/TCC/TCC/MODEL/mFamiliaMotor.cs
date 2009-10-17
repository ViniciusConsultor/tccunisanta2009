﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    public class mFamiliaMotor : ModelPai
    {
        private int idFamiliaMotor;
        private int idNumMotor;
        private int idGrupo;
        private int idTipoMotor;
        private string dscFamiliaMotor;
        private bool flgAtivo;
        private int idMotor;
        private int idEstoque;
        private string nomeTabela = "Familiamotor";

        [ColunasBancoDados ("id_fam_motor", System.Data.SqlDbType.Int,true)]
        public int IdFamiliaMotor
        {
            get { return idFamiliaMotor; }
            set { idFamiliaMotor = value; }
        }

        [ColunasBancoDados ("id_num_motor", System.Data.SqlDbType.Int,false)]
        public int IdNumMotor
        {
            get { return idNumMotor; }
            set { idNumMotor = value; }
        }

        [ColunasBancoDados ("id_grupo", System.Data.SqlDbType.Int,false)]
        public int IdGrupo
        {
            get { return idGrupo; }
            set { idGrupo = value; }
        }

        [ColunasBancoDados ("id_tipo_motor", System.Data.SqlDbType.Int,false)]
        public int IdTipoMotor
        {
            get { return idTipoMotor; }
            set { idTipoMotor = value; }
        }

        [ColunasBancoDados("dsc_fam_motor", System.Data.SqlDbType.VarChar,false)]
        public string DscFamiliaMotor
        {
            get { return dscFamiliaMotor; }
            set { dscFamiliaMotor = value; }
        }

        [ColunasBancoDados ("flg_ativo", System.Data.SqlDbType.Bit,false)]
        public bool FlgAtivo
        {
            get { return flgAtivo; }
            set { flgAtivo = value; }
        }

        [ColunasBancoDados ("id_motor", System.Data.SqlDbType.Int,false)]
        public int IdMotor
        {
            get { return idMotor; }
            set { idMotor = value; }
        }

        [ColunasBancoDados ("id_estoque", System.Data.SqlDbType.Int,false)]
        public int IdEstoque
        {
            get { return idEstoque; }
            set { idEstoque = value; }
        }

        public override string getNomeTabela()
        {
            return this.nomeTabela;
        }
    }
}
