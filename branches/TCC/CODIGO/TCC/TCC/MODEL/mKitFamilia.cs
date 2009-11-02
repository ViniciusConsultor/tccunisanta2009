﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    class mKitFamilia : ModelPai
    {
        private int? id_kit;
        private int? id_farm_motor;
        private DateTime dat_alt;
        private bool flg_ativo;

        [ColunasBancoDados("Id_kit", System.Data.SqlDbType.VarChar, true)]
        public int? Id_kit
        {
            get { return id_kit; }
            set { id_kit = value; }
        }

        [ColunasBancoDados("nomId_farm_motor", System.Data.SqlDbType.VarChar, true)]
        public int? Id_farm_motor
        {
            get { return id_farm_motor; }
            set { id_farm_motor = value; }
        }

        [ColunasBancoDados("Dat_alt", System.Data.SqlDbType.VarChar, false)]
        public DateTime Dat_alt
        {
            get { return dat_alt; }
            set { dat_alt = value; }
        }

        [ColunasBancoDados("Flg_ativo", System.Data.SqlDbType.VarChar, false)]
        public bool Flg_ativo
        {
            get { return flg_ativo; }
            set { flg_ativo = value; }
        }


    }
}