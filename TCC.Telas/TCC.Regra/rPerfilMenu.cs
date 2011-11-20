using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using TCC.Mapper;
using TCC.AcessoDados;

namespace TCC.Regra
{
    public class rPerfilMenu : ComandosSql
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

        public DataTable BuscaPerfilMenu(int? idPerfil)
        {
            SqlParameter param = null;
            try
            {
                if (idPerfil == 0)
                {
                    throw new NotImplementedException();
                }
                else
                {
                    param = new SqlParameter("@id_perfil", idPerfil);
                    return base.BuscaDados("sp_busca_perfilmenu_param", param);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                param = null;
            }
        }

        public void DeletaPerfilMenuporPerfil(int? idPerfil)
        {
            SqlParameter param = null;
            try
            {
                if (idPerfil == null)
                {
                    throw new NotImplementedException();
                }
                else
                {
                    param = new SqlParameter("@id_perfil", idPerfil);
                    base.BuscaDados("sp_delete_perfilmenuporperfil", param);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                param = null;
            }
        }
    }
}
