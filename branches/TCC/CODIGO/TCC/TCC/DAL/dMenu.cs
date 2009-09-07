using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace TCC.DAL
{
    class dMenu : AcessoDados
    {
        /// <summary>
        /// Busca o menu de um usuario default(deslogado).
        /// </summary>
        /// <returns>DataTable com o menu de um usuario default</returns>
        public DataTable BuscaMenuDefault(int idPerfil)
        {
            SqlParameter param;
            try
            {
                param = new SqlParameter("@id_perfil", idPerfil);
                param.SqlDbType = SqlDbType.Int;
                return base.BuscaDados("sp_busca_menu", param);
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

