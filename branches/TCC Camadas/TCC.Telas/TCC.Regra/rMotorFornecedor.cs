using System;
using System.Collections.Generic;
using System.Text;
using TCC.Mapper;
using TCC.AcessoDados;

namespace TCC.Regra
{
    public class rMotorFornecedor : ComandosSql
    {
        public override void ValidarInsere(ModelPai model)
        {
            base.Insere(model);
        }

        public override void ValidarDeleta(ModelPai model)
        {
            base.Deleta(model);
        }

        public override void ValidarAltera(ModelPai model)
        {        
            base.Altera(model);
        }
    }
}
