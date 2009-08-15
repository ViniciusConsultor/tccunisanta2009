using System;
using System.Collections.Generic;
using System.Text;
using TCC.MODEL;
using System.Data.SqlClient;


namespace TCC.DAL
{
    class dUsuario : AcessoDados
    {
        public void CadastraUsuario(mUsuario model)
        {
            StringBuilder sql = new StringBuilder();
            try
            {
                ModelAuxiliar mod = new ModelAuxiliar(model.GetType(), model);
                SqlParameter[] parametros = mod.BuscaNomeParametros();
                base.InsereDados("sp_insert_usuario", parametros);
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
