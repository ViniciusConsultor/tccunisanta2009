using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using TCC.Mapper;
using TCC.AcessoDados;

namespace TCC.Regra
{
    public class rProduto : ComandosSql
    {
        public DataTable BuscaProdutosVenda(int idProduto, int idVenda)
        {
            SqlParameter[] param = new SqlParameter[2];
            try
            {
                param[0] = new SqlParameter("@id_prdto", idProduto);
                param[1] = new SqlParameter("@id_venda", idVenda);

                return base.BuscaDados("sp_busca_tree_produto", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }

        public mProduto BuscaUnicoRegistro(int idProduto)
        {
            mProduto modelRetorno = new mProduto();
            DataTable dtRetorno = new DataTable();
            try
            {
                modelRetorno.IdProduto = idProduto;
                dtRetorno = base.BuscaUmRegistro(modelRetorno);
                modelRetorno.Deserialize(dtRetorno);
                return modelRetorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                modelRetorno = null;
                if (dtRetorno != null)
                {
                    dtRetorno.Dispose();
                    dtRetorno = null;
                }
            }
        }

        public DataTable BuscaProdutoKitCodigo(string ParametroBusca)
        {
            SqlParameter param = new SqlParameter();
            try
            {
                if (string.IsNullOrEmpty(ParametroBusca) == true)
                {
                    return base.BuscaDados("sp_busca_produto_kit");
                }
                else
                {
                    param = new SqlParameter("@id_kit_real", ParametroBusca);
                    return base.BuscaDados("sp_busca_produto_kit_param_codigo", param);
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

        public DataTable BuscaProdutoKitNome(string ParametroBusca)
        {
            SqlParameter param = new SqlParameter();
            try
            {
                if (string.IsNullOrEmpty(ParametroBusca) == true)
                {
                    return base.BuscaDados("sp_busca_produto_kit");
                }
                else
                {
                    param = new SqlParameter("@nom", ParametroBusca);
                    return base.BuscaDados("sp_busca_produto_kit_param_nome", param);
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

        public DataTable BuscaProdutoFamiliaMotorNome(string ParametroBusca)
        {
            SqlParameter param = new SqlParameter();
            try
            {
                if (string.IsNullOrEmpty(ParametroBusca) == true)
                {
                    return base.BuscaDados("sp_busca_produto_famliaMotor");
                }
                else
                {
                    param = new SqlParameter("@dsc_fam_motor", ParametroBusca);
                    return base.BuscaDados("sp_busca_produto_famliaMotor_param_nome", param);
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

        public DataTable BuscaProdutoFamiliaMotorCodigo(string ParametroBusca)
        {
            SqlParameter param = new SqlParameter();
            try
            {
                if (string.IsNullOrEmpty(ParametroBusca) == true)
                {
                    return base.BuscaDados("sp_busca_produto_famliaMotor");
                }
                else
                {
                    param = new SqlParameter("@id_fam_motor_real", ParametroBusca);
                    return base.BuscaDados("sp_busca_produto_famliaMotor_param_codigo", param);
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

        public DataTable BuscaTodosProdutos()
        {
            try
            {
                return base.BuscaDados("sp_busca_produto");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable BuscaOrdemProducao(string ParametroBusca)
        {
            SqlParameter param = new SqlParameter();
            try
            {
                if (string.IsNullOrEmpty(ParametroBusca) == true)
                {
                    return base.BuscaDados("sp_busca_ordemProducao");
                }
                else
                {
                    param = new SqlParameter("@dsc_ordem", ParametroBusca);
                    return base.BuscaDados("sp_busca_ordemProducao_param", param);
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

        public int BuscaIdMaximo()
        {
            try
            {
                return Convert.ToInt32(base.BuscaIdMaximoTabelas("id_prdto", "Produto"));
            }
            catch (Exception ex)
            {
                throw ex;
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
