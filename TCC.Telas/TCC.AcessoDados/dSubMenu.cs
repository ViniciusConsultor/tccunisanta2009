using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace TCC.AcessoDados
{
    public class dSubMenu : AcessoDados
    {
        /// <summary>
        /// Busca os SubMenus de um usuario default
        /// </summary>
        /// <param name="idMenu">id do Menu para buscar os SubMenus</param>
        /// <returns>DataTable com os Submenus</returns>
        public DataTable BuscaSubMenu(int idMenu, int idPerfil)
        {
            SqlParameter[] parametro = new SqlParameter[2];
            try
            {
                parametro[0] = new SqlParameter("@id_menu", idMenu);
                parametro[1] = new SqlParameter("@id_perfil", idPerfil);
                parametro[0].SqlDbType = SqlDbType.Int;
                parametro[1].SqlDbType = SqlDbType.Int;

                return base.BuscaDados("sp_busca_submenu", parametro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                parametro = null;
            }
        }
    }
}
