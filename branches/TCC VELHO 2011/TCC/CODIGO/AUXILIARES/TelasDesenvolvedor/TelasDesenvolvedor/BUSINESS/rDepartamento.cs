using System;
using System.Collections.Generic;
using TelasDesenvolvedor.DAL;
using System.Text;

namespace TelasDesenvolvedor.BUSINESS
{
    class rDepartamento
    {
        public void CadastraDepartamento(MODEL.mDepartamento model)
        {
            dDepartamento dal = new dDepartamento();
            try
            {
                dal.CadastraDepartamento(model);
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
