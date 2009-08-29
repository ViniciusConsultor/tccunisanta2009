using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace TCC.DAL
{
    class dTipoUsuario : AcessoDados
    {
        public DataTable BuscaTipoUsuario(string Descricao)
        {
            SqlParameter param;
            try
            {
                if (string.IsNullOrEmpty(Descricao) == true)
                {
                    return base.BuscaDados("sp_busca_tipoUsuario");
                }
                else
                {
                    param = new SqlParameter("@dsc_tipo_usuario", Descricao);
                    param.SqlDbType = SqlDbType.VarChar;
                    return base.BuscaDados("sp_busca_tipoUsuario_Param", param);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                param = null;
            }
        }
    }
}
