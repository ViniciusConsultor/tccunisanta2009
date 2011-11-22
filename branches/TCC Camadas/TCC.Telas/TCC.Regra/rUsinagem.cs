using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using TCC.AcessoDados;
using TCC.Mapper;

namespace TCC.Regra
{
    public class rUsinagem : ComandoSql
    {

        public DataTable BuscaUsinagem(string parametro)
        {
            SqlParameter param = null;
            try
            {
                if (string.IsNullOrEmpty(parametro) == true)
                {
                    return base.BuscaDados("sp_busca_usinagem");
                }
                else
                {
                    param = new SqlParameter("@id_peca_real", parametro);
                    return base.BuscaDados("sp_busca_usinagem_param", param);
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
