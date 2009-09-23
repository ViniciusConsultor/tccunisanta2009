using System;
using System.Collections.Generic;
using System.Text;
using TCC.MODEL;
using System.Data.SqlClient;


namespace TCC.DAL
{
    class dCadColaborador  : AcessoDados
    {
        public void CadastraColaborador(mCadColaborador model)
        {
            StringBuilder sql = new StringBuilder();
            try
            {
                ModelAuxiliar mod = new ModelAuxiliar(model.GetType(), model);
                SqlParameter[] parametros = mod.BuscaNomeParametros();    
                base.ExecutaProcedure("sp_insert_colaborador", parametros);
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
