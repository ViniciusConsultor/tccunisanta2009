using System;
using System.Collections.Generic;
using System.Text;
using TCC.MODEL;
using TCC.DAL;

namespace TCC.BUSINESS
{
    class rPerfilMenu
    {
        public void CadastraPerfilMenu(mPerfilMenu model)
        {
            dPerfilMenu dal = new dPerfilMenu();
            try
            {
                dal.CadastraPerfilMenu(model);
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
