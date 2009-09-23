using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TCC.MODEL;

namespace TCC.DAL
{
    class dEstoque:AcessoDados
    {
        public void cadastraEstoque(mEstoque model)
        {
              ModelAuxiliar mod;
            SqlParameter[] parametros;
            try
            {
                mod = new ModelAuxiliar(model.GetType(), model);
                parametros = mod.BuscaNomeParametros();
                base.ExecutaProcedure("sp_insere_estoque", parametros);
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
        public DataTable BuscaIdMaximoEstoque()
        {
            try
            {
                return base.BuscaDados("sp_busca_maxEstoque");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
