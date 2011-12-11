using System;
using System.Collections.Generic;
using System.Text;
using TelasDesenvolvedor.MODEL;
using TelasDesenvolvedor.DAL;

namespace TelasDesenvolvedor.BUSINESS
{
    class rSubMenu
    {
        public void CadastraSubMenu(mSubMenu model)
        {
            dSubMenu dalSubMenu = new dSubMenu();
            try
            {
                dalSubMenu.CadastraSubMenu(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dalSubMenu = null;
            }
        }
    }
}