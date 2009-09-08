using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using TCC.DAL;
using TCC.MODEL;

namespace TCC.BUSINESS
{
    class rCliente
    {
        public DataTable BuscaCliente(string Descricao)
        {
            dCliente dal = new dCliente();
            try
            {
                return dal.BuscarCliente(Descricao);
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
