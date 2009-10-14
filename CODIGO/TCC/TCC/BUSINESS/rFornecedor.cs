using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TCC.MODEL;
using TCC.DAL;

namespace TCC.BUSINESS
{
    class rFornecedor : ComandosSql
    {
        public int BuscaIdMaximoFornecedor()
        {
            dFornecedor dal = new dFornecedor();
            DataTable dt;
            int idFornecedor;
            try
            {
                dt = base.BuscaIdMaximoTabelas("id_fornecedor", "fornecedor");
                if (dt.Rows[0]["max"] == DBNull.Value || dt.Rows[0]["max"] == null)
                {
                    idFornecedor = 0;
                }
                else
                {
                    idFornecedor = Convert.ToInt32(dt.Rows[0]["max"]);
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

        public DataTable BuscaFornecedor(string Descricao)
        {
            SqlParameter param = null;
            try
            {
                if (string.IsNullOrEmpty(Descricao) == true)
                {
                    return base.BuscaDados("sp_busca_fornecedor");
                }
                else
                {
                    param = new SqlParameter("@nomeFornecedor", Descricao);
                    return base.BuscaDados("sp_busca_fornecedor_param", param);
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
