using System;
using System.Collections.Generic;
using System.Text;
using TelasDesenvolvedor.MODEL;

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
                sql.Append(" INSERT INTO Menu ");
                sql.Append(" (id_menu, dsc_menu, end_menu, dat_atl, flg_ativo) ");
                sql.Append(" VALUES (" + model.IdMenu + ", '" + model.DscMenu + "', '" + model.EndMenu + "', '" + model.DatAtl.ToString("yyyy-MM-dd") + "', " + flgAt + ")");

                base.InsereDados(sql.ToString());
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
