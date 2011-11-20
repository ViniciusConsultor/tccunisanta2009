using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TCC.AcessoDados
{
    public class dEstado : AcessoDados
    {
        public DataTable BuscaEstado()
        {
            return base.BuscaDados("sp_busca_estado");
        }
    }
}
