using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TCC.Mapper;
using TCC.AcessoDados;

namespace TCC.Regra
{
    public class rMenu
    {
        /// <summary>
        /// Busca o menu de um usuario default(deslogado).
        /// </summary>
        /// <returns>DataTable com o menu de um usuario default</returns>
        public DataTable BuscaMenu(int idPerfil)
        {
            dMenu dal = new dMenu();
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
            dMenu dal = new dMenu();
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
