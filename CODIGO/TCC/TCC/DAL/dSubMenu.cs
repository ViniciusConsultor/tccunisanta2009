using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace TCC.DAL
{
    class dSubMenu : AcessoDados
    {
        /// <summary>
        /// Busca os SubMenus de um usuario default
        /// </summary>
        /// <param name="idMenu">id do Menu para buscar os SubMenus</param>
        /// <returns>DataTable com os Submenus</returns>
        public DataTable BuscaSubMenuDefault(int idMenu)
        {
            StringBuilder query = new StringBuilder();
            SqlParameter parametro;
            try
            {
                parametro = new SqlParameter("@id_menu", idMenu);
                parametro.SqlDbType = SqlDbType.Int;

                return base.BuscaDados("sp_busca_submenu_default", parametro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                query = null;
                parametro = null;
            }
        }
    }
}
