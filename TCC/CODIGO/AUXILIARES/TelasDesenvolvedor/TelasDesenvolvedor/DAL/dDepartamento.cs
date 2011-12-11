using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using TelasDesenvolvedor.MODEL;

namespace TelasDesenvolvedor.DAL
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

            }
        }
    }
}
