using System;
using System.Collections.Generic;
using System.Text;
using TCC.MODEL;
using TCC.DAL;

namespace TCC.BUSINESS
{
    class rUsuarioPerfil : ComandosSql
    {
        public void CadastraUsuarioPerfil(mUsuarioPerfil model)
        {
            dUsuarioPerfil dal = new dUsuarioPerfil();
            try
            {
                dal.CadastraUsuarioPerfil(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dal = null;
            }
        }

        public void ValidarInsert(mUsuarioPerfil model)
        {
            try
            {
                if (model.IdPerfil == 0 || model.IdPerfil == null)
                {
                    throw new Exceptions.PerfilSemIdExeception();
                }
                else if (model.IdUsuario == 0 || model.IdUsuario == null)
                {
                    throw new Exceptions.UsuarioSemIdException();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Insere(object model)
        {
            mUsuarioPerfil modelo = (mUsuarioPerfil)model;
            ValidarInsere(modelo);
            CadastraUsuarioPerfil(modelo);
        }

        public override void ValidarInsere(object model)
        {
            mUsuarioPerfil modelo = (mUsuarioPerfil)model;
            ValidarInsert(modelo);
        }

        public override void Deleta(object model)
        {
            throw new NotImplementedException();
        }

        public override void ValidarDeleta(object model)
        {
            throw new NotImplementedException();
        }

        public override void Altera(object model)
        {
            throw new NotImplementedException();
        }

        public override void ValidarAltera(object model)
        {
            throw new NotImplementedException();
        }
    }
}
