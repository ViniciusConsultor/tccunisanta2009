using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using TCC.MODEL;

namespace TCC.DAL
{
    class dFornecedor : AcessoDados
    {
        public void CadastraFornecedor(mFornecedor model)
        {
            ModelAuxiliar mod;
            SqlParameter[] parametros;
            try
            {
                mod = new ModelAuxiliar(model.GetType(), model);
                parametros = mod.BuscaNomeParametros();
                base.ExecutaProcedure("sp_insert_fornecedor", parametros);
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

        public DataTable BuscaIdMaximoFornecedor()
        {
            try
            {
                return base.BuscaDados("sp_busca_maxFornecedor");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
