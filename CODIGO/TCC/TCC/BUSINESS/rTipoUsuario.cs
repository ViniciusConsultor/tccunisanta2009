using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TCC.DAL;

namespace TCC.BUSINESS
{
    class rTipoUsuario
    {
        public DataTable BuscaTipoUsuario(string Descricao)
        {
            dTipoUsuario dal = new dTipoUsuario();
            try
            {
                return dal.BuscaTipoUsuario(Descricao);
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
