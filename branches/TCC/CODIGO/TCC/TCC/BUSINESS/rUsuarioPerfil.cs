using System;
using System.Collections.Generic;
using System.Text;
using TCC.MODEL;
using TCC.DAL;

namespace TCC.BUSINESS
{
    class rUsuarioPerfil
    {
        public void CadastraUsuarioPerfil(mUsuarioPerfil model)
        {
            dUsuarioPerfil dal = new dUsuarioPerfil();
            try
            {
                dal.CadastraUsuarioPerfil(model);
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
