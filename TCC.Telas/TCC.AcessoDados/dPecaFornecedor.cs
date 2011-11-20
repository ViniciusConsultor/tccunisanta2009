using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace TCC.AcessoDados
{
    public class dPecaFornecedor : AcessoDados
    {
        public void DeletaPecasAssociadasFornecedor(int idPeca)
        {
            SqlParameter param = null;
            try
            {
                param = new SqlParameter("@id_peca", idPeca);
                base.ExecutaProcedure("sp_deleta_pecaFornecedor1", param);
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
