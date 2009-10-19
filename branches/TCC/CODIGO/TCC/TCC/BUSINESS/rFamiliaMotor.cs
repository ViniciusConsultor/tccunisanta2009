using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.BUSINESS
{
    class rFamiliaMotor : ComandosSql
    {
        public string BuscaIdMaximo()
        {
            try
            {
                return base.BuscaIdMaximoTabelas("id_fam_motor", "Familiamotor");
            }
            catch (Exception ex)
            {
                throw ex;
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
