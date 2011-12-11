using System;
using System.Collections.Generic;
using System.Text;
using TelasDesenvolvedor.MODEL;
using TelasDesenvolvedor.DAL;

namespace TelasDesenvolvedor.BUSINESS
{
    class rMenu
    {
        public void CadastraMenu(mMenu model)
        {
            dMenu dalMenu = new dMenu();
            try
            {
                dalMenu.CadastraMenu(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dalMenu = null;
            }
        }
    }
}
