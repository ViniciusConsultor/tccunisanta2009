using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using TCC.AcessoDados;

namespace TCC.Regra
{
    public class rOrdemProducao : ComandoSql
    {
        public DataTable BuscaOrdemProducao(string ParametroBusca)
        {
            SqlParameter param = new SqlParameter();
            try
            {
                if (string.IsNullOrEmpty(ParametroBusca) == true)
                {
                    return base.BuscaDados("sp_busca_ordemProducao");
                }
                else
                {
                    param = new SqlParameter("@dsc_ordem", ParametroBusca);
                    return base.BuscaDados("sp_busca_ordemProducao_param", param);
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

        public override void ValidarInsere(TCC.Mapper.ModelPai model)
        {
            base.Insere(model);
        }

        public override void ValidarDeleta(TCC.Mapper.ModelPai model)
        {
            throw new NotImplementedException();
        }

        public override void ValidarAltera(TCC.Mapper.ModelPai model)
        {
            throw new NotImplementedException();
        }
    }
}
