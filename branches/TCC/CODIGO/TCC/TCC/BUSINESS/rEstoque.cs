using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using TCC.MODEL;
using TCC.DAL;

namespace TCC.BUSINESS
{
    class rEstoque
    {
        public void cadstraEstoque(mEstoque model)
        {
            dEstoque dal = new dEstoque();
            try
            {
                dal.cadastraEstoque(model);
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
        public int BuscaIdMaximoEstoque()
        {
            dEstoque dal = new dEstoque();
            DataTable dt;
            int id_estoque;
            try
            {
                dt = dal.BuscaIdMaximoEstoque();
                if (dt.Rows[0]["id_estoque"] == DBNull.Value || dt.Rows[0]["id_estoque"] == null)
                {
                    id_estoque = 0;
                }
                else
                {
                    id_estoque = Convert.ToInt32(dt.Rows[0]["id_estoque"]);
                }
                return ++id_estoque;
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
