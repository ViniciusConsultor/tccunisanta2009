using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TelasDesenvolvedor.MODEL;
using TelasDesenvolvedor.DAL;

namespace TelasDesenvolvedor.BUSINESS
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
