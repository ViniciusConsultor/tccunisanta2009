using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace TCC.BUSINESS
{
    class rMenu
    {
        /// <summary>
        /// Busca o menu de um usuario default(deslogado).
        /// </summary>
        /// <returns>DataTable com o menu de um usuario default</returns>
        public DataTable BuscaMenuDefault()
        {
            DAL.dMenu dal = new TCC.DAL.dMenu();
            try
            {
                return dal.BuscaMenuDefault();
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
