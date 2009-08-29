using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TCC.MODEL;


namespace TCC.DAL
{
    class dUsuario : AcessoDados
    {
        public void CadastraUsuario(mUsuario model)
        {
            ModelAuxiliar mod;
            SqlParameter[] parametros;
            try
            {
                mod = new ModelAuxiliar(model.GetType(), model);
                parametros = mod.BuscaNomeParametros();
                base.InsereDados("sp_insert_usuario", parametros);
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

        public DataTable BuscaIdMaximoUsuario()
        {
            try
            {
                return base.BuscaDados("sp_busca_maxUsuario");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
