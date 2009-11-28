using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TCC.BUSINESS
{
    class rPecaFornecedor : ComandosSql
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
            DAL.dPecaFornecedor dal = new TCC.DAL.dPecaFornecedor();
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

        public override void ValidarInsere(TCC.MODEL.ModelPai model)
        {
            base.Insere(model);
        }

        public override void ValidarDeleta(TCC.MODEL.ModelPai model)
        {
            throw new NotImplementedException();
        }

        public override void ValidarAltera(TCC.MODEL.ModelPai model)
        {
            throw new NotImplementedException();
        }
    }
}
