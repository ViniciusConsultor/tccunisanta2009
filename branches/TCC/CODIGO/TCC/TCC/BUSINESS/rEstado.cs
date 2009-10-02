using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using TCC.DAL;
using TCC.MODEL;

namespace TCC.BUSINESS
{
    class rEstado : ComandosSql
    {
        public DataTable BuscaEstado()
        {
            dEstado dal = new dEstado();
            return dal.BuscaEstado();
        }

        public override void ValidarInsere(TCC.MODEL.ModelPai model)
        {
            base.Insere(model);
        }

        public override void ValidarDeleta(TCC.MODEL.ModelPai model)
        {
            throw new NotImplementedException();
        }

        public override void ValidarAltera(TCC.MODEL.ModelPai model)
        {
            throw new NotImplementedException();
        }
    }
}
