using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace TCC.BUSINESS
{
    class rPedidoVenda : ComandosSql
    {

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
 