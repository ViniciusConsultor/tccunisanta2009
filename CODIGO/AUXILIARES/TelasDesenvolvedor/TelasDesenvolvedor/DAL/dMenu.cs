﻿using System;
using System.Collections.Generic;
using System.Text;
using TelasDesenvolvedor.MODEL;
using System.Data.SqlClient;

namespace TelasDesenvolvedor.DAL
{
    class dMenu : AcessoDados
    {
        public void CadastraMenu(mMenu model)
        {
            StringBuilder sql = new StringBuilder();
            try
            {
                int flgAt;
                if (model.FlgAtivo == true)
                {
                    flgAt = 1;
                }
                else
                {
                    flgAt = 0;
                }
                SqlParameter[] parametros = new SqlParameter[5];
                parametros[0] = new SqlParameter("@id_menu", model.IdMenu);
                parametros[0].SqlDbType = System.Data.SqlDbType.Int;
                parametros[1] = new SqlParameter("@dsc_menu", model.DscMenu);
                parametros[1].SqlDbType = System.Data.SqlDbType.VarChar;
                parametros[2] = new SqlParameter("@end_menu", model.EndMenu);
                parametros[2].SqlDbType = System.Data.SqlDbType.VarChar;
                parametros[3] = new SqlParameter("@dat_atl", model.DatAtl);
                parametros[3].SqlDbType = System.Data.SqlDbType.DateTime;
                parametros[4] = new SqlParameter("@flg_ativo", flgAt);
                parametros[4].SqlDbType = System.Data.SqlDbType.Bit;
                base.InsereDados("sp_cadastra_menu", parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sql = null;
            }
        }        
    }
}
