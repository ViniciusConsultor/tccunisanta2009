using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelasDesenvolvedor.MODEL
{
    class mMenu
    {
        private int idMenu;
        private string dscMenu;
        private string endMenu;
        private DateTime datAtl;
        private bool flgAtivo;

        [ColunasBancoDados("id_menu", System.Data.SqlDbType.Int)]
        public int IdMenu
        {
            get { return idMenu; }
            set { idMenu = value; }
        }

        [ColunasBancoDados("dsc_menu", System.Data.SqlDbType.VarChar)]
        public string DscMenu
        {
            get { return dscMenu; }
            set { dscMenu = value; }
        }

        [ColunasBancoDados("end_menu", System.Data.SqlDbType.VarChar)]
        public string EndMenu
        {
            get { return endMenu; }
            set { endMenu = value; }
        }

        [ColunasBancoDados("dat_atl", System.Data.SqlDbType.DateTime)]
        public DateTime DatAtl
        {
            get { return datAtl = DateTime.Now; }
            set { datAtl = value; }
        }
        
        [ColunasBancoDados("flg_ativo", System.Data.SqlDbType.Bit)]
        public bool FlgAtivo
        {
            get { return flgAtivo = true; }
            set { flgAtivo = value; }
        }
    }
}
