using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace TCC.BUSINESS
{
    class rTipoMotor : ComandosSql
    {
        public string BuscaIdMaximo()
        {
            try
            {
                return base.BuscaIdMaximoTabelas("id_tipo_motor", "Tipomotor");
            }
            catch (Exception)
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