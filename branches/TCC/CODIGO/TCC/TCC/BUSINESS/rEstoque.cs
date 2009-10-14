using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TCC.MODEL;
using TCC.DAL;

namespace TCC.BUSINESS
{
    class rEstoque : ComandosSql
    {
        public int BuscaIdMaximoEstoque()
        {
            dEstoque dal = new dEstoque();
            DataTable dt;
            int id_estoque;
            try
            {
                dt = base.BuscaIdMaximoTabelas("id_estoque", "estoque");
                if (dt.Rows[0]["max"] == DBNull.Value || dt.Rows[0]["max"] == null)
                {
                    id_estoque = 0;
                }
                else
                {
                    id_estoque = Convert.ToInt32(dt.Rows[0]["max"]);
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

        public DataTable BuscaEstoque(string Descricao)
        {
            SqlParameter param = null;
            try
            {
                if (string.IsNullOrEmpty(Descricao) == true)
                {
                    return base.BuscaDados("sp_busca_estoque");
                }
                else
                {
                    param = new SqlParameter("@nom_estoque", Descricao);
                    return base.BuscaDados("sp_busca_estoque_param", param);
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
