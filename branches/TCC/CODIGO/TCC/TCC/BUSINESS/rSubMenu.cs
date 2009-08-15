using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TCC.MODEL;
using TCC.DAL;

namespace TCC.BUSINESS
{
    class rSubMenu
    {
        /// <summary>
        /// Busca os SubMenus de um usuario default
        /// </summary>
        /// <param name="idMenu">id do Menu para buscar os SubMenus</param>
        /// <returns>DataTable com os Submenus</returns>
        public DataTable BuscaSubMenuDefault(int idMenu)
        {
            DAL.dSubMenu dal = new TCC.DAL.dSubMenu();
            try
            {
                return dal.BuscaSubMenuDefault(idMenu);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dal = null;
            }
        }
    }
}
