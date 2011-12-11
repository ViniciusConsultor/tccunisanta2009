using System;
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
                ModelAuxiliar mod = new ModelAuxiliar(model.GetType(), model);
                SqlParameter[] parametros = mod.BuscaNomeParametros();
                base.InsereDados("sp_insert_menu", parametros);
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
