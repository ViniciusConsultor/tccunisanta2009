using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TCC.MODEL;

namespace TCC.DAL
{
    class dCliente : AcessoDados
    {
        public void CadastraCliente(mCliente model)
        {
            ModelAuxiliar mod;
            SqlParameter[] parametros;
            try
            {
                mod = new ModelAuxiliar(model.GetType(), model);
                parametros = mod.BuscaNomeParametros();
                base.ExecutaProcedure("sp_insert_cliente", parametros);
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

        public DataTable BuscaIdMaximoCliente()
        {
            try
            {
                return base.BuscaDados("sp_busca_maxCliente");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
