using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TCC.MODEL;

namespace TCC.DAL
{
    class dCliente : AcessoDados
    {

        public DataTable BuscaIdMaximoCliente()
        {
            try
            {
                return base.BuscaDados("sp_busca_maxCliente");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
