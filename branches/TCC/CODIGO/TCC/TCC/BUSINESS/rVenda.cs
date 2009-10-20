using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.BUSINESS
{
    class rVenda : ComandosSql
    {
        public string BuscaidMaximo()
        {
            try
            {
                return base.BuscaIdMaximoTabelas("id_venda", "venda");
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
 