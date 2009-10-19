using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace TCC.BUSINESS
{
    class rPeca:ComandosSql
    {
        public string BuscaIdMaximoPeca()
        {
            try
            {
                return base.BuscaIdMaximoTabelas("id_peca", "peca");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public override void ValidarInsere(TCC.MODEL.ModelPai model)
        {
            throw new NotImplementedException();
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
