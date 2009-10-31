using System;
using System.Collections.Generic;
using System.Text;
using TCC.MODEL;
using TCC.DAL;

namespace TCC.BUSINESS
{
    class rUsuarioPerfil : ComandosSql
    {
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
