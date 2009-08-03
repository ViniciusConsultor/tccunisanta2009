using System;
using System.Collections.Generic;
using System.Text;
using TelasDesenvolvedor.MODEL;
using System.Data.SqlClient;

namespace TelasDesenvolvedor.DAL
{
    class dPerfil : AcessoDados
    {
        public void CadastraPerfil(mPerfil model)
        {
            StringBuilder sql = new StringBuilder();
            try
            {
                ModelAuxiliar mod = new ModelAuxiliar(model.GetType(), model);
                SqlParameter[] parametros = mod.BuscaNomeParametros();
                base.InsereDados("sp_insert_perfil", parametros);
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
