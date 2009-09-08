using System;
using System.Collections.Generic;
using System.Text;
using TCC.MODEL;
using System.Data.SqlClient;
using System.Data;


namespace TCC.DAL
{
    class dColaborador  : AcessoDados
    {
        public void CadastraColaborador(mColaborador model)
        {
            StringBuilder sql = new StringBuilder();
            try
            {
                ModelAuxiliar mod = new ModelAuxiliar(model.GetType(), model);
                SqlParameter[] parametros = mod.BuscaNomeParametros();
                base.InsereDados("sp_insert_colaborador", parametros);
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

        public DataTable BuscaIDMaximoColaborador()
        {
            try
            {
                return base.BuscaDados("sp_busca_maxColaborador");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
