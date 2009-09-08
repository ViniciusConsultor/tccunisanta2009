using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using TCC.MODEL;

namespace TCC.DAL
{
    class dDepartamento : AcessoDados
    {
        public void CadastraDepartamento(mDepartamento model)
        {
            ModelAuxiliar mod = new ModelAuxiliar(model.GetType(), model);
            try
            {
                SqlParameter[] parametros = mod.BuscaNomeParametros();
                base.InsereDados("sp_insert_departamento", parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                mod = null;
            }
        }

        public DataTable BuscaIdMaximoDepartamento()
        {
            try
            {
                return base.BuscaDados("sp_busca_maxDepto");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
