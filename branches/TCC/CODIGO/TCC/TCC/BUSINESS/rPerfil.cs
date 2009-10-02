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
        public int BuscaIdMaximoPerfil()
        {
            dPerfil dalPerfil = new dPerfil();
            DataTable dt;
            int idPerfil;
            try
            {
                dt = base.BuscaIdMaximoTabelas("id_perfil", "perfil");
                if (dt.Rows[0]["max"] == DBNull.Value || dt.Rows[0]["max"] == null)
                {
                    idPerfil = 0;
                }
                else
                {
                    idPerfil = Convert.ToInt32(dt.Rows[0]["max"]);
                }
                return ++idPerfil;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dalPerfil = null;
                dt = null;
            }
        }

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
