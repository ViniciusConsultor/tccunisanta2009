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
        public int BuscaIdMaximo()
        {
            try
            {
                return Convert.ToInt32(base.BuscaIdMaximoTabelas("id_forn", "Fornecedor"));
            }
            catch (Exception ex)
            {
                throw ex;
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

        /*/// <summary>
        /// Busca o fornecedor que "vende" o motor escolhido.
        /// </summary>
        /// <param name="idMotor">id do motor para ser usado como filtro</param>
        /// <returns>Resultado da busca com os fornecedores que vendem este motor</returns>
        public DataTable BuscaFornecedorMotor(int idMotor)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }

        /// <summary>
        /// Busca o fornecedor que "vende" a peça escolhida.
        /// </summary>
        /// <param name="idPeca">id da peça para ser utilizada como filtro</param>
        /// <returns>Resultado da busca com os fornecedores que vendem esta peças</returns>
        public DataTable BuscaFornecedorPeca(int idPeca)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }*/

        public void ValidaDados(mFornecedor model)
        {
            if (model.Cnpj != null)
            {
                if (this.ExisteCnpj(model.Cnpj) == true)
                {
                    throw new BUSINESS.Exceptions.Fornecedor.CNPJFornecedorExistente();
                }
            }
            else
            {
                if (this.ExisteIdentInter(model.IdentInter) == true)
                {
                    throw new BUSINESS.Exceptions.Fornecedor.IdentInterExistenteException();
                }
            }
        }

        private bool ExisteIdentInter(string identInter)
        {
            DataTable dt = null;
            SqlParameter param = null;
            try
            {
                param = new SqlParameter("@ident_inter", identInter);
                dt = base.BuscaDados("sp_existe_fornecedor_ident_inter", param);

                if (Convert.ToInt32(dt.Rows[0]["flg_existe"]) >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dt != null)
                {
                    dt.Dispose();
                    dt = null;
                }
                param = null;
            }
        }

        private bool ExisteCnpj(string cnpj)
        {
            DataTable dt = null;
            SqlParameter param = null;
            try
            {
                param = new SqlParameter("@cnpj", cnpj);
                dt = base.BuscaDados("sp_existe_fornecedor_cnpj", param);

                if (Convert.ToInt32(dt.Rows[0]["flg_existe"]) >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dt != null)
                {
                    dt.Dispose();
                    dt = null;
                }
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
