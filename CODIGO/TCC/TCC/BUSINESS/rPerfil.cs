using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TCC.MODEL;
using TCC.DAL;

namespace TCC.BUSINESS
{
    class rPerfil
    {
        public void cadastraPerfil(mPerfil model)
        {
            dPerfil dalPerfil= new dPerfil();
            try
            {
                dalPerfil.CadastraPerfil(model);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dalPerfil = null;
            }
        }
    }
}
