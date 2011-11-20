using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using TCC.AcessoDados;
using TCC.Mapper;

namespace TCC.Regra
{
    public class rEstado : ComandosSql
    {
        public DataTable BuscaEstado()
        {
            dEstado dal = new dEstado();
            return dal.BuscaEstado();
        }

        public override void ValidarInsere(ModelPai model)
        {
            base.Insere(model);
        }

        public override void ValidarDeleta(ModelPai model)
        {
            throw new NotImplementedException();
        }

        public override void ValidarAltera(ModelPai model)
        {
            throw new NotImplementedException();
        }
    }
}
