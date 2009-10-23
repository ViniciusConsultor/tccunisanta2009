using System;
using System.Collections.Generic;
using System.Text;
using TCC.MODEL;
using TCC.DAL;

namespace TCC.BUSINESS
{
    class rUsuarioPerfil : ComandosSql
    {
        public void Validar(mUsuarioPerfil model)
        {
            try
            {
                if (model.IdPerfil == 0)
                {
                    throw new Exceptions.CodigoPerfilVazioExeception();
                }
                else if (model.IdUsuario == 0)
                {
                    throw new Exceptions.CodigoUsuarioVazioExeception();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
