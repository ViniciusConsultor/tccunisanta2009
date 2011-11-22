using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TCC.AcessoDados;
using TCC.Mapper;

namespace TCC.Regra
{
    public class rPecaFornecedor : ComandoSql
    {
        public DataTable BuscaFornecedoresAssociadosPeca(int idPeca)
        {
            SqlParameter param = null;
            try
            {
                param = new SqlParameter("@id_peca", idPeca);
                return base.BuscaDados("sp_busca_pecaFornecedor", param);
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

        public void DeletaPecasAssociadasFornecedor(int idPeca)
        {
            dPecaFornecedor dal = new dPecaFornecedor();
            try
            {
                dal.DeletaPecasAssociadasFornecedor(idPeca);
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
