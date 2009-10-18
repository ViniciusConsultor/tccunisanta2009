using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TCC.MODEL;
using TCC.DAL;

namespace TCC.BUSINESS
{
    class rMenu
    {
        /// <summary>
        /// Busca o menu de um usuario default(deslogado).
        /// </summary>
        /// <returns>DataTable com o menu de um usuario default</returns>
        public DataTable BuscaMenu(int idPerfil)
        {
            DAL.dMenu dal = new TCC.DAL.dMenu();
            try
            {
                return dal.BuscaMenu(idPerfil);
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

        public DataTable TelaBuscaMenu(string Descricao)
        {
            dMenu dal = new dMenu();
            try
            {
                return dal.TelaBuscaMenu(Descricao);
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

        /// <summary>
        /// Busca os submenu filhos de um menu.
        /// </summary>
        /// <returns>DataTable com os submenu</returns>
        public DataTable BuscaSubMenu(int idMenuPai)
        {
            DAL.dMenu dal = new TCC.DAL.dMenu();
            try
            {
                return dal.BuscaSubMenu(idMenuPai);
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
