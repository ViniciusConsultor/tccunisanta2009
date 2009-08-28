using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace TCC.DAL
{
    class dMenu : AcessoDados
    {
        /// <summary>
        /// Busca o menu de um usuario default(deslogado).
        /// </summary>
        /// <returns>DataTable com o menu de um usuario default</returns>
        public DataTable BuscaMenuDefault()
        {
            try
            {
                return base.BuscaDados("sp_busca_menu_default");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

