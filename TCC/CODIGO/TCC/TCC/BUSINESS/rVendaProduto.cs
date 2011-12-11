using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace TCC.BUSINESS
{
    class rVendaProduto : ComandosSql
    {
        public DataTable BuscaProdutosVenda(int idVenda)
        {
            SqlParameter param = null;
            try
            {
                param = new SqlParameter("@id_venda", idVenda);
                return base.BuscaDados("sp_busca_tree_vendaproduto", param);
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
 