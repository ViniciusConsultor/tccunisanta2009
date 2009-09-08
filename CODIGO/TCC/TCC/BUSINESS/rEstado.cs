using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using TCC.DAL;

namespace TCC.BUSINESS
{
    public class rEstado
    {
        public DataTable BuscaEstado()
        {
            dEstado dal = new dEstado();
            return dal.BuscaEstado();
        }
    }
}
