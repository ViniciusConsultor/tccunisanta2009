using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TCC.Mapper;
using TCC.AcessoDados;
using System.Data.SqlClient;

namespace TCC.Regra
{
    public class rPerfil : ComandosSql
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

        public int BuscaMaxId()
        {
            return Convert.ToInt32(this.BuscaIdMaximoTabelas("id_perfil", "perfil"));
        }

        private void ValidaDados(mPerfil model)
        {
            if (this.ExisteDescricaoPerfil(model.DescPerfil) == true)
            {
                throw new Exceptions.Perfil.DescPerfilExistenteException();
            }
        }

        private bool ExisteDescricaoPerfil(string descPerfil)
        {
            DataTable dt = null;
            SqlParameter param = null;
            try
            {
                param = new SqlParameter("@dsc_perfil", descPerfil);
                dt = base.BuscaDados("sp_existe_perfil", param);
                if (Convert.ToInt32(dt.Rows[0]["flg_existe"]) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dt != null)
                {
                    dt.Dispose();
                    dt = null;
                }
                param = null;
            }
        }

        public override void ValidarInsere(ModelPai model)
        {
            this.ValidaDados((mPerfil)model);
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
