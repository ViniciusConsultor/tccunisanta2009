using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using TCC.MODEL;

namespace TCC.DAL
{
    class dUsuarioPerfil : AcessoDados
    {
        public void CadastraUsuarioPerfil(mUsuarioPerfil model)
        {
            SqlParameter[] param = null;
            ModelAuxiliar mod;
            try
            {
                mod = new ModelAuxiliar(model.GetType(), model);
                param = mod.BuscaNomeParametros();
                base.InsereDados("sp_insert_usuarioPerfil", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                param = null;
                mod = null;
            }
        }
    }
}
