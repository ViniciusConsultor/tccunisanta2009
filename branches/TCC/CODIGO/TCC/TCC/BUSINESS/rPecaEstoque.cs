using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TCC.MODEL;

namespace TCC.BUSINESS
{
    class rPecaEstoque : ComandosSql
    {
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

        /// <summary>
        /// Este metod busca todos os relacionamento entre peca e estoque por peca selecionada
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public DataTable BuscaPecaEstoquePorPeca(mPeca model)
        {
            SqlParameter param = null;
            try
            {
                param = new SqlParameter("@id_peca", model.IdPeca);
                return base.BuscaDados("sp_busca_pecaestoqueparampeca", param);
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

        public void DeletaPecaEstoqueporPeca(int? idPeca)
        {
            SqlParameter param = null;
            try
            {
                if (idPeca == null)
                {
                    throw new NotImplementedException();
                }
                else
                {
                    param = new SqlParameter("@id_peca", idPeca);
                    base.BuscaDados("sp_delete_pecaestoqueporperfil", param);
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
