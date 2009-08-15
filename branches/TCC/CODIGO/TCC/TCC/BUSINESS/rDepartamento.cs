using System;
using System.Collections.Generic;
using TCC.DAL;
using TCC.MODEL;
using System.Text;

namespace TCC.BUSINESS
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
