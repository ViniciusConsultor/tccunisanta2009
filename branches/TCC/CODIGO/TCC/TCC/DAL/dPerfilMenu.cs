using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using TCC.MODEL;

namespace TCC.DAL
{
    class dPerfilMenu : AcessoDados
    {
        public void CadastraPerfilMenu(mPerfilMenu model)
        {
            ModelAuxiliar mod;
            SqlParameter[] parametros;
            try
            {
                mod = new ModelAuxiliar(model.GetType(), model);
                parametros = mod.BuscaNomeParametros();
                base.InsereDados("sp_insert_perfilMenu", parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                mod = null;
                parametros = null;
            }
        }
    }
}
