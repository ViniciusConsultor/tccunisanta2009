using System;
using System.Collections.Generic;
using System.Text;
using TelasDesenvolvedor.MODEL;
using System.Data.SqlClient;


namespace TelasDesenvolvedor.DAL
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
    }
}
