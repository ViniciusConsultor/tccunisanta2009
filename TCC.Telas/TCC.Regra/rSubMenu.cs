using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TCC.Mapper;
using TCC.AcessoDados;

namespace TCC.Regra
{
    public class rSubMenu
    {
        /// <summary>
        /// Busca os SubMenus de um usuario default
        /// </summary>
        /// <param name="idMenu">id do Menu para buscar os SubMenus</param>
        /// <returns>DataTable com os Submenus</returns>
        public DataTable BuscaSubMenu(int idMenu, int idPerfil)
        {
            dSubMenu dal = new dSubMenu();
            try
            {
                return dal.BuscaSubMenu(idMenu, idPerfil);
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
