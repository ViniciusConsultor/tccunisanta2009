using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TCC.MODEL;
using TCC.DAL;

namespace TCC.BUSINESS
{
    class rPerfil : ComandosSql
    {

        public DataTable BuscaPerfil(string Descricao)
        {
            dPerfil dal = new dPerfil();
            try
            {
                return dal.BuscaPerfil(Descricao);
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
