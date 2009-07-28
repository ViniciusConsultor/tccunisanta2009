using System;
using System.Collections.Generic;
using System.Data;
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
            try
            {
                //TODO: passar para procedure.
                //----------------------------
                query.Append(" SELECT sm.id_sub, sm.dsc_sub, sm.end_sub ");
                query.Append(" FROM Submenu sm ");
                query.Append(" INNER JOIN Menusubmenu msm ");
                query.Append(" ON sm.id_sub = msm.id_sub ");
                query.Append(" INNER JOIN Menu m ");
                query.Append(" ON msm.id_menu = m.id_menu ");
                query.Append(" INNER JOIN Perfilmenu pm ");
                query.Append(" ON m.id_menu = pm.id_menu ");
                query.Append(" INNER JOIN Perfil p ");
                query.Append(" ON pm.id_perfil = p.id_perfil ");
                query.Append(" WHERE p.id_perfil = 1 ");
                query.Append(" AND m.id_menu = " + idMenu);

                return base.ExecuteSql(query.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                query = null;
            }
        }
    }
}
