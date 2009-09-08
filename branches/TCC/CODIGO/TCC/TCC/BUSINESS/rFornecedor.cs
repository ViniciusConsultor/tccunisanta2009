using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using TCC.MODEL;
using TCC.DAL;

namespace TCC.BUSINESS
{
    class rFornecedor
    {
        public void CadastraFornecedor(mFornecedor model)
        {
            dFornecedor dal = new dFornecedor();
            try
            {
                dal.CadastraFornecedor(model);
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

        public int BuscaIdMaximoFornecedor()
        {
            dFornecedor dal = new dFornecedor();
            DataTable dt;
            int idFornecedor;
            try
            {
                dt = dal.BuscaIdMaximoFornecedor();
                if (dt.Rows[0]["id_fornecedor"] == DBNull.Value || dt.Rows[0]["id_fornecedor"] == null)
                {
                    idFornecedor = 0;
                }
                else
                {
                    idFornecedor = Convert.ToInt32(dt.Rows[0]["id_fornecedor"]);
                }
                return ++idFornecedor;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dal = null;
                dt = null;
            }
        }
    }
}
