using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TCC.Mapper;
using TCC.AcessoDados;

namespace TCC.Regra
{
    public class rOrdemServico : ComandoSql
    {
        private int BuscaIdMaximo()
        {
            try
            {
                return Convert.ToInt32(base.BuscaIdMaximoTabelas("id_ordem_serv", "Ordemservico"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable buscaOrdemServico(string ordemServ)
        {
            SqlParameter parametro = null;
            try
            {
                if (string.IsNullOrEmpty(ordemServ) == true)
                {
                    return base.BuscaDados("sp_busca_ordemservico");
                }
                else
                {
                    parametro = new SqlParameter("@id_ordem_serv", ordemServ);
                    return base.BuscaDados("sp_busca_ordemservico_param", parametro);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                parametro = null;
            }
        }

        public DataTable buscaOrdemServicoParamVenda(string codVenda)
        {
            SqlParameter parametro = null;
            try
            {
                if (string.IsNullOrEmpty(codVenda) == true)
                {
                    return base.BuscaDados("sp_busca_ordemservico");
                }
                else
                {
                    parametro = new SqlParameter("@id_venda", codVenda);
                    return base.BuscaDados("sp_busca_ordemservico_paramvenda", parametro);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                parametro = null;
            }
        }

        public override void ValidarInsere(ModelPai model)
        {
            throw new NotImplementedException();
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
